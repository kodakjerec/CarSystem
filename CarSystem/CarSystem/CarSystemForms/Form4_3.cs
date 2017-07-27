using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace CarSystem
{
    public partial class Form4_3 : Car_Fun.CarSystem_Sample_Form
    {
        #region 全域變數
        int intSelectMode = 1;
        DataTable dtPickList = new DataTable();
        bool bolItemValidFlag = false, bolQtyValidFlag = false;
        #endregion

        public Form4_3()
        {
            InitializeComponent();
        }

        protected override void New_WSC_DLL_Form_Load(object sender, EventArgs e)
        {
            base.New_WSC_DLL_Form_Load(sender, e);
            Login_Server = UserInf.DBName;

            SetMasterBindingNavigator(null);
            SetButtonEnable("PL");

            txB_merdId.Click += Click_Show_frmKeyboardNumber;
            txB_picQty.Click += Click_Show_frmKeyboardNumber;

            BringWorkZone();
        }

        //Map按下返回上一頁
        protected override void PreviousButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                LockRelease("group_head", Lbl_Groh_id.Text.Trim() + lbl_WorkZone2.Text + lbl_S_slod_pick.Text + txB_S_Merd_id.Text);

            if (tabControl1.SelectedIndex > 0)
                tabControl1.SelectedIndex -= 1;
        }

        //離開系統
        protected override void LeaveButton_Click(object sender, EventArgs e)
        {
            LockRelease("group_head", Lbl_Groh_id.Text.Trim() + lbl_WorkZone2.Text + lbl_S_slod_pick.Text + txB_S_Merd_id.Text);
            base.LeaveButton_Click(sender, e);
        }

        #region 選擇區域頁面
        DataTable dtBringWorkZone = new DataTable();
        /// <summary>
        /// 帶出工作區域
        /// </summary>
        private void BringWorkZone()
        {
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Type", 0);
            ht1.Add("@item", intSelectMode);
            ht1.Add("@WorkZone", "");
            ht1.Add("@UserID", UserInf.UserID);
            ht1.Add("ComputerName", UserInf.ComputerName);
            ht1.Add("@FormName", strLockFormName);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_4_3", ht1, ref OutValue_finish);
            dtBringWorkZone = DS_Query.Tables[0];
            DGV_Item.DataSource = dtBringWorkZone;
            if (dtBringWorkZone.Rows.Count == 0)
                Lbl_Item_SuccessMessage2.Text = "無未完成的彙總單";
            else
                Lbl_Item_SuccessMessage2.Text = "";

            //VScrollBar設定
            vSB_Item.Maximum = dtBringWorkZone.Rows.Count + 5;
            vSB_Item.Scroll += new ScrollEventHandler(vSB_Item_Scroll);
        }
        void vSB_Item_Scroll(object sender, ScrollEventArgs e)
        {
            if (vSB_Item.Value <= dtBringWorkZone.Rows.Count - 1)
                DGV_Item.FirstDisplayedScrollingRowIndex = vSB_Item.Value;
            else
                DGV_Item.FirstDisplayedScrollingRowIndex = dtBringWorkZone.Rows.Count - 5;
        }

        //選定工作區域
        private void DGV_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //沒選到返回
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = DGV_Item.Rows[e.RowIndex];
            tabControl1.SelectedIndex += 1;
            lbl_SelectMode.Text = intSelectMode == 0 ? "拆零揀貨" : "成箱揀貨";
            lbl_WorkZone.Text = row.Cells["S_groi_sechid"].Value.ToString();
            lbl_SelectMode2.Text = lbl_SelectMode.Text;
            lbl_WorkZone2.Text = lbl_WorkZone.Text;
            SetRfWorkZone();
            BringPichID();
        }
        /// <summary>
        /// 設定RF工作區域
        /// </summary>
        private void SetRfWorkZone()
        {
            int IsOk = 0;
            string cmdSQL = "Select count(1) from rf_workzone where S_rfwz_rfid=@ComputerName";
            Hashtable ht1 = new Hashtable(), ht2 = new Hashtable();
            ht1.Add("@ComputerName", UserInf.ComputerName);
            DataSet DS_Query = IO.SqlQuery(Login_Server, cmdSQL, ht1);
            DataTable dt_Query = DS_Query.Tables[0];
            if (dt_Query.Rows.Count > 0)
            {
                cmdSQL =
                @"Update rf_workzone 
                set S_rfwz_piczid=@WorkZone,S_rfwz_updempdid=@UserID,T_rfwz_upddate=getdate()
                where S_rfwz_rfid=@ComputerName";
            }
            else
            {
                cmdSQL =
                @"Insert Into rf_workzone 
                values(@ComputerName,@WorkZone,@UserID,getdate(),null,null)";
            }
            ht2.Add("@ComputerName", UserInf.ComputerName);
            ht2.Add("@UserID", UserInf.UserID);
            ht2.Add("@WorkZone", lbl_WorkZone.Text);
            IO.SqlUpdate(Login_Server, cmdSQL, ht2, ref IsOk);
        }
        #endregion

        #region 選擇單號畫面
        DataTable dtBringPichID = new DataTable();
        private void BringPichID()
        {
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Type", 1);
            ht1.Add("@item", intSelectMode);
            ht1.Add("@WorkZone", lbl_WorkZone.Text);
            ht1.Add("@UserID", UserInf.UserID);
            ht1.Add("ComputerName", UserInf.ComputerName);
            ht1.Add("@FormName", strLockFormName);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_4_3", ht1, ref OutValue_finish);
            dtBringPichID = DS_Query.Tables[0];
            DGV_Slod.DataSource = dtBringPichID;
            if (dtBringPichID.Rows.Count == 0)
                Lbl_Item_SuccessMessage2.Text = "無未完成的揀貨單";
            else
                Lbl_Item_SuccessMessage2.Text = "";

            //VScrollBar設定
            vSB_Slod.Maximum = dtBringPichID.Rows.Count + 5;
            vSB_Slod.Scroll += new ScrollEventHandler(vSB_Slod_Scroll);
        }
        void vSB_Slod_Scroll(object sender, ScrollEventArgs e)
        {
            if (vSB_Slod.Value <= dtBringPichID.Rows.Count - 1)
                DGV_Slod.FirstDisplayedScrollingRowIndex = vSB_Slod.Value;
            else
                DGV_Slod.FirstDisplayedScrollingRowIndex = dtBringPichID.Rows.Count - 5;
        }

        //選定單號
        private void DGV_Slod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //沒選到返回
            if (e.RowIndex < 0)
                return;

            //清除舊資料
            tbP_Working_ClearContent();

            string ErrMsg = "";
            DataGridViewRow row = DGV_Slod.Rows[e.RowIndex];

            //帶入資料
            Lbl_Groh_id.Text = row.Cells["L_groh_id"].Value.ToString();
            lbl_S_slod_pick.Text = row.Cells["S_slod_pick"].Value.ToString();
            lbl_S_slod_pick_name.Text = row.Cells["S_slod_pick_name"].Value.ToString();

            //帶出第一筆資料
            bool FinishFlag = false;
            ErrMsg = GetDataTodoPiciId(ref FinishFlag);

            if (FinishFlag)
            {
                if (ErrMsg != "")
                {
                    fMsg.messageshow(ErrMsg);
                }
                else
                {
                    Lbl_WarringMsg.Text = "刷入商品條碼";
                    tabControl1.SelectedIndex += 1;
                }
            }
            else
            {
                if (ErrMsg != "")
                {
                    fMsg.messageshow(ErrMsg);
                }
            }
        }
        #endregion

        #region 實際作業畫面
        //帶出明細內容
        private void BringPickDetail(DataRow dr)
        {
            //儲位編號
            txB_SlodId.Text = dr["S_groi_Slodid"].ToString();
            //商品名稱
            rtxN_merd_name.Text = dr["N_merd_name"].ToString();
            //效期
            if (dr["D_merl_expdate"].ToString() != "")
                txB_D_merl_expdate.Text = DateTime.Parse(dr["D_merl_expdate"].ToString()).ToString("yyyy-MM-dd");
            else
                txB_D_merl_expdate.Text = "";
            //貨號
            txB_S_Merd_id.Text = dr["S_merd_id"].ToString();
            //箱條碼
            txB_S_merp_barcode2.Text = dr["S_merp_barcode"].ToString();
            //剩餘量
            lbl_groi_left_value.Text = dr["S_groi_diff"].ToString();
            //與XD撞單
            lbl_XDoverlap.Text = dr["N_groi_XDoverlap"].ToString();
            if (lbl_XDoverlap.Text != "")
                lbl_XDoverlap.Visible = true;
            else
                lbl_XDoverlap.Visible = false;

            #region Label
            //應揀量
            lbL_repi_replqty_out_box_value.Text = (Convert.ToInt32(dr["L_groi_pickqty"].ToString()) / Convert.ToInt32(dr["I_merp_1qty"].ToString())).ToString();
            //已揀量
            lbL_repi_replqty_out_pallet_value.Text = (Convert.ToInt32(dr["L_groi_takeqty"].ToString()) / Convert.ToInt32(dr["I_merp_1qty"].ToString())).ToString();
            #endregion

            //應揀量
            txB_picQty.Text = (Convert.ToInt32(lbL_repi_replqty_out_box_value.Text) - Convert.ToInt32(lbL_repi_replqty_out_pallet_value.Text)).ToString();
            //箱入數
            lbl_I_merp_1qty_value.Text = dr["I_merp_1qty"].ToString();
            //小包裝
            lbl_EApack_Value.Text = dr["EAqty"].ToString();

        }

        //刷入商品條碼
        int merdIdErrCount = 1;
        private void txB_merdId_Validated(object sender, EventArgs e)
        {
            string ErrMsg = "";
            bolItemValidFlag = false;
            if (FuturePage != (tabControl1.TabCount - 1))
                return;

            if (txB_merdId.Text == "")
            {
                ErrMsg = "刷入商品條碼";
            }
            else if (txB_merdId.Text != txB_S_Merd_id.Text && txB_merdId.Text != txB_S_merp_barcode2.Text)
            {
                ErrMsg = "刷入正確商品條碼 錯誤次數 " + merdIdErrCount.ToString();
            }
            else
            {
                Lbl_WarringMsg.Text = "確認揀貨數量";
            }

            if (ErrMsg != "")
            {
                Lbl_WarringMsg.Text = ErrMsg;
                txB_merdId.Text = "";
                merdIdErrCount++;
                txB_merdId.Focus();
            }
            else
            {
                bolItemValidFlag = true;
                merdIdErrCount = 1;
                txB_picQty.Focus();
            }
        }

        //驗證揀貨量
        private void txB_picQty_Validated(object sender, EventArgs e)
        {
            string ErrMsg = "";
            bolQtyValidFlag = false;

            Lbl_WarringMsg.Text = "確認後按下「完成」";

            if (ErrMsg != "")
            {
                Lbl_WarringMsg.Text = ErrMsg;
                txB_picQty.Text = lbL_repi_replqty_out_box_value.Text;
                txB_picQty.Focus();
            }
            else
            {
                bolQtyValidFlag = true;
                cummit.Focus();
            }
        }

        //完成揀貨
        private void cummit_Click(object sender, EventArgs e)
        {
            bool FinishFlag = false;
            string ErrMsg = "", sqlstr = "";

            #region 錯誤檢查
            if (!bolItemValidFlag)
            {
                Lbl_WarringMsg.Text = " 商品條碼未驗證";
                txB_merdId.Focus();
                return;
            }

            if (!bolQtyValidFlag)
            {
                Lbl_WarringMsg.Text = " 揀貨量未驗證";
                txB_picQty.Focus();
                return;
            }
            #endregion

            #region 計算揀貨量
            int I_merp_1qty = Convert.ToInt32(lbl_I_merp_1qty_value.Text);
            DataRow dr = dtPickList.Rows[0];

            #region 立即更新已揀量, 防止有他人重複操作/當機
            //如果耀欣有更改他的sp, 則此段多餘
            sqlstr = 
            @" Select L_groi_takeqty
            from group_item with (nolock)
            where L_groi_sysno=@L_groi_sysno ";
            Hashtable htCheckPickQty = new Hashtable();
            htCheckPickQty.Add("@L_groi_sysno", dr["L_groi_sysno"]);
            DataTable dtCheckPickqty = IO.SqlQuery(Login_Server, sqlstr, htCheckPickQty).Tables[0];
            int intL_groi_takeqty = Convert.ToInt32(dtCheckPickqty.Rows[0]["L_groi_takeqty"]);
            lbL_repi_replqty_out_pallet_value.Text = (intL_groi_takeqty / I_merp_1qty).ToString();
            #endregion


            int SUM = 0,    //總揀貨量
                OrdQty = Convert.ToInt32(lbL_repi_replqty_out_box_value.Text) * I_merp_1qty,  //應揀量
                PicQty = Convert.ToInt32(lbL_repi_replqty_out_pallet_value.Text) * I_merp_1qty;//已揀量

            SUM = Convert.ToInt32(txB_picQty.Text) * I_merp_1qty;

            if (SUM > (OrdQty - PicQty))
            {
                ErrMsg = "輸入數量超出應揀貨量！";
            }
            else if (SUM < (OrdQty - PicQty))
            {
                bool resultDialog = false;

                resultDialog = fMsg.messageshow("實揀量不等於應揀量，是否繼續揀貨！", "提示", true);

                if (resultDialog == true)
                {
                    #region 持續作業
                    #endregion
                }
                else
                {
                    #region 缺貨
                    resultDialog = fMsg.messageshow("是否確認短少！", "提示",true);
                    if (resultDialog == true)
                    {
                        int SuccessCount = 0;
                        sqlstr = "update GROUP_ITEM set I_groi_flag=2,I_groi_inputtype=1 where L_GROI_SYSNO=@groisysno";
                        Hashtable ht1 = new Hashtable();
                        ht1.Add("@groisysno", dr["L_groi_sysno"]);
                        IO.SqlUpdate(Login_Server, sqlstr, ht1, ref SuccessCount);

                        //20140314 Kota 寫入log
                        SqlCarOperateLog(Lbl_Groh_id.Text + "," + dr["L_groi_sysno"].ToString(), "L", 0, SUM);

                        if (SuccessCount == 0)
                        {
                            ErrMsg = "保存執行失敗！";
                        }
                    }
                    #endregion
                }
            }
            #endregion

            if (ErrMsg == "")
            {
                //log開始
                string Logstring = "" + "," + Lbl_Groh_id.Text.Trim() + "," + txB_merdId.Text.Trim() + "," + txB_picQty.Text.Trim();
                reclog.ExLog("41", "Sta,彙總揀貨明細," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Logstring);

                #region 裝箱資料寫入：SP_UPDATE_groupitem
                Hashtable htINSBoxItem = new Hashtable(), hashtable2 = new Hashtable();
                htINSBoxItem.Add("@L_grohid", Lbl_Groh_id.Text);
                htINSBoxItem.Add("@L_groi_sysno", dr["L_groi_sysno"]);
                htINSBoxItem.Add("@T_groi_picktimes", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
                htINSBoxItem.Add("@S_slodid", dr["S_GROI_SLODID"]);
                htINSBoxItem.Add("@L_groi_slomsysno", dr["L_groi_slomsysno"]);
                htINSBoxItem.Add("@L_merdsysno", dr["L_groi_merdsysno"]);
                htINSBoxItem.Add("@L_merlsysno", dr["L_groi_merlsysno"]);
                htINSBoxItem.Add("@L_qty", SUM);
                htINSBoxItem.Add("@I_inputtype", 1);
                htINSBoxItem.Add("@S_empid", UserInf.UserID);
                htINSBoxItem.Add("@S_computer", UserInf.ComputerName);

                hashtable2.Add("@I_result", "");
                hashtable2.Add("@S_result", "");
                hashtable2.Add("@I_pickcnt", "");

                IO.SqlSp(Login_Server, "SP_UPDATE_groupitem", htINSBoxItem, ref hashtable2);

                string I_result = hashtable2["@I_result"].ToString(),
                I_pickcnt = hashtable2["@I_pickcnt"].ToString(),
                S_result = hashtable2["@S_result"].ToString();
                #endregion

                if (I_result == "0")
                {
                    //裝箱成功
                    bolItemValidFlag = false;
                    bolQtyValidFlag = false;

                    //20140314 Kota 寫入log
                    SqlCarOperateLog(Lbl_Groh_id.Text + "," + dr["L_groi_sysno"].ToString(), "C", 0, SUM);

                    if (I_pickcnt == "0") //沒有尚未揀貨的明細
                    {
                        #region 釋放單據
                        if (!LockRelease("group_head", Lbl_Groh_id.Text.Trim() + lbl_WorkZone2.Text + lbl_S_slod_pick.Text + txB_S_Merd_id.Text))
                        {
                            ErrMsg = "釋放單據失敗！";
                        }
                        else
                        {
                            ErrMsg = "";
                            FinishFlag = true;

                            //單據已完成
                            fMsg.messageshow("單據完成，請切換其他彙總單");

                            tbP_Working_ClearContent();
                            BringPichID();
                            bindingNavigatorPreviousButton.PerformClick();
                        }
                        #endregion
                    }
                    else
                    {
                        #region 釋放單據,準備下一筆揀貨明細
                        if (!LockRelease("group_head", Lbl_Groh_id.Text.Trim() + lbl_WorkZone2.Text + lbl_S_slod_pick.Text + txB_S_Merd_id.Text))
                        {
                            ErrMsg = strLockRequestString;
                        }
                        else
                        {
                            #region 以下尚有揀貨明細
                            //準備下一筆單據
                            ErrMsg = GetDataTodoPiciId(ref FinishFlag);
                            if (FinishFlag)
                            {
                                if (ErrMsg == "")
                                {
                                    Lbl_WarringMsg.Text = "刷入商品條碼";

                                    txB_merdId.Text = "";
                                    txB_merdId.Focus();
                                }
                                else
                                {
                                    //單據已完成
                                    fMsg.messageshow(ErrMsg);

                                    tbP_Working_ClearContent();
                                    BringPichID();
                                    bindingNavigatorPreviousButton.PerformClick();
                                }
                            }
                            #endregion
                        }
                        #endregion
                    }
                }
                else
                {
                    ErrMsg = S_result;
                }
                //log結束
                reclog.ExLog("41", "End,彙總揀貨明細," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Logstring);
            }

            if (!FinishFlag)
            {
                if (ErrMsg != "")
                {
                    Lbl_WarringMsg.Text = ErrMsg;
                    cummit.Focus();
                }
            }
        }
        #endregion

        #region 特定函數

        /// <summary>
        /// 清除實際作業分頁資料
        /// </summary>
        private void tbP_Working_ClearContent()
        {
            foreach (Control ctl in tbP_Working.Controls)
            {
                string TypeName = ctl.GetType().Name.ToString();
                if (TypeName == "TextBox")
                    ((TextBox)ctl).Text = "";
            }

            Lbl_WarringMsg.Text = "刷入商品條碼";
        }

        /// <summary>
        /// 找出下一筆待執行資料
        /// </summary>
        /// <param name="PichId"></param>
        /// <param name="BoxId"></param>
        /// <returns></returns>
        private string GetDataTodoPiciId(ref bool FinishFlag)
        {
            string ErrMsg = "";

            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Type", 2);
            ht1.Add("@item", Lbl_Groh_id.Text);
            ht1.Add("@WorkZone", lbl_WorkZone2.Text);
            ht1.Add("@Boxid", lbl_S_slod_pick.Text);
            ht1.Add("@UserID", UserInf.UserID);
            ht1.Add("ComputerName", UserInf.ComputerName);
            ht1.Add("@FormName", strLockFormName);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_4_3", ht1, ref OutValue_finish);
            dtPickList = DS_Query.Tables[0];

            if (dtPickList.Rows.Count > 0)
            {
                FinishFlag = true;
                ErrMsg = "";
                BringPickDetail(dtPickList.Rows[0]);

                #region 鎖定單號
                if (!LockRequest("group_head", Lbl_Groh_id.Text.Trim() + lbl_WorkZone2.Text + lbl_S_slod_pick.Text + txB_S_Merd_id.Text))
                {
                    FinishFlag = false;
                    ErrMsg = strLockRequestString;
                }
                #endregion
            }
            else
            {
                FinishFlag = true;
                ErrMsg = Lbl_Groh_id.Text.Trim() + " 此單已完成";

                #region 是否有可能被鎖單,導致找不到明細
                string cmdstring = @"select top 1 0 from locktable where S_loct_id like '%'+@groh_id+'%'";
                ht1 = new Hashtable();
                ht1.Add("@groh_id", Lbl_Groh_id.Text.Trim());
                DataSet DS_ChkLockTable = IO.SqlQuery(Login_Server, cmdstring, ht1);
                if (DS_ChkLockTable.Tables[0].Rows.Count > 0)
                {
                    ErrMsg = Lbl_Groh_id.Text.Trim() + " 鎖單中或尚有人員在操作";
                }
                #endregion
            }

            return ErrMsg;
        }

        /// <summary>
        /// 更改數量顏色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Merdid_Itemvalue_Change(Label sender)
        {
            if (sender.Text == "" || sender.Text == "0")
                sender.Text = "00";

            if (sender != null)
            {
                //數量不等於0
                if (sender.Text != "00")
                {
                    sender.ForeColor = Color_tbFocus_ForeColor;
                    sender.BackColor = Color_tbFocus_BackColor;
                    switch (sender.Name)
                    {
                        case "lbL_repi_replqty_out_box_value":
                            lbL_repi_replqty_out_box.ForeColor = Color_lbMemoImportant_ForeColor;
                            lbL_repi_replqty_out_box.BackColor = Color_lbMemoImportant_BackColor; break;
                        case "lbL_repi_replqty_out_pallet_value":
                            lbL_repi_replqty_out_pallet.ForeColor = Color_lbMemoImportant_ForeColor;
                            lbL_repi_replqty_out_pallet.BackColor = Color_lbMemoImportant_BackColor; break;
                    }
                }
                else
                {
                    sender.ForeColor = Color_ForeColor;
                    sender.BackColor = Color_BackColor;
                    switch (sender.Name)
                    {
                        case "lbL_repi_replqty_out_box_value":
                            lbL_repi_replqty_out_box.ForeColor = Color_lbMemo_ForeColor;
                            lbL_repi_replqty_out_box.BackColor = Color_lbMemo_BackColor; break;
                        case "lbL_repi_replqty_out_pallet_value":
                            lbL_repi_replqty_out_pallet.ForeColor = Color_lbMemo_ForeColor;
                            lbL_repi_replqty_out_pallet.BackColor = Color_lbMemo_BackColor; break;
                    }
                }
            }
        }
        private void lbL_repi_replqty_out_box_value_TextChanged(object sender, EventArgs e)
        {
            Merdid_Itemvalue_Change((Label)sender);
        }
        private void lbL_repi_replqty_out_pallet_value_TextChanged(object sender, EventArgs e)
        {
            Merdid_Itemvalue_Change((Label)sender);
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
            if (NowPage == (tabControl1.TabCount - 1) && FuturePage != (tabControl1.TabCount - 1))
                LockRelease("group_head", Lbl_Groh_id.Text.Trim() + lbl_WorkZone2.Text + lbl_S_slod_pick.Text + txB_S_Merd_id.Text);
        }
        #endregion

    }
}
