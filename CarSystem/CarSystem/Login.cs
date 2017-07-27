using System;
using System.ComponentModel;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Car_Fun;
using Car_IO;
using System.Reflection;
using System.IO;
using System.Text;

namespace CarSystem
{
    public partial class Login : CarSystem_Sample_Form
    {
        public F_Msg MegBox = new F_Msg();
        public static Login frmLogin;
        string DBName = string.Empty;
        public Login()
        {
            InitializeComponent();
            frmLogin = this;
            Closing += new CancelEventHandler(Login_Closing);

            #region 隱藏Windows工具列
            APPBARDATA abd = new APPBARDATA();

            abd.lParam = 3;
            SHAppBarMessage(ABM_SETSTATE, ref abd);
            #endregion
        }

        protected override void New_WSC_DLL_Form_Load(object sender, EventArgs e)
        {
            base.New_WSC_DLL_Form_Load(sender, e);

            lbl_Location.Text = ConfigurationManager.AppSettings["DC"];

            //全螢幕
            this.WindowState = FormWindowState.Maximized;

            //按鈕加上小鍵盤
            txb_UserId.Click += Click_Show_frmKeyboardNumber;
            txb_UserPsw.Click += Click_Show_frmKeyboardEngNumber;

            //關機按鈕位置
            Screen myScreen = Screen.PrimaryScreen;
            int screenHeight = Convert.ToInt32(myScreen.WorkingArea.Height - btn_Power.Height);
            btn_Power.Location = new Point(0, screenHeight);

            //離開按鈕
            lbl_Exit.Location = new Point(btn_Power.Width + 20, screenHeight);

            //版本號
            Lbl_FileVersion.Text = "版本：" + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();

            //更新Log
            StreamReader sr = new StreamReader("CarSystemModifyLog.txt", Encoding.GetEncoding("utf-8"));
            rTB_ModifyLog.Text = sr.ReadToEnd();
            rTB_ModifyLog.Height += lbl_Exit.Height;
            sr.Close();
        }
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            Log();
        }

        /// <summary>
        /// 離開
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeaveThisForm(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 查詢帳號
        /// </summary>
        /// <param name="UserID">工號</param>
        /// <param name="Psw">密碼</param>
        private DataTable QueryEmp(string UserID, string Psw, string DBName)
        {
            IO_DB IO = new IO_DB();
            F_Check ck = new F_Check();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            long lonPsw = ck.PasswdValue(Psw);
            string SqlCom = @"Select S_empd_id,N_empd_name,S_empd_autgid 
                               From dbo.employee_data 
                               Where S_empd_id=@S_empd_id 
                               And L_empd_psword=@L_empd_psword";

            Hashtable hs = new Hashtable();
            hs.Add("@S_empd_id", UserID);
            hs.Add("@L_empd_psword", lonPsw);

            ds = IO.SqlQuery(DBName, SqlCom, hs);
            dt = ds.Tables[0];
            return dt;
        }

        /// <summary>
        /// 設定帳號資料
        /// </summary>
        /// <param name="dt"></param>
        private void setUser(DataTable dt)
        {
            string UserID = dt.Rows[0]["S_empd_id"] == null ? string.Empty : dt.Rows[0]["S_empd_id"].ToString();
            string UserName = dt.Rows[0]["N_empd_name"] == null ? string.Empty : dt.Rows[0]["N_empd_name"].ToString();
            string Admin = dt.Rows[0]["S_empd_autgid"] == null ? string.Empty : dt.Rows[0]["S_empd_autgid"].ToString();
            // string UserIp = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
            //IPAddress[] addr = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            string UserIp = string.Empty;
            foreach (IPAddress addr in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    UserIp = addr.ToString();
                }
            }

            DateTime time = DateTime.Now;
            UserInf.UserID = UserID;
            UserInf.UserName = UserName;
            UserInf.Autgid = Admin;
            UserInf.IP = UserIp;
            UserInf.LogDate = time;
            UserInf.DBName = DBName;
            UserInf.ComputerName = Environment.GetEnvironmentVariable("COMPUTERNAME");
        }

        /// <summary>
        /// 關閉視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //DialogResult dr = MessageBox.Show(this, "確定退出？", "退出視窗通知", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
            #region 顯示Windows工具列
            APPBARDATA abd = new APPBARDATA();

            abd.lParam = 2;
            SHAppBarMessage(ABM_SETSTATE, ref abd);
            #endregion
        }

        private void txb_UserPsw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Log();
            }
        }

        private void Log()
        {
            string UserID = txb_UserId.Text.Trim();
            string Psw = txb_UserPsw.Text.Trim();
            DBName = ConfigurationManager.AppSettings["DC"];
            string str_Msg = string.Empty;
            if (string.IsNullOrEmpty(UserID))
            {
                str_Msg = "請輸入帳號!!\n";
            }
            if (string.IsNullOrEmpty(Psw))
            {
                str_Msg += "請輸入密碼!!";
            }
            if (str_Msg.Length > 0)
            {
                DisableAllKeyboard();
                MegBox.messageshow(str_Msg);
                return;
            }
            DataTable dtUser = QueryEmp(UserID, Psw, DBName);
            if (dtUser.Rows.Count > 0)
            {
                setUser(dtUser);
                txb_UserId.Text = string.Empty;
                txb_UserPsw.Text = string.Empty;
                MainForm form2 = new MainForm();
                form2.Show();
                this.Hide();
            }
            else
            {
                DisableAllKeyboard();
                MegBox.messageshow("帳號/密碼錯誤!!!\n請重新確認!!");
                txb_UserId.Text = string.Empty;
                txb_UserPsw.Text = string.Empty;
            }
        }

        /// <summary>
        /// 關機按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Power_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 0");
        }
    }
}