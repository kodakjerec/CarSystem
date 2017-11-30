using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace AutoUpCarSys
{
    public class Program
    {
        #region 引用C++的函數
        #region Connection
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        #endregion
        #endregion

        static DataTable dtCloudVer = new DataTable();//雲上版本
        static DataTable dtCarVer = new DataTable();//車機上版本
        static string PathFile = string.Empty;//車機主程式路徑
        static int retryCon = 0;//紀錄連線次數
        static List<Item> itemlist = new List<Item>(); //xml變數

        static void Main(string[] args)
        {
            #region 借用車機的xml
            XmlTextReader reader = new XmlTextReader("C:\\CarSystem\\CarSystem.exe.config");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        //Console.Write("<" + reader.Name);

                        string tmpName = "", tmpValue = "";
                        while (reader.MoveToNextAttribute()) // Read the attributes.
                        {
                            if (reader.Name == "key")
                                tmpName = reader.Value;
                            else if (reader.Name == "value")
                                tmpValue = reader.Value;
                            if (tmpName != "" && tmpValue != "")
                            {
                                itemlist.Add(new Item(tmpName, tmpValue));
                                tmpName = "";
                                tmpValue = "";
                            }
                            //Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                        }
                        //Console.WriteLine(">");
                        break;
                    //case XmlNodeType.Text: //Display the text in each element.
                    //    Console.WriteLine(reader.Value);
                    //    break;
                    //case XmlNodeType.EndElement: //Display the end of the element.
                    //    Console.Write("</" + reader.Name);
                    //    Console.WriteLine(">");
                    //    break;
                }
            }
            OutputMsg("讀取XML完畢");
            reader.Close();
            #endregion

            bool secUpdate = false;
            PathFile = strPath();//車機主程式路徑

            //清除30天前舊的log
            CleanOldLog(PathFile);

            OutputMsg("開始檢查更新");
            int desc;
            while (true)//等待連接網路
            {
                bool IsOK = InternetGetConnectedState(out desc, 0);
                if (IsOK)
                {
                    break;
                }
                retryCon++;
                OutputMsg("等候網路連接，第 " + retryCon.ToString() + " 次失敗，五秒後重新嘗試");
                Thread.Sleep(5000);
            }

            try
            {
                //檢查版本
                dtCarVer = CkFile();//取得車機上版本
                dtCloudVer = dtVersion();//取得雲上系統版本

                if (dtCarVer.Rows.Count > 0)//已有安裝過，進行更新
                {
                    DataTable NewVersion = new DataTable();
                    NewVersion.Columns.Add("PgNa", typeof(string));
                    NewVersion.Columns.Add("Version", typeof(int));
                    for (int i = 0; i < dtCloudVer.Rows.Count; i++)//逐筆比對雲上與車機版本
                    {
                        string FileName = dtCloudVer.Rows[i]["PgNa"] == null ? "" : dtCloudVer.Rows[i]["PgNa"].ToString();//檔案名稱
                        string FileVs = dtCloudVer.Rows[i]["Version"] == null ? "" : dtCloudVer.Rows[i]["Version"].ToString();//版本
                        //版本比對
                        DataView view = new DataView();
                        DataTable dtSelect = new DataTable();
                        view.Table = dtCarVer;
                        view.RowFilter = "PgNa = '" + FileName + "' and Version = '" + FileVs + "'";
                        dtSelect = view.ToTable();
                        if (dtSelect.Rows.Count == 0)
                        {
                            NewVersion.Rows.Add(new object[] { FileName, FileVs });
                        }
                    }
                    if (NewVersion.Rows.Count > 0)//有新版本
                    {
                        secUpdate = boUpData(NewVersion, PathFile);
                    }
                    NewVersion.Dispose();
                }
                else//全新車機
                {
                    secUpdate = boUpData(dtCloudVer, PathFile);
                }

                dtCloudVer.Columns.Remove("PgData");
                dtCloudVer.TableName = "VS";
                dtCloudVer.WriteXml(PathFile + "Version.XML");
                dtCloudVer.Dispose();
                //啟動程式
                OutputMsg("執行車機程式");

                Process instance = new Process();
                instance.StartInfo.FileName = PathFile + "CarSystem.exe";
                instance.StartInfo.Arguments = "";
                instance.StartInfo.UseShellExecute = true;
                instance.StartInfo.CreateNoWindow = true;
                instance.StartInfo.WorkingDirectory = Path.GetDirectoryName(PathFile + "CarSystem.exe");
                instance.Start();
            }
            catch (Exception ex)
            {
                OutputMsg("更新失敗" + ex);
                Console.ReadLine();
            }
            finally
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        /// <summary>
        /// 連線字串
        /// </summary>
        /// <returns></returns>
        static string strCon()
        {
            string Con = string.Empty;
            string DBName = itemlist.Find(a => a.Name == "DC").Value;
            Con = itemlist.Find(a => a.Name == DBName).Value;
            return Con;
        }

        /// <summary>
        /// 存放程式路徑
        /// </summary>
        /// <returns></returns>
        static string strPath()
        {
            string Path = string.Empty;
            Path = itemlist.Find(a => a.Name == "Path").Value;
            return Path;
        }

        /// <summary>
        /// 取得車機版本
        /// </summary>
        static DataTable CkFile()
        {
            DataTable dtVS = new DataTable("VS");
            if (!Directory.Exists(PathFile))
            {
                Directory.CreateDirectory(PathFile);
            }
            else
            {
                string XMLPath = PathFile + "Version.XML";
                if (File.Exists(XMLPath))
                {
                    dtVS.Columns.Add("PgNa");
                    dtVS.Columns.Add("Version");
                    dtVS.ReadXml(XMLPath);
                }
            }
            return dtVS;
        }

        /// <summary>
        /// 取得雲上版本
        /// </summary>
        /// <returns></returns>
        static DataTable dtVersion()
        {
            retryCon = 0;

        ConnectBEGIN:
            DataTable dt = new DataTable();
            SqlConnection SqlConn = new SqlConnection(strCon());
            try
            {
                string Sql_cmd = "Select PgNa,PgData,[Version] From CarSystem.dbo.CarIssue ";
                SqlCommand com = new SqlCommand(Sql_cmd, SqlConn);
                SqlConn.Open();
                SqlDataAdapter dapter = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dapter.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                SqlConn.Close();
                SqlConn.Dispose();
                retryCon++;
                OutputMsg("資料庫連結失敗，第 " + retryCon.ToString() + " 次失敗，5秒後重新連接");
                Thread.Sleep(5000);
                goto ConnectBEGIN;
            }
            finally
            {
                SqlConn.Close();
                SqlConn.Dispose();
            }
            return dt;
        }

        /// <summary>
        /// Bite 轉 File
        /// </summary>
        /// <param name="_FileName">檔案路徑位置與名稱</param>
        /// <param name="_ByteArray">欲轉檔資料</param>
        /// <returns></returns>
        static bool ByteArrayToFile(string _FileName, byte[] _ByteArray)
        {

            // Open file for reading
            FileStream _FileStream = new FileStream(_FileName, FileMode.Create, FileAccess.Write);

            // Writes a block of bytes to this stream using data from
            // a byte array.
            _FileStream.Write(_ByteArray, 0, _ByteArray.Length);

            // close file stream
            _FileStream.Close();

            return true;

        }

        /// <summary>
        /// 下載更新檔
        /// </summary>
        /// <param name="Dt"></param>
        /// <param name="strPath"></param>
        /// <returns></returns>
        static bool boUpData(DataTable Dt, string strPath)
        {
            bool blUpdate = false;
            DataTable dtFile = new DataTable();
            try
            {
                foreach (DataRow dr in Dt.Rows)
                {
                    string FileName = dr["PgNa"].ToString();
                    string PathFile = strPath + FileName;
                    //篩選須異動更新檔案
                    DataView view = new DataView();
                    DataTable dtSelect = new DataTable();
                    view.Table = dtCloudVer;
                    view.RowFilter = "PgNa = '" + FileName + "'";
                    dtFile = view.ToTable();
                    byte[] FileData = (byte[])dtFile.Rows[0]["PgData"];//取得異動更新檔案
                    blUpdate = ByteArrayToFile(PathFile, FileData);
                    OutputMsg("更新 " + FileName);
                }
            }
            catch
            {
                blUpdate = false;
            }
            return blUpdate;
        }

        /// <summary>
        /// 清除30天前舊的log
        /// </summary>
        static void CleanOldLog(string PathFile)
        {
            string[] filePaths = Directory.GetFiles(PathFile + @"\RecLog");
            foreach (string filePath in filePaths)
            {
                DateTime creationTime = File.GetCreationTime(filePath);
                if (creationTime <= DateTime.Now.AddDays(-30))
                {
                    Console.WriteLine(filePath + " " + creationTime.ToString());
                    File.Delete(filePath);
                }
            }
            OutputMsg("清除30天前的紀錄");
        }

        /// <summary>
        /// 輸出文字
        /// </summary>
        /// <param name="Msg"></param>
        static void OutputMsg(string Msg)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "  " + Msg);
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Item(string _Name, string _Value)
        {
            Name = _Name;
            Value = _Value;
        }
    }
}
