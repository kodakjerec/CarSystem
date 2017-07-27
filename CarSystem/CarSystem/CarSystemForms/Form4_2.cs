using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace CarSystem
{
    public partial class Form4_2 : Car_Fun.CarSystem_Sample_Form
    {
        #region 全域變數
        int SelectMode = 0, PickSeq = 0;
        DataTable PickList = new DataTable();
        bool BoxValidFlag = false, ItemValidFlag = false, QtyValidFlag = false;
        #endregion

        public Form4_2()
        {
            InitializeComponent();
        }

        protected override void New_WSC_DLL_Form_Load(object sender, EventArgs e)
        {
            base.New_WSC_DLL_Form_Load(sender, e);
            Login_Server = UserInf.DBName;

            SetMasterBindingNavigator(null);
            SetButtonEnable("PL");

            txB_BoxId.Click += Click_Show_frmKeyboardEngNumber;
            txB_merdId.Click += Click_Show_frmKeyboardNumber;
            txB_picQty.Click += Click_Show_frmKeyboardNumber;

            BringWorkZone();
        }

        //Map按下返回上一頁
        protected override void PreviousButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                LockRelease("pich_head",Lbl_Pich_id.Text);

            if (tabControl1.SelectedIndex > 0)
                tabControl1.SelectedIndex -= 1;
        }

        //離開系統
        protected override void LeaveButton_Click(object sender, EventArgs e)
        {
            LockRelease("pich_head", Lbl_Pich_id.Text);
            base.LeaveButton_Click(sender, e);
        }

        #region 選擇區域頁面
        /// <summary>
        /// 帶出工作區域
        /// </summary>
        private void BringWorkZone()
        {
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Type", 0);
            ht1.Add("@item", SelectMode);
            ht1.Add("@WorkZone", "");
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_4_2", ht1, ref OutValue_finish);
            DataTable dt_Query = DS_Query.Tables[0];
            DGV_Item.DataSource = dt_Query;
            if (dt_Query.Rows.Count == 0)
                Lbl_Item_SuccessMessage2.Text = "無未完成的揀貨單";
            else
                Lbl_Item_SuccessMessage2.Text = "";

            //VScrollBar設定
            vSB_Item.Maximum = dt_Query.Rows.Count + 2;
            vSB_Item.Scroll += new ScrollEventHandler(vSB_Item_Scroll);
        }
        void vSB_Item_Scroll(object sender, ScrollEventArgs e)
        {
            DGV_Item.FirstDisplayedScrollingRowIndex = vSB_Item.Value;
        }

        //選定工作區域
        private void DGV_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //沒選到返回
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = DGV_Item.Rows[e.RowIndex];
            tabControl1.SelectedIndex += 1;
            lbl_SelectMode.Text = SelectMode == 0 ? "拆零揀貨" : "成箱揀貨";
            lbl_WorkZone.Text = row.Cells["S_pich_sechid"].Value.ToString();
            lbl_SelectMode2.Text = lbl_SelectMode.Text;
            lbl_WorkZone2.Text = lbl_WorkZone.Text;
            SetRfWorkZone();
            BringPichID();
        }

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
        private void BringPichID()
        {
            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Type", 1);
            ht1.Add("@item", SelectMode);
            ht1.Add("@WorkZone", lbl_WorkZone.Text);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_4_2", ht1, ref OutValue_finish);
            DataTable dt_Query = DS_Query.Tables[0];
            DGV_Slod.DataSource = dt_Query;
            if (dt_Query.Rows.Count == 0)
                Lbl_Item_SuccessMessage2.Text = "無未完成的揀貨單";
            else
                Lbl_Item_SuccessMessage2.Text = "";

            //VScrollBar設定
            vSB_Slod.Maximum = dt_Query.Rows.Count;
            vSB_Slod.Scroll += new ScrollEventHandler(vSB_Slod_Scroll);
        }
        void vSB_Slod_Scroll(object sender, ScrollEventArgs e)
        {
            DGV_Slod.FirstDisplayedScrollingRowIndex = vSB_Slod.Value;
        }

        //選定單號
        private void DGV_Slod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ErrMsg = "";

            //沒選到返回
            if (e.RowIndex < 0)
                return;

            //清除舊資料
            tbP_Working_ClearContent();

            DataGridViewRow row = DGV_Slod.Rows[e.RowIndex];

            //帶入資料
            Lbl_Pich_id.Text = row.Cells["L_pich_id"].Value.ToString();
            Lbl_cusId.Text = row.Cells["S_cusd_id"].Value.ToString();
            Lbl_cusName.Text = row.Cells["N_cusd_sname"].Value.ToString();

            #region 鎖定單號
            if (!LockRequest("pich_head", Lbl_Pich_id.Text))
            {
                ErrMsg = strLockRequestString;
            }
            #endregion

            if (ErrMsg != "")
            {
                fMsg.messageshow(ErrMsg);
                return;
            }

            tabControl1.SelectedIndex += 1;
        }
        #endregion

        #region 實際作業畫面
        //刷入容器標籤
        private void txB_BoxId_Validated(object sender, EventArgs e)
        {
            string ErrMsg = "";
            BoxValidFlag = false;
            if (FuturePage != (tabControl1.TabCount - 1))
                return;

            if (txB_BoxId.Text == "")
            {
                ErrMsg = "未找到容器編號，請再刷一遍！";
            }

            #region 確認容器標籤在不在
            if (ErrMsg == "")
            {
                Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
                ht1.Add("@Type", 2);
                ht1.Add("@item", Lbl_Pich_id.Text);
                ht1.Add("@WorkZone", lbl_WorkZone2.Text);
                ht1.Add("@Boxid", txB_BoxId.Text);
                DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_4_2", ht1, ref OutValue_finish);
                DataTable dt_Query = DS_Query.Tables[0];
                if (dt_Query.Rows.Count > 0)
                {
                    if (dt_Query.Rows.Count <= 1)
                    {
                        if (Convert.ToInt32(dt_Query.Rows[0]["I_boxh_flag"].ToString()) >= 175)
                        {
                            ErrMsg = "此容器已關箱!";
                        }
                        else
                        {
                            #region 容器綁定
                            #endregion
                        }
                    }
                    else
                    {
                        ErrMsg = "容器編號記錄大於一條，數據不正常，請聯繫管理員！";
                    }
                }
                else
                {
                    ErrMsg = "未找到容器編號，請再刷一遍！";
                }
            }
            #endregion

            #region 容器標籤正確，預先帶出明細內容
            if (ErrMsg == "")
            {
                GetDataTodoPiciId();

                if (PickList.Rows.Count > 0)
                {
                    PickSeq = 0;
                    BringPickDetail(PickList.Rows[PickSeq]);
                    Lbl_WarringMsg.Text = "刷入商品條碼";
                }
                else
                    ErrMsg = "未找到揀貨明細！";
            }
            #endregion

            if (ErrMsg != "")
            {
                Lbl_WarringMsg.Text = ErrMsg;
                txB_BoxId.Text = "";
                txB_BoxId.Focus();
            }
            else
            {
                BoxValidFlag = true;
                txB_merdId.Focus();
            }
        }

        //帶出明細內容
        private void BringPickDetail(DataRow dr)
        {
            //儲位編號
            txB_SlodId.Text = dr["S_pici_Slodid"].ToString();
            //商品名稱
            rtxN_merd_name.Text = dr["N_merd_name"].ToString();
            //效期
            if (dr["D_merl_expdate"].ToString() != "")
                txB_D_merl_expdate.Text = DateTime.Parse(dr["D_merl_expdate"].ToString()).ToString("yyyy-MM-dd");
            else
                txB_D_merl_expdate.Text = "";
            //貨號
            txB_S_Merd_id.Text = dr["S_merd_id"].ToString();
            //單條碼
            txB_S_merp_barcode.Text = dr["S_merp_barcode"].ToString();
            //箱條碼
            txB_S_merp_barcode2.Text = dr["S_merp_barcode2"].ToString();

            #region Label
            //應揀量
            lbL_repi_replqty_out_box_value.Text = dr["L_PICI_ORDQTY"].ToString();
            //已揀量
            lbL_repi_replqty_out_pallet_value.Text = dr["L_PICI_PICQTY"].ToString();
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
            ItemValidFlag = false;
            if (FuturePage != (tabControl1.TabCount - 1))
                return;

            if (txB_merdId.Text == "")
            {
                ErrMsg = "刷入商品條碼";
            }
            else if (txB_merdId.Text != txB_S_Merd_id.Text && txB_merdId.Text != txB_S_merp_barcode.Text)
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
                ItemValidFlag = true;
                merdIdErrCount = 1;
                txB_picQty.Focus();
            }
        }

        //驗證揀貨量
        private void txB_picQty_Validated(object sender, EventArgs e)
        {
            string ErrMsg = "";
            QtyValidFlag = false;

            Lbl_WarringMsg.Text = "確認後按下「完成」";

            if (ErrMsg != "")
            {
                Lbl_WarringMsg.Text = ErrMsg;
                txB_picQty.Text = lbL_repi_replqty_out_box_value.Text;
                txB_picQty.Focus();
            }
            else
            {
                QtyValidFlag = true;
                cummit.Focus();
            }
        }

        //完成揀貨
        private void cummit_Click(object sender, EventArgs e)
        {
            bool jxstatus = false, FinishFlag = false;
            string ErrMsg = "", sqlstr = "";

            #region 錯誤檢查
            if (!BoxValidFlag)
            {
                Lbl_WarringMsg.Text = "容器標籤未驗證";
                txB_BoxId.Focus();
                return;
            }

            if (!ItemValidFlag)
            {
                Lbl_WarringMsg.Text = " 商品條碼未驗證";
                txB_merdId.Focus();
                return;
            }

            if (!QtyValidFlag)
            {
                Lbl_WarringMsg.Text = " 揀貨量未驗證";
                txB_picQty.Focus();
                return;
            }
            #endregion

            #region 計算揀貨量
            int SUM = 0,    //總揀貨量
                OrdQty = Convert.ToInt32(lbL_repi_replqty_out_box_value.Text),  //應揀量
                PicQty = Convert.ToInt32(lbL_repi_replqty_out_pallet_value.Text);//已揀量

            SUM = Convert.ToInt32(txB_picQty.Text);
            DataRow dr = PickList.Rows[PickSeq];

            if (SUM > (OrdQty - PicQty))
            {
                ErrMsg = "輸入數量超出應揀貨量！";
            }
            else if (SUM < (OrdQty - PicQty))
            {
                bool resultDialog = false;

                //要進物流箱的才需要換箱(_ipichBox代表預估物流箱數)
                if (dr["I_pich_BOX"].ToString() == "0")
                    resultDialog = fMsg.messageshow("是否進行容器更換！", "提示", true);
                else
                    resultDialog = false;

                if (resultDialog == true)
                {
                    #region 換箱
                    jxstatus = true;
                    #endregion
                }
                else
                {
                    #region 缺貨
                    resultDialog = fMsg.messageshow("是否確認短少！", "提示", true);
                    if (resultDialog == true)
                    {
                        int SuccessCount = 0;
                        sqlstr = "update pick_item set I_pici_flag=1,I_pici_inputtype=1 where L_pici_sysno=@picisysno";
                        Hashtable ht1 = new Hashtable();
                        ht1.Add("@picisysno", dr["L_pici_sysno"]);
                        IO.SqlUpdate(Login_Server, sqlstr, ht1, ref SuccessCount);

                        //20140314 Kota 寫入log
                        SqlCarOperateLog(txB_BoxId.Text + "," + Lbl_Pich_id.Text + "," + dr["L_pici_sysno"].ToString(), "L", 0, 0);

                        if (SuccessCount == 0)
                        {
                            ErrMsg = "保存執行失敗！";
                        }
                    }
                    #endregion
                }
            }
            #endregion

            #region 確認裝箱資料
            if (ErrMsg == "")
            {
                #region 裝箱資料寫入：SP_ins_box_item
                Hashtable htINSBoxItem = new Hashtable(), hashtable2 = new Hashtable();
                htINSBoxItem.Add("@S_boxid", txB_BoxId.Text);
                htINSBoxItem.Add("@L_pichid", Lbl_Pich_id.Text);
                htINSBoxItem.Add("@L_picisysno", dr["L_pici_sysno"]);
                htINSBoxItem.Add("@D_boxh_times", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
                htINSBoxItem.Add("@S_slodid", dr["S_PICI_SLODID"]);
                htINSBoxItem.Add("@L_merdsysno", dr["L_pici_merdsysno"]);
                htINSBoxItem.Add("@L_qty", SUM);
                htINSBoxItem.Add("@I_inputtype", 1);
                htINSBoxItem.Add("@S_empid", UserInf.UserID);
                htINSBoxItem.Add("@S_computer", UserInf.ComputerName);

                hashtable2.Add("@I_result", 0);
                hashtable2.Add("@S_result", "");
                hashtable2.Add("@I_pickcnt", 0);

                //log開始
                string Logstring = txB_BoxId.Text.Trim() + "," + Lbl_Pich_id.Text.Trim() + "," + txB_merdId.Text.Trim() + txB_picQty.Text.Trim();
                reclog.ExLog("41", "Sta,物流箱裝入明細," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Logstring);

                IO.SqlSp(Login_Server, "SP_INS_box_item", htINSBoxItem, ref hashtable2);

                //20140314 Kota 寫入log
                SqlCarOperateLog(txB_BoxId.Text + "," + Lbl_Pich_id.Text + "," + dr["L_pici_sysno"].ToString(), "C", OrdQty, PicQty);

                //log結束
                reclog.ExLog("41", "End,物流箱裝入明細," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Logstring);


                int I_result = Convert.ToInt32(hashtable2["@I_result"].ToString()),
                I_pickcnt = Convert.ToInt32(hashtable2["@I_pickcnt"].ToString());
                string S_result = hashtable2["@S_result"].ToString();
                #endregion

                if (I_result == 0)
                {
                    //裝箱成功
                    ItemValidFlag = false;
                    QtyValidFlag = false;

                    if (I_pickcnt == 0) //沒有尚未揀貨的明細
                    {
                        #region 關箱
                        if (dr["I_pich_BOX"].ToString() == "0")
                        {
                            BoxValidFlag = false;
                            CLOSE_box_item(Lbl_Pich_id.Text);
                        }
                        #endregion

                        #region 釋放單據
                        if (!LockRelease("pich_head", Lbl_Pich_id.Text))
                        {
                            ErrMsg = "釋放單據失敗！";
                        }
                        else
                        {
                            FinishFlag = true;
                        }
                        #endregion
                    }
                    else
                    {
                        if (jxstatus)
                        {
                            #region 換箱
                            //關箱
                            BoxValidFlag = false;
                            bool IsCloseOk = CLOSE_box_item(Lbl_Pich_id.Text);

                            if (!IsCloseOk)
                            {
                                ErrMsg = "關箱失敗";
                            }
                            else
                            {
                                //準備下一筆單據
                                tbP_Working_ClearContent();
                                Lbl_WarringMsg.Text = "刷入容器編號";
                                txB_BoxId.Text = "";
                                txB_BoxId.Focus();
                            }
                            #endregion
                        }
                        else
                        {
                            #region 以下尚有揀貨明細

                            //準備下一筆單據
                            int haveData = GetDataTodoPiciId();

                            if (haveData==0)
                            {
                                Lbl_WarringMsg.Text = "刷入商品條碼";

                                txB_merdId.Text = "";
                                txB_merdId.Focus();
                            }
                            else
                            {
                                FinishFlag = true;
                            }
                            #endregion
                        }

                    }
                }
                else
                {
                    ErrMsg = S_result;
                }
            }
            #endregion

            if (FinishFlag)
            {
                fMsg.messageshow("此單已完成");
                tbP_Working_ClearContent();
                BringPichID();
                bindingNavigatorPreviousButton.PerformClick();
            }

            if (ErrMsg != "")
            {
                Lbl_WarringMsg.Text = ErrMsg;
                cummit.Focus();
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
            Lbl_WarringMsg.Text = "刷入物流箱標籤";
        }

        /// <summary>
        /// 找出下一筆待執行資料
        /// </summary>
        /// <param name="PichId"></param>
        /// <param name="BoxId"></param>
        /// <returns></returns>
        private int GetDataTodoPiciId()
        {
            int haveData = 0;

            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@Type", 3);
            ht1.Add("@item", Lbl_Pich_id.Text);
            ht1.Add("@WorkZone", lbl_WorkZone2.Text);
            ht1.Add("@Boxid", txB_BoxId.Text);
            DataSet DS_Query = IO.SqlSp(Login_Server, "spCarSystem_4_2", ht1, ref OutValue_finish);
            PickList = DS_Query.Tables[0];

            if (PickList.Rows.Count > 0)
            {
                haveData = 1;
                BringPickDetail(PickList.Rows[0]);
            }
            else
                haveData = 0;

            return haveData;
        }

        /// <summary>
        /// 關箱
        /// </summary>
        /// <param name="PichId">揀貨單號</param>
        /// <returns></returns>
        private bool CLOSE_box_item(string PichId)
        {
            bool IsOk = false;

            Hashtable htCloseBoxItem = new Hashtable(), hashtable2 = new Hashtable();
            htCloseBoxItem.Add("@S_boxid", txB_BoxId.Text);
            htCloseBoxItem.Add("@L_pichid", Lbl_Pich_id.Text);
            htCloseBoxItem.Add("@D_boxh_times", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            htCloseBoxItem.Add("@I_inputtype", 1);
            htCloseBoxItem.Add("@S_empid", UserInf.UserID);
            htCloseBoxItem.Add("@S_computer", UserInf.ComputerName);

            hashtable2.Add("@I_result", 0);
            hashtable2.Add("@S_result", "");

            //log開始
            string Logstring = txB_BoxId.Text.Trim() + "," + Lbl_Pich_id.Text.Trim() + "," + txB_merdId.Text.Trim() + txB_picQty.Text.Trim();
            reclog.ExLog("41", "Sta,關箱," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Logstring);

            IO.SqlSp(Login_Server, "SP_CLOSE_box_item", htCloseBoxItem, ref hashtable2);

            //20140314 Kota 寫入log
            SqlCarOperateLog(txB_BoxId.Text + "," + Lbl_Pich_id.Text, "CB", 0, 0);

            //log結束
            reclog.ExLog("41", "End,關箱," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Logstring);


            int I_result = Convert.ToInt32(hashtable2["@I_result"].ToString());
            string S_result = hashtable2["@S_result"].ToString();
            if (I_result == 0)
                IsOk = true;

            return IsOk;
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
                    }
                }
            }
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
                LockRelease("pich_head", Lbl_Pich_id.Text);
        }
        #endregion


    }
}
