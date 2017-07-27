using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CarSysUpLoad
{
    public partial class CarLoadForm : Form
    {
        private ArrayList arrFileName = new ArrayList(); //檔名
        private ArrayList arrfilePath = new ArrayList();//路徑

        /// <summary>
        /// 連線字串
        /// </summary>
        /// <param name="DB"></param>
        /// <returns></returns>
        private string ConSql(string DB)
        {
            string strConn = string.Empty;
            strConn = ConfigurationManager.AppSettings[DB];
            return strConn;
        }

        public CarLoadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 點選加入上傳清單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Multiselect = true;
                Open.ShowDialog();
                foreach (string strFileName in Open.FileNames)
                {
                    String path = strFileName;
                    string[] strName = path.Split('\\');
                    string Name = strName[strName.Length - 1].ToString();
                    UpLoadList(Name, path);//加入上傳清單
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系統出錯，請洽相關人員!!!");
            }
        }

        /// <summary>
        /// 拖曳取得路徑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_UploadList_DragEnter(object sender, DragEventArgs e)
        {
            // 確定使用者抓進來的是檔案
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                // 允許拖拉動作繼續 (這時滑鼠游標應該會顯示 +)
                e.Effect = DragDropEffects.All;
            }
        }

        /// <summary>
        /// 拖曳執行加入上傳清單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_UploadList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string path = file;
                string[] strName = path.Split('\\');
                string Name = strName[strName.Length - 1].ToString();
                UpLoadList(Name, path);
            }
        }

        /// <summary>
        /// 刪除上傳清單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Dle_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveUpList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("系統出錯，請洽相關人員!!!");
            }
        }

        /// <summary>
        /// 按右鍵刪除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmi_Del_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveUpList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("系統出錯，請洽相關人員!!!");
            }
        }

        /// <summary>
        /// 判別是否按右鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_UploadList_MouseDown(object sender, MouseEventArgs e)
        {
            int ItemCount = 0;
            if (e.Button == MouseButtons.Right)
            {
                ItemCount = lbx_UploadList.SelectedItems.Count;
                if (ItemCount > 0)//判別有無點選資料
                {
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        /// <summary>
        /// 執行上傳檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            int SelectFile = arrFileName.Count;
            int DCCount = 0;
            string Msg = string.Empty;
            bool blUpLoad = false;
            try
            {
                if (SelectFile == 0)//判別上傳清單
                {
                    MessageBox.Show("請加入上傳清單!!!");
                    return;
                }
                foreach (Control Ctl in gb_DC.Controls)//取得控制項內的控制項
                {
                    if (Ctl is CheckBox)//取得倉別
                    {
                        CheckBox ckb = (CheckBox)Ctl;
                        if (ckb.Checked)
                        {
                            DCCount++;
                            string DBName = ckb.Tag.ToString();
                            for (int i = 0; i < SelectFile; i++)//逐筆上傳檔案
                            {
                                string Name = arrFileName[i].ToString();
                                string FileData = arrfilePath[i].ToString();
                                try
                                {
                                    byte[] buffer = File.ReadAllBytes(FileData);//把檔案轉成byte[] 
                                    DateTime timeUpLDate = DateTime.Now;
                                    blUpLoad = UplodeDB(Name, buffer, DBName, timeUpLDate);
                                    if (!blUpLoad)
                                    {
                                        Msg += "檔案: " + Name + "  上傳失敗\r\n";
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Msg += "檔案: " + Name + "  上傳失敗\r\n";
                                }
                            }
                            if (Msg.Length == 0)
                            {
                                Msg = " 檔案上傳完成!!\r\n";
                            }
                        }
                    }
                }
                if (DCCount == 0)
                {
                    MessageBox.Show("請選擇倉別!!");
                    return;
                }
                CleanItem();
                MessageBox.Show(Msg);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("系統出錯，請洽相關人員!!!");
            }
        }

        /// <summary>
        /// 加入上傳清單
        /// </summary>
        /// <param name="Name">檔名</param>
        /// <param name="path">路徑</param>
        private void UpLoadList(string Name, string path)
        {
            if (!arrfilePath.Contains(path))//以路徑判別檔案是否重複
            {
                arrFileName.Add(Name);
                arrfilePath.Add(path);
                lbx_UploadList.Items.Add(Name);
            }
        }

        /// <summary>
        /// 移除上傳清單
        /// </summary>
        private void RemoveUpList()
        {
            int SelItemCount = lbx_UploadList.SelectedItems.Count;
            if (SelItemCount == 0)
            {
                MessageBox.Show("請選擇欲刪除資料!!");
                return;
            }
            else
            {
                for (int i = 0; i < SelItemCount; i++)
                {
                    string FileName = lbx_UploadList.SelectedItem.ToString();
                    int RmIndex = lbx_UploadList.Items.IndexOf(FileName);
                    arrFileName.RemoveAt(RmIndex);
                    arrfilePath.RemoveAt(RmIndex);
                    lbx_UploadList.Items.RemoveAt(RmIndex);
                }
            }
        }
        
        /// <summary>
        /// 上傳資料至DB
        /// </summary>
        /// <param name="FileName">檔案名稱</param>
        /// <param name="FileData">上傳檔案</param>
        /// <param name="DBName">資料庫名稱</param>
        /// <param name="CrtDate">產生日期</param>
        /// <returns></returns>
        private bool UplodeDB(string FileName, byte[] FileData, string DBName, DateTime CrtDate)
        {
            DataTable dtVs = new DataTable();
            bool blUpLoad = false;
            dtVs = dtCkVs(DBName, FileName);//檢核有無舊有程式
            if (dtVs.Rows.Count == 0)//新程式
            {
                blUpLoad = NewPrg(DBName, FileName, FileData, CrtDate);
            }
            else//既有程式，更新版本
            {
                blUpLoad = UpPrg(DBName, FileName, FileData, CrtDate);
            }
            return blUpLoad;
        }

        /// <summary>
        /// 檢核有無舊有程式
        /// </summary>
        /// <param name="DBName"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        private DataTable dtCkVs(string DBName, string FileName)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string strCon = ConSql(DBName);
            SqlConnection SqlConn = new SqlConnection(strCon);
            try
            {
                string SqlCmd = "Select Version from CarIssue where PgNa=@PgNa";
                SqlCommand Cmd = new SqlCommand(SqlCmd, SqlConn);
                SqlParameter pPgNa= new SqlParameter("@PgNa", SqlDbType.NVarChar);
                pPgNa.Value = FileName;
                Cmd.Parameters.Add(pPgNa);
                SqlConn.Open();
                SqlDataAdapter dapter = new SqlDataAdapter(Cmd);
                dapter.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
            }
            finally 
            {
                SqlConn.Close();
                SqlConn.Dispose();
            }
            return dt;
        }

        /// <summary>
        ///  新增程式
        /// </summary>
        /// <param name="DBName">資料庫名稱</param>
        /// <param name="FileName">檔名</param>
        /// <param name="FileData">檔案資料</param>
        /// <param name="CrtDate">上傳日期</param>
        /// <returns></returns>
        private bool NewPrg(string DBName, string FileName, byte[] FileData, DateTime CrtDate)
        {
            bool blNewPrg = false;
            string strCon = ConSql(DBName);
            SqlConnection SqlConn = new SqlConnection(strCon);
            try 
            {
                string SqlCmd = "Insert Into CarIssue(PgNa,PgData,Version,UploadDate,CrtDate) Values(@PgNa,@PgData,'1',@UploadDate,@CrtDate)";
                SqlCommand Cmd = new SqlCommand(SqlCmd, SqlConn);
                SqlParameter pFileName = new SqlParameter("@PgNa", SqlDbType.NVarChar);
                pFileName.Value = FileName;
                Cmd.Parameters.Add(pFileName);
                SqlParameter pPgData = new SqlParameter("@PgData", SqlDbType.VarBinary);
                pPgData.Value = FileData;
                Cmd.Parameters.Add(pPgData);
                SqlParameter pUploadDate = new SqlParameter("@UploadDate", SqlDbType.DateTime);
                pUploadDate.Value = CrtDate;
                Cmd.Parameters.Add(pUploadDate);
                SqlParameter pCrtDate = new SqlParameter("@CrtDate", SqlDbType.DateTime);
                pCrtDate.Value = CrtDate;
                Cmd.Parameters.Add(pCrtDate);
                SqlConn.Open();
                Cmd.ExecuteNonQuery();
                blNewPrg = true;
            }
            catch (Exception ex)
            {
                blNewPrg = false;
            }
            finally 
            {
                SqlConn.Close();
                SqlConn.Dispose();
            }
            return blNewPrg;
        }

        /// <summary>
        /// 更新版本
        /// </summary>
        /// <param name="DBName">資料庫名稱</param>
        /// <param name="FileName">檔名</param>
        /// <param name="FileData">檔案資料</param>
        /// <param name="CrtDate">更新日期</param>
        /// <returns></returns>
        private bool UpPrg(string DBName, string FileName, byte[] FileData, DateTime CrtDate)
        {
            bool blUpPrg = false;
            string strCon = ConSql(DBName);
            SqlConnection SqlConn = new SqlConnection(strCon);
            try
            {
                string SqlCmd = @"Update CarIssue Set PgData=@PgData , UploadDate=@UploadDate,[Version]=[Version]+1 
                                Where PgNa=@PgNa ";
                SqlCommand Cmd = new SqlCommand(SqlCmd, SqlConn);
                SqlParameter pFileName = new SqlParameter("@PgNa", SqlDbType.NVarChar);
                pFileName.Value = FileName;
                Cmd.Parameters.Add(pFileName);
                SqlParameter pUploadDate = new SqlParameter("@UploadDate", SqlDbType.DateTime);
                pUploadDate.Value = CrtDate;
                Cmd.Parameters.Add(pUploadDate);
                SqlParameter pPgData = new SqlParameter("@PgData", SqlDbType.VarBinary);
                pPgData.Value = FileData;
                Cmd.Parameters.Add(pPgData);
                SqlConn.Open();
                Cmd.ExecuteNonQuery();
                blUpPrg = true;
            }
            catch (Exception ex)
            {
                blUpPrg = false;
            }
            finally 
            {
                SqlConn.Close();
                SqlConn.Dispose();
            }
            return blUpPrg;
        }

        /// <summary>
        /// 清除項目
        /// </summary>
        private void CleanItem()
        {
            lbx_UploadList.Items.Clear();
            arrFileName.Clear();
            arrfilePath.Clear();
            foreach (Control Ctl in gb_DC.Controls)
            {
                if (Ctl is CheckBox)
                {
                    CheckBox ckb = (CheckBox)Ctl;
                    ckb.Checked = false;
                }
            }
        }
    }
}
