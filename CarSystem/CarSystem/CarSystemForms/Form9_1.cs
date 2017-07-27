using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace CarSystem
{
    public partial class Form9_1 : Car_Fun.CarSystem_Sample_Form
    {
        public Form9_1()
        {
            InitializeComponent();
        }

        protected override void New_WSC_DLL_Form_Load(object sender, EventArgs e)
        {
            Login_Server = UserInf.DBName;
            base.New_WSC_DLL_Form_Load(sender, e);
            SetMasterBindingNavigator(null);
            SetButtonEnable("PL");

            btn_Item.Click += btn_Item_Click;
            btn_Slod.Click += btn_Slod_Click;
            txS_merd_id.Click += Click_Show_frmKeyboardNumber;
            txS_Slod_Id.Click += Click_Show_frmKeyboardEngNumber;
        }

        #region 選擇模式頁面
        private void btn_Item_Click(object sender, EventArgs e)
        {
            Lbl_Item_SuccessMessage.Text = "請刷入貨號/ITF";
            tabControl1.SelectedIndex = 1;
        }

        private void btn_Slod_Click(object sender, EventArgs e)
        {
            Lbl_Slod_SuccessMsg.Text = "請刷入儲位編號";
            tabControl1.SelectedIndex = 2;
        }

        //Map按下返回上一頁
        protected override void PreviousButton_Click(object sender, EventArgs e)
        {
            txS_merd_id.Text = "";
            txS_Slod_Id.Text = "";
            tabControl1.SelectedIndex = 0;
        }
        #endregion

        #region 商品查詢頁面
        DataTable dtMerdId = new DataTable();
        //驗證貨號查詢
        private void txS_merd_id_Validated(object sender, EventArgs e)
        {
            //log開始
            reclog.ExLog("91", "Sta,查詢貨號," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_merd_id.Text);
            string ErrMsg = "";
            if (txS_merd_id.Text == "")
            {
                ErrMsg = "找不到資料，請重新輸入貨號/ITF";
            }
            else
            {
                Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
                ht1.Add("@Type", 0);
                ht1.Add("@item", txS_merd_id.Text);
                DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_9_1", ht1, ref OutValue_finish);
                dtMerdId = DS_Query.Tables[0];

                //20140314 Kota 寫入log
                SqlCarOperateLog(txS_merd_id.Text, "S1", 0, 0);


                if (dtMerdId.Rows.Count > 0)
                {
                    DGV_Item.DataSource = dtMerdId;
                    DGV_Item.FirstDisplayedScrollingRowIndex = 0;
                    DGV_Item.FirstDisplayedScrollingColumnIndex = 0;
                    VSB_Item.Value = 0;

                    rtxN_merd_name.Text = dtMerdId.Rows[0]["N_merd_Name"].ToString();

                    //VScrollBar設定
                    int MaxRowsInWindow = 6;

                    VSB_Item.Maximum = dtMerdId.Rows.Count + MaxRowsInWindow;
                    VSB_Item.Scroll += new ScrollEventHandler(vSB_Item_Scroll);
                }
                else
                {
                    ErrMsg = "找不到資料，請重新輸入貨號/ITF";
                }
            }

            if (ErrMsg != "")
            {
                Lbl_Item_SuccessMessage.Text = ErrMsg;
                rtxN_merd_name.Text = "";
                if (DGV_Item.DataSource != null)
                    ((DataTable)DGV_Item.DataSource).Clear();
            }
            else
                Lbl_Item_SuccessMessage.Text = "請刷入貨號/ITF";

            txS_merd_id.SelectAll();
            txS_merd_id.Focus();

            //log結束
            reclog.ExLog("91", "End,查詢貨號," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_merd_id.Text);

        }
        void vSB_Item_Scroll(object sender, ScrollEventArgs e)
        {
            if (VSB_Item.Value <= dtMerdId.Rows.Count - 1)
                DGV_Item.FirstDisplayedScrollingRowIndex = VSB_Item.Value;
            else
                DGV_Item.FirstDisplayedScrollingRowIndex = dtMerdId.Rows.Count - 5;
        }
        #endregion

        #region 儲位查詢畫面
        DataTable dtSlodID = new DataTable();
        private void Txb_SlodId_Validated(object sender, EventArgs e)
        {
            //log開始
            reclog.ExLog("91", "Sta,查詢儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_Slod_Id.Text);

            string ErrMsg = "";
            if (txS_Slod_Id.Text == "")
            {
                ErrMsg = "找不到資料，請重新輸入貨號/ITF";
            }
            else
            {
                Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
                ht1.Add("@Type", 1);
                ht1.Add("@item", txS_Slod_Id.Text);
                DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_9_1", ht1, ref OutValue_finish);
                dtSlodID = DS_Query.Tables[0];

                //20140314 Kota 寫入log
                SqlCarOperateLog(txS_Slod_Id.Text, "S2", 0, 0);

                if (dtSlodID.Rows.Count > 0)
                {
                    DGV_Slod.DataSource = dtSlodID;
                    DGV_Slod.FirstDisplayedScrollingRowIndex = 0;
                    DGV_Slod.FirstDisplayedScrollingColumnIndex = 0;
                    VSB_Slod.Value = 0;
                    HSB_Slod.Value = 0;

                    //VScrollBar設定
                    int MaxRowsInWindow = 5;

                    VSB_Slod.Maximum = dtSlodID.Rows.Count + MaxRowsInWindow;
                    VSB_Slod.Scroll += new ScrollEventHandler(vSB_Slod_Scroll);

                    //HScrollBar設定
                    HSB_Slod.Maximum = dtSlodID.Columns.Count + 5;
                    HSB_Slod.Scroll += new ScrollEventHandler(HSB_Slod_Scroll);
                }
                else
                {
                    ErrMsg = "找不到資料，請重新輸入儲位編號";
                }
            }

            if (ErrMsg != "")
            {
                Lbl_Slod_SuccessMsg.Text = ErrMsg;
                if (DGV_Slod.DataSource != null)
                    ((DataTable)DGV_Slod.DataSource).Clear();
            }
            else
                Lbl_Slod_SuccessMsg.Text = "請刷入儲位編號";

            txS_Slod_Id.SelectAll();
            txS_Slod_Id.Focus();

            //log結束
            reclog.ExLog("91", "End,查詢儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_Slod_Id.Text);

        }
        void vSB_Slod_Scroll(object sender, ScrollEventArgs e)
        {
            if (VSB_Slod.Value <= dtSlodID.Rows.Count - 1)
                DGV_Slod.FirstDisplayedScrollingRowIndex = VSB_Slod.Value;
            else
                DGV_Slod.FirstDisplayedScrollingRowIndex = dtSlodID.Rows.Count;
        }
        void HSB_Slod_Scroll(object sender, ScrollEventArgs e)
        {
            if (HSB_Slod.Value <= dtSlodID.Columns.Count - 1)
                DGV_Slod.FirstDisplayedScrollingColumnIndex = HSB_Slod.Value;
            else
                DGV_Slod.FirstDisplayedScrollingColumnIndex = dtSlodID.Columns.Count;
        }
        #endregion
    }
}
