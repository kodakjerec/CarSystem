using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CarSystem
{
    public partial class Form6_2 : Car_Fun.CarSystem_Sample_Form
    {
        #region 全域變數
        int SelectMode = 0;         //選擇的補貨模式
        string ReturnMetrHeadId = "";//回傳的調整單號
        int NowSeq = 0;             //補貨單據目前的Index

        DataTable dt_OrderNo    //補貨單據列表
            , dt_WorkContent    //補貨單據下的所有內容
            , dt_PickOtherContent              //其他儲位
            , dt_Return;        //回庫作業的dgv
        List<DataRow> lt_PickOther_NotSelect=new List<DataRow>();   //其他儲位_未選擇

        bool Flag_OutSlodCheck = false;             //移出儲位檢查
        bool Flag_checkEnterCummitStatus = false;   //進行到確認階段, 不能隨便離開
        #endregion

        public Form6_2()
        {
            InitializeComponent();
        }

        void Form6_2_v2_Load(object sender, EventArgs e)
        {
            Login_Server = UserInf.DBName;
            base.New_WSC_DLL_Form_Load(sender, e);
            SetMasterBindingNavigator(null);
            SetButtonEnable("O P L");

            bindingNavigatorOKButton.Enabled = false;
        }

        #region 工具列
        //按下確認
        protected override void OKButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                btnConfirm_Click();
            else if (tabControl1.SelectedIndex == 3)
                btnConfirm_Return_Click();
        }

        //Map按下返回上一頁
        protected override void PreviousButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex >= 2)
                LockRelease("repl_head", lbl_OrderNo.Text.Trim());

            if (tabControl1.SelectedIndex > 0)
                tabControl1.SelectedIndex -= 1;
        }

        //離開系統
        protected override void LeaveButton_Click(object sender, EventArgs e)
        {
            if (Flag_checkEnterCummitStatus == true)
            {
                bool IsOK = AlarmUserNotFinish(1);
                if (IsOK == false)
                {
                    return;
                }
            }
            LockRelease("repl_head", lbl_OrderNo.Text.Trim());
            base.LeaveButton_Click(sender, e);
        }
        /// <summary>
        /// 警告使用者要按下確認，完成一次作業
        /// </summary>
        bool AlarmUserNotFinish(int type)
        {
            bool ISOK = false;
            if (type == 0)
                fMsg.messageshow("上架作業尚未確認完畢");
            if (type == 1)
                ISOK = fMsg.messageshow("補貨作業尚未完畢\n\"否\"回到作業", "補貨作業中斷", true);
            return ISOK;
        }
        #endregion

        #region 選擇單據類別

        //一般補貨
        void btn_Seltype_Normal_Click(object sender, EventArgs e)
        {
            SelectMode = 1;
            if (GetContent_DGV_OrderNo() <= 0)
            {
                fMsg.messageshow("無作業單據");
                return;
            }
        }

        //截單補貨
        void btn_Seltype_Cute_Click(object sender, EventArgs e)
        {
            SelectMode = 2;
            if (GetContent_DGV_OrderNo() <= 0)
            {
                fMsg.messageshow("無作業單據");
                return;
            }
        }

        //帶出補貨類別的所有單據
        int GetContent_DGV_OrderNo()
        {
            int Count = 0;

            switch (SelectMode)
            {
                case 1:
                    lbl_Mode.Text = "一般";
                    lbl_Mode2.Text = lbl_Mode.Text;
                    break;
                case 2:
                    lbl_Mode.Text = "截單";
                    lbl_Mode2.Text = lbl_Mode.Text;
                    break;
            }

            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Seq", 0);
            ht1.Add("@L_reph_id", SelectMode);
            ht1.Add("@S_outslodid ", SelectMode);
            ht1.Add("@UserID", UserInf.UserID);
            ht1.Add("@ComputerName", UserInf.ComputerName);
            ht1.Add("@FormName", strLockFormName);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_6_2", ht1, ref OutValue_finish);
            Count = DS_Query.Tables[0].Rows.Count;
            if (Count > 0)
            {
                dt_OrderNo = DS_Query.Tables[0];
                DGV_OrderNo.DataSource = dt_OrderNo;
                DGV_OrderNo.FirstDisplayedScrollingRowIndex = 0;
                DGV_OrderNo.FirstDisplayedScrollingColumnIndex = 0;
                vSB_OrderNo.Value = 0;


                //VScrollBar設定
                int MaxRowsInWindow = 6;
                if (dt_OrderNo.Rows.Count > MaxRowsInWindow)
                    vSB_OrderNo.Visible = true;
                else
                    vSB_OrderNo.Visible = false;
                vSB_OrderNo.Maximum = dt_OrderNo.Rows.Count + MaxRowsInWindow;
                vSB_OrderNo.Scroll += new ScrollEventHandler(vSB_OrderNo_Scroll);

                tabControl1.SelectedIndex++;
            }
            return Count;
        }
        void vSB_OrderNo_Scroll(object sender, ScrollEventArgs e)
        {
            if (vSB_OrderNo.Value <= dt_OrderNo.Rows.Count - 1)
                DGV_OrderNo.FirstDisplayedScrollingRowIndex = vSB_OrderNo.Value;
            else
                DGV_OrderNo.FirstDisplayedScrollingRowIndex = dt_OrderNo.Rows.Count - 5;
        }
        #endregion

        #region 選擇補貨單號
        /// <summary>
        /// 選定補貨單號
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DGV_OrderNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //沒選到返回
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = DGV_OrderNo.Rows[e.RowIndex];

            if (GetContent_WorkContent(row) == true)
            {
                tabControl1.SelectedIndex += 1;
                txS_recs_slodidNew.Focus();
            }
        }

        /// <summary>
        /// 帶出補貨單號的內容
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        bool GetContent_WorkContent(DataGridViewRow row)
        {
            bool IsOK = false;
            int Count = 0;

            lbl_OrderNo.Text = row.Cells["col_dgvOrderNo_OrderNo"].Value.ToString();

            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Seq", 1);
            ht1.Add("@L_reph_id", lbl_OrderNo.Text);
            ht1.Add("@S_outslodid ", "");
            ht1.Add("@UserID", UserInf.UserID);
            ht1.Add("@ComputerName", UserInf.ComputerName);
            ht1.Add("@FormName", strLockFormName);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_6_2", ht1, ref OutValue_finish);
            Count = DS_Query.Tables[0].Rows.Count;
            if (Count > 0)
            {
                if (LockRequest("repl_head", lbl_OrderNo.Text) == false)
                {
                    fMsg.messageshow(strLockRequestString);
                }
                else
                {
                    NowSeq = -1;
                    dt_WorkContent = DS_Query.Tables[0];
                    GetContent_WorkContent_checkNext();
                    IsOK = true;
                    Flag_checkEnterCummitStatus = true;
                }
            }
            else
            {
                fMsg.messageshow("單據作業完畢，請選擇其他單據");
            }

            return IsOK;
        }

        /// <summary>
        /// 檢查補貨單據是否有其他資料
        /// </summary>
        /// <returns></returns>
        bool GetContent_WorkContent_checkNext()
        {
            NowSeq++;
            if (NowSeq > dt_WorkContent.Rows.Count - 1)
            {
                return false;
            }
            else
            {
                BringContent_WorkContent(NowSeq);
            }

            return true;
        }

        /// <summary>
        /// 帶出指定筆數的補貨內容
        /// </summary>
        /// <param name="RowIndex"></param>
        void BringContent_WorkContent(int RowIndex)
        {
            DataRow dr = dt_WorkContent.Rows[RowIndex];
            txS_recs_slodid.Text = dr["S_repi_outslodid"].ToString();
            txS_recs_slodidNew.Text = "";
            txS_merp_barcode.Text = dr["S_merp_barcode"].ToString();
            txb_S_merd_id.Text = dr["S_merd_id"].ToString();
            txN_merd_name.Text = dr["N_merd_name"].ToString();
            txL_recs_takenum.Text = dr["S_capi_qty"].ToString();
            txb_Inslodid.Text = dr["S_slod_id"].ToString();
            lbl_L_repi_sysno.Text = dr["L_repi_sysno"].ToString();
            lbl_L_repi_replqty.Text = dr["L_repi_replqty"].ToString();

            BringContent_Other(txS_recs_slodid.Text);
        }

        /// <summary>
        /// 帶出同樣的移出儲位, 不同中型料架/輕型料架/流利架的資訊
        /// </summary>
        /// <param name="OutSlodid"></param>
        void BringContent_Other(string OutSlodid)
        {
            int Count = 0;

            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Seq", 2);
            ht1.Add("@L_reph_id", lbl_OrderNo.Text);
            ht1.Add("@S_outslodid ", OutSlodid);
            ht1.Add("@UserID", UserInf.UserID);
            ht1.Add("@ComputerName", UserInf.ComputerName);
            ht1.Add("@FormName", strLockFormName);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_6_2", ht1, ref OutValue_finish);
            Count = DS_Query.Tables[0].Rows.Count;
            if (Count > 0)
            {
                dt_PickOtherContent = DS_Query.Tables[0];
                DGV_PickOther.DataSource = dt_PickOtherContent;
                DGV_PickOther.FirstDisplayedScrollingRowIndex = 0;
                DGV_PickOther.FirstDisplayedScrollingColumnIndex = 0;
                vSB_PickOther.Value = 0;


                //VScrollBar設定
                int MaxRowsInWindow = 6;
                if (dt_PickOtherContent.Rows.Count > MaxRowsInWindow)
                    vSB_PickOther.Visible = true;
                else
                    vSB_PickOther.Visible = false;
                vSB_PickOther.Maximum = dt_PickOtherContent.Rows.Count + MaxRowsInWindow;
                vSB_PickOther.Scroll += new ScrollEventHandler(vSB_PickOther_Scroll);
            }
        }
        void vSB_PickOther_Scroll(object sender, ScrollEventArgs e)
        {
            if (vSB_PickOther.Value <= dt_PickOtherContent.Rows.Count - 1)
                DGV_PickOther.FirstDisplayedScrollingRowIndex = vSB_PickOther.Value;
            else
                DGV_PickOther.FirstDisplayedScrollingRowIndex = dt_PickOtherContent.Rows.Count - 5;
        }
        #endregion

        #region 補貨作業+併板
        //修改儲位文字
        void txS_recs_slodidNew_TextChanged(object sender, EventArgs e)
        {
            Flag_OutSlodCheck = false;
            bindingNavigatorOKButton.Enabled = false;
        }
        //確認儲位
        void txS_recs_slodidNew_Validated(object sender, EventArgs e)
        {
            string ErrMsg = "";
            if (txS_recs_slodidNew.Text.Equals(string.Empty))
            {
                Flag_OutSlodCheck = false;
                txMessage.Text = "請輸入移出儲位!";
                txS_recs_slodidNew.Focus();
                return;
            }

            if (txS_recs_slodidNew.Text.Length > 7)
            {
                Flag_OutSlodCheck = false;
                ErrMsg = "儲位長度超過7碼!";
            }
            else
            {
                if (txS_recs_slodid.Text.Trim().ToUpper() == txS_recs_slodidNew.Text.Trim().ToUpper())
                {
                    Flag_OutSlodCheck = true;
                }
                else
                {
                    Flag_OutSlodCheck = false;
                    ErrMsg = "移出儲位與指定儲位不同，請重新確認!";
                }
            }

            if (Flag_OutSlodCheck)
            {
                txMessage.Text = "檢查併板移出品項後，按下確認";
                bindingNavigatorOKButton.Enabled = true;
            }
            else
            {
                Flag_OutSlodCheck = false;
                bindingNavigatorOKButton.Enabled = false;
                txMessage.Text = ErrMsg;
                txS_recs_slodidNew.Focus();
            }
        }

        /// <summary>
        /// 按下確認按鈕, 由BindingNavigatorOKButton發動
        /// </summary>
        void btnConfirm_Click()
        {
            if (!Flag_OutSlodCheck)
            {
                return;
            }

            #region 補貨單作業
            if (callSP_REPL_CFM() == false)
            {
                return;
            }
            #endregion

            #region 併板作業
            if (dt_PickOtherContent.Rows.Count > 0)
            {
                DataRow dr_PickOther;
                for (int h = 0; h < dt_PickOtherContent.Rows.Count; h++)
                {
                    dr_PickOther = dt_PickOtherContent.Rows[h];

                    if (dr_PickOther["Select"].ToString() == "1")
                    {
                        #region 有勾選
                        callSP_InsertRFreci(dr_PickOther["S_merp_Barcode"].ToString(), dr_PickOther["S_slod_id"].ToString(), "0");
                        #endregion
                    }
                    else
                    {
                        #region 沒勾選
                        lt_PickOther_NotSelect.Add(dr_PickOther);
                        callSP_InsertRFreci(dr_PickOther["S_merp_Barcode"].ToString(), dr_PickOther["S_slod_id"].ToString(), "1");
                        #endregion
                    }
                }

                #region 完成併板
                //完成拼版
                if (callSP_REPL_MERGE("0", "", lbl_OrderNo.Text, 0))
                {
                    //如果有回库商品
                    if (lt_PickOther_NotSelect.Count > 0)
                    {
                        tabControl1.SelectedIndex = 3;
                        callSP_BringContent_ReBack();
                        return;
                    }
                    else
                    {
                        //尋找下一筆單據
                        bool IsOK = GetContent_WorkContent_checkNext();
                        if (IsOK)
                        {
                            txS_recs_slodidNew.Focus();
                        }
                        else
                        {
                            fMsg.messageshow("單據作業完畢，請選擇其他單據");
                            tabControl1.SelectedIndex -= 1;
                        }
                    }
                }
                #endregion
            }
            #endregion
        }

        #region SP
        /// <summary>
        /// 補貨作業sp
        /// </summary>
        /// <param name="dr"></param>
        /// <returns>true=成功 false=失敗</returns>
        bool callSP_REPL_CFM()
        {
            string ErrMsg = "";

            Hashtable hashT_OutSlodid = new Hashtable();
            hashT_OutSlodid.Add("@L_reph_id", lbl_OrderNo.Text);
            hashT_OutSlodid.Add("@L_repi_sysno", lbl_L_repi_sysno.Text);
            hashT_OutSlodid.Add("@I_adjtype", 1);
            hashT_OutSlodid.Add("@I_inputtype", 1);
            hashT_OutSlodid.Add("@S_empd_id", UserInf.UserID);
            hashT_OutSlodid.Add("@S_Computer", UserInf.ComputerName);
            Hashtable hashT_OutSlodid_RetnValue = new Hashtable();
            hashT_OutSlodid_RetnValue.Add("@I_notfinish", null);
            hashT_OutSlodid_RetnValue.Add("@I_result", null);
            hashT_OutSlodid_RetnValue.Add("@S_result", null);
            DataSet DS_Cfm = IO.SqlSp(Login_Server, "SP_REPL_RFCFM", hashT_OutSlodid, ref hashT_OutSlodid_RetnValue);
            if (Convert.ToInt32(hashT_OutSlodid_RetnValue["@I_notfinish"]) == 0)
            {
                if (Convert.ToInt32(hashT_OutSlodid_RetnValue["@I_result"]) == 0)
                {
                    SqlCarOperateLog(lbl_OrderNo.Text, "C1", Convert.ToInt32(lbl_L_repi_replqty.Text), Convert.ToInt32(lbl_L_repi_replqty.Text));
                }
                else
                {
                    ErrMsg = hashT_OutSlodid_RetnValue["@S_result"].ToString();
                }
            }
            else
            {
                ErrMsg = "移出作業失敗";
            }

            Hashtable hashT_InSlodid = new Hashtable();
            hashT_InSlodid.Add("@L_reph_id", lbl_OrderNo.Text);
            hashT_InSlodid.Add("@L_repi_sysno", lbl_L_repi_sysno.Text);
            hashT_InSlodid.Add("@I_adjtype", 0);
            hashT_InSlodid.Add("@I_inputtype", 1);
            hashT_InSlodid.Add("@S_empd_id", UserInf.UserID);
            hashT_InSlodid.Add("@S_Computer", UserInf.ComputerName);
            Hashtable hashT_InSlodid_RetnValue = new Hashtable();
            hashT_InSlodid_RetnValue.Add("@I_notfinish", null);
            hashT_InSlodid_RetnValue.Add("@I_result", null);
            hashT_InSlodid_RetnValue.Add("@S_result", null);
            DataSet DS_Cfm1 = IO.SqlSp(Login_Server, "SP_REPL_RFCFM", hashT_InSlodid, ref hashT_InSlodid_RetnValue);
            if (Convert.ToInt32(hashT_InSlodid_RetnValue["@I_result"]) == 0)
            {
                SqlCarOperateLog(lbl_OrderNo.Text, "C2", Convert.ToInt32(lbl_L_repi_replqty.Text), Convert.ToInt32(lbl_L_repi_replqty.Text));
            }
            else
            {
                ErrMsg = hashT_OutSlodid_RetnValue["@S_result"].ToString();
            }

            if (!ErrMsg.Equals(string.Empty))
            {
                txMessage.Text = ErrMsg;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 新增併板資料
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="slodId"></param>
        /// <param name="Mark"></param>
        void callSP_InsertRFreci(string barcode, string slodId, string Mark)
        {
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Seq", 3);
            ht1.Add("@L_reph_id", lbl_OrderNo.Text);
            ht1.Add("@S_outslodid", txS_recs_slodidNew.Text);
            ht1.Add("@S_merp_barcode", barcode);
            ht1.Add("@S_slod_id", slodId);
            ht1.Add("@Mark", Mark);
            ht1.Add("@UserID", UserInf.UserID);
            ht1.Add("@ComputerName", UserInf.ComputerName);
            ht1.Add("@FormName", strLockFormName);
            IO.SqlSp(Login_Server, "spCarSystem_6_2", ht1, ref OutValue_finish);
        }

        /// <summary>
        /// 完成併板作業sp
        /// </summary>
        /// <returns></returns>
        bool callSP_REPL_MERGE(string adjType, string SlodId_in, string s_meth_id, int L_SLOM_SYSNO_return)
        {
            string ErrMsg = "";
            Hashtable hashT_InSlodid = new Hashtable();
            hashT_InSlodid.Add("@I_inputtype", 1);
            hashT_InSlodid.Add("@I_adjtype", adjType);
            hashT_InSlodid.Add("@S_SLOM_SLODID_in", SlodId_in);
            hashT_InSlodid.Add("@L_SLOM_SYSNO_return", L_SLOM_SYSNO_return);
            hashT_InSlodid.Add("@L_meti_methid", s_meth_id);
            hashT_InSlodid.Add("@S_empdid", UserInf.UserID);
            hashT_InSlodid.Add("@S_Computer", UserInf.ComputerName);
            Hashtable hashT_InSlodid_RetnValue = new Hashtable();
            hashT_InSlodid_RetnValue.Add("@I_result", null);
            hashT_InSlodid_RetnValue.Add("@S_result", null);
            DataSet DS_Cfm1 = IO.SqlSp(Login_Server, "SP_REPL_MERGE", hashT_InSlodid, ref hashT_InSlodid_RetnValue);
            if (Convert.ToInt32(hashT_InSlodid_RetnValue["@I_result"]) == 0)
            {
                ReturnMetrHeadId = hashT_InSlodid_RetnValue["@S_result"].ToString();
                SqlCarOperateLog(lbl_OrderNo.Text, "C3", 0, 0);
            }
            else
            {
                ErrMsg = hashT_InSlodid_RetnValue["@S_result"].ToString();
            }

            if (!ErrMsg.Equals(string.Empty))
            {
                if (tabControl1.SelectedIndex == 2)
                    txMessage.Text = ErrMsg;
                else if (tabControl1.SelectedIndex == 3)
                    txMessage2.Text = ErrMsg;
                return false;
            }
            return true;
        }
        #endregion

        #endregion

        #region 回庫作業

        private void txb_Return_slodid_TextChanged(object sender, EventArgs e)
        {
            Flag_OutSlodCheck = false;
            bindingNavigatorOKButton.Enabled = false;
        }

        private void txb_Return_slodid_Validated(object sender, EventArgs e)
        {
            string ErrMsg = "";
            if (txb_Return_slodid.Text.Equals(string.Empty))
            {
                Flag_OutSlodCheck = false;
                txMessage2.Text = "請輸入移出儲位!";
                txb_Return_slodid.Focus();
                return;
            }

            if (txb_Return_slodid.Text.Length > 7)
            {
                Flag_OutSlodCheck = false;
                ErrMsg = "儲位長度超過7碼!";
            }

            if (Flag_OutSlodCheck)
            {
                txMessage2.Text = "檢查併板入庫品項後，按下確認";
                bindingNavigatorOKButton.Enabled = true;
            }
            else
            {
                Flag_OutSlodCheck = false;
                bindingNavigatorOKButton.Enabled = false;
                txMessage2.Text = ErrMsg;
                txb_Return_slodid.Focus();
            }
        }

        /// <summary>
        /// 按下確認
        /// </summary>
        void btnConfirm_Return_Click()
        {
            bool IsOK = false;
            foreach (DataRow dr in lt_PickOther_NotSelect)
            {
                if (!callSP_REPL_MERGE("1", txb_Return_slodid.Text, lbl_OrderNo.Text, Convert.ToInt32(dr["L_slom_sysno"])))
                {
                    IsOK = false;
                }
                else
                {
                    IsOK = true;
                }
            }

            if (IsOK)
            {
                fMsg.messageshow("回庫成功！");
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                fMsg.messageshow("回庫失敗！");
            }
        }

        /// <summary>
        /// 回庫資料
        /// </summary>
        /// <returns></returns>
        void callSP_BringContent_ReBack()
        {
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Seq", 4);
            ht1.Add("@L_reph_id", ReturnMetrHeadId);
            ht1.Add("@S_outslodid", "");
            ht1.Add("@S_merp_barcode", "");
            ht1.Add("@S_slod_id", "");
            ht1.Add("@Mark", "");
            ht1.Add("@UserID", UserInf.UserID);
            ht1.Add("@ComputerName", UserInf.ComputerName);
            ht1.Add("@FormName", strLockFormName);
            DataSet ds = IO.SqlSp(Login_Server, "spCarSystem_6_2", ht1, ref OutValue_finish);
            dt_Return = ds.Tables[0];

            DGV_Return.DataSource = dt_Return;
            DGV_Return.FirstDisplayedScrollingRowIndex = 0;
            DGV_Return.FirstDisplayedScrollingColumnIndex = 0;
            vSB_Return.Value = 0;


            //VScrollBar設定
            int MaxRowsInWindow = 6;
            if (dt_Return.Rows.Count > MaxRowsInWindow)
                vSB_Return.Visible = true;
            else
                vSB_Return.Visible = false;
            vSB_Return.Maximum = dt_Return.Rows.Count + MaxRowsInWindow;
            vSB_Return.Scroll += new ScrollEventHandler(vSB_Return_Scroll);
        }
        void vSB_Return_Scroll(object sender, ScrollEventArgs e)
        {
            if (vSB_Return.Value <= dt_Return.Rows.Count - 1)
                DGV_Return.FirstDisplayedScrollingRowIndex = vSB_Return.Value;
            else
                DGV_Return.FirstDisplayedScrollingRowIndex = dt_Return.Rows.Count - 5;
        }
        #endregion

        #region tabcontrol分頁切換
        private int NowPage = 0, FuturePage = 0;
        /// <summary>
        /// 選擇頁面進入前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            FuturePage = e.TabPageIndex;
        }
        /// <summary>
        /// 取消目前選取頁面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            NowPage = e.TabPageIndex;
        }

        /// <summary>
        /// 實際作業頁面轉換到單號頁面,取消鎖定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NowPage >1
                && FuturePage <2)
            {
                Flag_checkEnterCummitStatus = false;
                LockRelease("repl_head", lbl_OrderNo.Text.Trim());
            }
        }
        #endregion


    }
}
