using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace CarSystem
{
    public partial class Form9_2 : Car_Fun.CarSystem_Sample_Form
    {
        public Form9_2()
        {
            InitializeComponent();
        }

        protected override void New_WSC_DLL_Form_Load(object sender, EventArgs e)
        {
            Login_Server = UserInf.DBName;
            base.New_WSC_DLL_Form_Load(sender, e);
            SetMasterBindingNavigator(null);
            SetButtonEnable("L");
            dtp_Bdate.Value = DateTime.Now.AddDays(-30);

            btn_Search.PerformClick();
        }

        /// <summary>
        /// 帶出操作紀錄
        /// </summary>
        private void BringDetail()
        {
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Mode", 0);
            ht1.Add("@UserId", UserInf.UserID);
            ht1.Add("@Bdate", dtp_Bdate.Text);
            ht1.Add("@Edate", dtp_Edate.Text);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_9_2", ht1, ref OutValue_finish);
            DataTable dt_Query = DS_Query.Tables[0];
            dgv_Log.AutoGenerateColumns = false;
            dgv_Log.DataSource = dt_Query;

            //VScrollBar設定
            vSB_SelectWorkArea_Out.Maximum = dt_Query.Rows.Count;
            vSB_SelectWorkArea_Out.Scroll += new ScrollEventHandler(vSB_SelectWorkArea_Out_Scroll);
        }
        void vSB_SelectWorkArea_Out_Scroll(object sender, ScrollEventArgs e)
        {
            dgv_Log.FirstDisplayedScrollingRowIndex = vSB_SelectWorkArea_Out.Value;
        }
        /// <summary>
        /// 帶出操作紀錄總和
        /// </summary>
        private void BringDetailSUM()
        {
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Mode", 1);
            ht1.Add("@UserId", UserInf.UserID);
            ht1.Add("@Bdate", dtp_Bdate.Text);
            ht1.Add("@Edate", dtp_Edate.Text);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_9_2", ht1, ref OutValue_finish);
            DataTable dt_Query = DS_Query.Tables[0];
            dgv_LogSUM.AutoGenerateColumns = false;
            dgv_LogSUM.DataSource = dt_Query;
       }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            BringDetail();
            BringDetailSUM();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
