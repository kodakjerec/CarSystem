using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Car_IO;
using Car_Fun;
using System.Collections;

namespace CarSystem
{
    public partial class MainForm : CarSystem_Sample_Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 離開主選單跳出視窗
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            bool LeaveCheck = fMsg.messageshow("確定登出系統？", "登出視窗通知",true);
            if (LeaveCheck==false)
            {
                e.Cancel = true;
            }
            else
            {
                SqlCarOperateLog(UserInf.UserID, "L", 0 ,0);
                Login.frmLogin.Show();
            }
        }

        #region Button_Click!

        private void btn_Leave_Click(object sender, EventArgs e)
        {
            this.Close();
           // Login.frmLogin.Show();
        }

        protected object FormLoadSample;    //Form的通用物件型態
        protected virtual void Button_Click(object sender, EventArgs e)
        {
            String frmName = "Form" + ((Button)sender).Name.Trim().Substring(4, 3);
            String className = "CarSystem." + frmName;
            Type myType = Type.GetType(className);

            if (myType == null) //Form尚未做好或不存在
            {
                fMsg.messageshow("很抱歉，" + frmName + "尚在製作中。", "未開放功能");
                return;
            }
            //啟動指定名稱的Form
            FormLoadSample = Activator.CreateInstance(myType);
            ((Form)FormLoadSample).Closed += new EventHandler(FormDispose);
            ((Form)FormLoadSample).ShowDialog();
        }

        #endregion   

        #region FormDispose
        /// <summary>
        /// 顯示/隱藏主選單的按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDispose(object sender, System.EventArgs e)
        {
            MainButton_Visible(true);
        }

        private void MainButton_Visible(bool Visible_Status)
        {
            foreach (Control button in this.Controls)
            {
                if (button is Button && button.Enabled==true)
                    button.Visible = Visible_Status;
            }
            if (Visible_Status)
                this.Show();
            else
                this.Hide();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlCarOperateLog(UserInf.UserID, "I", 0, 0);
            foreach (Control con in this.Controls)
            {
                string tbName = con.GetType().Name.ToString();
                if (tbName == "Button" || tbName=="MyButton")
                {
                    if (con.Name.ToString() == "btn_Leave")
                    {
                        con.Click += btn_Leave_Click;
                    }
                    else
                    {
                        con.Click += Button_Click;
                    }
                }
            }

            ShowOperationLog();

            //關機按鈕位置
            Screen myScreen = Screen.PrimaryScreen;
            int screenHeight = Convert.ToInt32(myScreen.WorkingArea.Height - btn_Leave.Height);
            btn_Leave.Location = new Point(0, screenHeight);
        }

        /// <summary>
        /// 更改操作log
        /// </summary>
        private void ShowOperationLog()
        {
            string Bdate=DateTime.Now.AddDays(-30).ToString("yyyy/MM/dd");
            string Edate=DateTime.Now.ToString("yyyy/MM/dd");
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Mode", 1);
            ht1.Add("@UserId", UserInf.UserID);
            ht1.Add("@Bdate", Bdate);
            ht1.Add("@Edate", Edate);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_9_2", ht1, ref OutValue_finish);
            DataTable dt_Query = DS_Query.Tables[0];

            lbl_OperationLog.Text = "[日期]：" + Bdate+ " ~ "+Edate+"  ";
            foreach (DataRow dr in dt_Query.Rows)
            {
                lbl_OperationLog.Text += "["+dr["ProjectName"].ToString() + "]：" + dr["Tcount"].ToString() + "    ";
            }
        }
    }
}
