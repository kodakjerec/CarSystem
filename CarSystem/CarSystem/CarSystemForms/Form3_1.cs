using System;
using System.Data;
using System.Windows.Forms;
using Car_Fun;
using System.Collections;
using System.Drawing;
using System.ComponentModel;

namespace CarSystem
{
    public partial class Form3_1 : CarSystem_Sample_Form
    {
        int takeqty1 = 0, takeqty2 = 0;
        private bool bCheckSlot = false;

        #region 背景作業專用
        Hashtable ht_checkSlodId = new Hashtable();
        Hashtable ht_ReciPutCfm = new Hashtable();
        #endregion

        DataSet ds_recsId = new DataSet();
        DataTable dt_recsId = new DataTable();

        string checkSlodIdErrString = "請刷入移入儲位";   //儲位編號的錯誤訊息
        string OldSlodId = "";  //儲位驗證過後，在重新驗證之前，要保存之前輸入的舊儲位編號

        #region Form
        public Form3_1()
        {
            InitializeComponent();
        }

        private void Form3_1_Load(object sender, EventArgs e)
        {
            txL_recs_id1.Click += Click_Show_frmKeyboardEngNumber;
            txS_recs_slodidNew1.Click += Click_Show_frmKeyboardEngNumber;
            txI_merp_unitNO1.Click += Click_Show_frmKeyboardNumber;
            txI_merp_unitNO2.Click += Click_Show_frmKeyboardNumber;

            SetMasterBindingNavigator(null);
            SetButtonEnable("L");

            Content_Reset();
        }

        //離開系統
        protected override void LeaveButton_Click(object sender, EventArgs e)
        {
            if (checkEnterCummitStatus == true)
            {
                bool IsOK = AlarmUserNotFinish(1);
                if (IsOK == false)
                {
                    cummit.Focus();
                    return;
                }
            }
            LockRelease("reci_slot", txb_recsID.Text);
            base.LeaveButton_Click(sender, e);
        }

        /// <summary>
        /// 警告使用者要按下確認，完成一次作業
        /// </summary>
        private bool AlarmUserNotFinish(int type)
        {
            bool ISOK = false;
            if (type == 0)
                fMsg.messageshow("上架作業尚未確認完畢");
            if (type == 1)
                ISOK = fMsg.messageshow("上架作業尚未確認完畢\n\"否\"回到確認動作", "上架作業中斷", true);
            return ISOK;
        }
        #endregion

        #region 輸入板標
        //一次作業的確認沒按下前，禁止重新選擇
        private void txL_recs_id1_Enter(object sender, EventArgs e)
        {
            if (checkEnterCummitStatus == true)
            {
                AlarmUserNotFinish(0);
                return;
            }
        }

        //板標驗證
        private void txL_recs_id1_Validated(object sender, EventArgs e)
        {
            if (txL_recs_id1.Text.Equals(string.Empty))
            {
                txL_recs_id1.Focus();
                return;
            }

            txL_recs_id1.Text = txL_recs_id1.Text.Trim();

            string sCarcCheckid = string.Empty;
            string sRechErpid = string.Empty;
            string sRecimerdid = string.Empty;
            string sStatue = string.Empty;
            string sqlstr = string.Empty;
            txMessage.Text = "";
            string ErrMsg = "";
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            Hashtable hashtable1 = new Hashtable(), hashtable2 = new Hashtable();

            #region 檢查板標是否完全沒人刷過
            //log開始
            reclog.ExLog("31", "Sta,板標驗證," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txL_recs_id1.Text);

            sqlstr = @"select I_recs_put, L_recs_id, I_recs_MRGFlag
            from reci_slot with(nolock) 
            where S_recs_pltno=@txL_recs_id1";
            hashtable1.Add("@txL_recs_id1", txL_recs_id1.Text);
            ds1 = IO.SqlQuery(Login_Server, sqlstr, hashtable1);

            if (ds1.Tables.Count > 0)
            {
                dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    string I_recs_put = dt1.Rows[0]["I_recs_put"].ToString();
                    txb_recsID.Text = dt1.Rows[0]["L_recs_id"].ToString();

                    switch (I_recs_put)
                    {
                        case "0":
                            sStatue = "1";
                            if (!LockRequest("reci_slot", txb_recsID.Text))
                            {
                                ErrMsg = strLockRequestString;
                            }
                            break;
                        case "1":
                            sStatue = "2";
                            if (!LockRequest("reci_slot", txb_recsID.Text))
                            {
                                ErrMsg = strLockRequestString;
                            }
                            break;
                        case "2":
                            ErrMsg = "板標已經完成進貨上架"; break;
                        default:
                            ErrMsg = "查無流程狀態為「儲位指派/上架中」資料，請重新輸入！"; break;
                    }

                    #region 併板標籤顯示
                    int IsmergFlag = Convert.ToInt32(dt1.Rows[0]["I_recs_mrgflag"]);
                    if (IsmergFlag > 0)
                    {
                        ShowHide_mergFlag(true);
                    }
                    #endregion
                }
                else
                {
                    ErrMsg = "查無流程狀態為「儲位指派/上架中」資料，請重新輸入！";
                }
            }
            else
            {
                ErrMsg = "查無流程狀態為「儲位指派/上架中」資料，請重新輸入！";
            }

            //log結束
            reclog.ExLog("31", "End,板標驗證," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txL_recs_id1.Text);

            //Check1:有錯誤不用再帶入明細
            if (ErrMsg != "")
            {
                fMsg.messageshow(ErrMsg);
                Content_Reset();
                txL_recs_id1.Focus();
                return;
            }
            #endregion

            #region 帶入板標資訊
            TakeSlodDetail();
            #endregion

            #region 帶入明細內容
            if (dt_recsId.Rows.Count > 0)
            {
                BringDetail(dt_recsId.Rows[0]);
                BringDetail_mergFlag(1);
            }
            else
                ErrMsg = "查無流程狀態為「儲位指派/上架中」資料，請重新輸入！";
            #endregion

            //Check2:沒有明細內容
            if (ErrMsg != "")
            {
                fMsg.messageshow(ErrMsg);
                Content_Reset();
                txL_recs_id1.Focus();
                return;
            }

            #region 尚未指派移入儲位
            if (sStatue == "1")
            {
                hashtable1.Clear();
                hashtable2.Clear();

                //log開始
                reclog.ExLog("31", "Sta,指派移入儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txL_recs_id1.Text + "," + txS_recs_slodid1.Text);

                if ((dt_recsId.Rows[0]["S_recs_slodid"] == null) || (dt_recsId.Rows[0]["S_recs_slodid"].ToString() == ""))
                {
                    if (lbl_mergFlag.Visible == false)
                    {
                        #region 移入儲位 //SP_RECI_PUT 移入儲位 左邊單元格
                        hashtable1.Add("@L_recs_id", long.Parse(dt_recsId.Rows[0]["L_recs_id"].ToString()));
                        hashtable1.Add("@L_recs_recrid", long.Parse(dt_recsId.Rows[0]["L_recs_recrid"].ToString()));
                        hashtable1.Add("@L_recs_merlsysno", long.Parse(dt_recsId.Rows[0]["L_recs_merlsysno"].ToString()));
                        hashtable1.Add("@I_recs_inputtype", 1);
                        hashtable1.Add("@S_empd_id", UserInf.UserID);
                        hashtable1.Add("@S_Computer", UserInf.ComputerName);
                        hashtable1.Add("SpName", "SP_RECI_PUT");

                        BW_checkPltNo.RunWorkerAsync(hashtable1);
                        Car_Fun.WaitWindow.ShowForm("板標指派儲位");

                        string strReturn = string.Empty;
                        string strMsg = string.Empty;

                        int I_result = Convert.ToInt32(ht_checkSlodId["@I_result"]);
                        string S_result = ht_checkSlodId["@S_result"].ToString();
                        string S_put_slodid = ht_checkSlodId["@S_put_slodid"].ToString();

                        if (I_result == 0)
                        {
                            string RECI = S_put_slodid.ToString();
                            if (RECI != "無")
                            {
                                txS_recs_slodid1.Text = S_put_slodid.ToString();
                            }
                            else
                            {
                                ErrMsg = "指派儲位失敗，請重新刷入板標 " + RECI;
                            }
                        }
                        else
                        {
                            ErrMsg = "指派儲位sp執行失敗，請重新刷入板標 " + S_result;
                        }
                        #endregion
                    }
                }

                //log結束
                reclog.ExLog("31", "End,指派移入儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txL_recs_id1.Text + "," + txS_recs_slodid1.Text);

            }
            #endregion

            #region 鎖定板標
            LockRequest("reci_slot", txb_recsID.Text);
            #endregion

            DisableAllKeyboard();

            //Check3
            if (ErrMsg == "")
            {
                txMessage.Text = "請刷入移入儲位";
            }
            else
            {
                fMsg.messageshow(ErrMsg);
                txL_recs_id1.Text = string.Empty;
                txL_recs_id1.Focus();
                return;
            }
        }

        #region 背景作業:檢查板標
        void BW_checkPltNo_DoWork(object sender, DoWorkEventArgs e)
        {
            Hashtable hashtable1 = (Hashtable)e.Argument;
            string SpName = hashtable1["SpName"].ToString();
            hashtable1.Remove("SpName");
            Hashtable hashtable2 = new Hashtable();
            hashtable2.Add("@S_put_slodid", "");
            hashtable2.Add("@I_result", "");
            hashtable2.Add("@S_result", "");

            IO.SqlSp(Login_Server, SpName, hashtable1, ref hashtable2);
            e.Result = hashtable2;
        }
        void BW_checkPltNo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Car_Fun.WaitWindow.CloseForm("板標指派儲位完畢");
            ht_checkSlodId.Clear();
            ht_checkSlodId = (Hashtable)e.Result;
        }
        #endregion

        /// <summary>
        /// 帶入板標資訊
        /// </summary>
        private void TakeSlodDetail()
        {
            //log開始
            reclog.ExLog("31", "Sta,帶入板標資訊," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txL_recs_id1.Text);

            string sqlstr =
            @"SELECT
	            S_RECS_SLODID,--儲位編號
	            S_MERP_BARCODE,
	            N_MERD_NAME,
	            S_MERD_OWNDID,
	            S_MERD_ID,
	            I_merd_pickcateg,
	            L_RECS_MERDSYSNO,
	            L_recs_merlsysno,
	            S_MERL_SBUID,
	            S_MERL_LOTNO,
	            S_MERL_SUPDID,
	            D_MERL_EXPDATE,
	            S_MERL_MERPGROUP,
	            L_RECS_TAKENUM,
	            L_recs_id,
	            L_recs_recrid,
	            S_recs_pltno,
	            S_merd_abc,
	            e.N_basd_name as CategName
            FROM RECI_SLOT with(nolock)
            JOIN MER_LIST with(nolock) ON L_RECS_MERLSYSNO = L_MERL_SYSNO
            JOIN mer_data with(nolock) ON L_recs_merdsysno = L_merd_sysno
            JOIN mer_package with(nolock) ON L_recs_merdsysno = L_MERP_MERDSYSNO AND S_MERL_MERPGROUP = S_MERP_GROUP AND I_merp_boxflag = 1
            JOIN basic_data e with(nolock) ON I_merd_pickcateg= e.I_basd_seq and e.S_basd_column='merd_pickcateg'
            WHERE  1=1
				and S_recs_pltno = @txL_recs_id1
				and I_recs_put<2";
            Hashtable hst_recsId = new Hashtable();
            hst_recsId.Add("@txL_recs_id1", txL_recs_id1.Text);
            ds_recsId = IO.SqlQuery(Login_Server, sqlstr, hst_recsId);
            dt_recsId = ds_recsId.Tables[0];

            //log開始
            reclog.ExLog("31", "End,帶入板標資訊," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txL_recs_id1.Text);
        }

        #region 帶入明細內容, 箱入數, 組入數, 揀貨儲位
        /// <summary>
        /// 帶入明細內容
        /// </summary>
        /// <param name="dr"></param>
        private void BringDetail(DataRow dr)
        {
            //貨主編號
            txb_OwnerID.Text = dr["S_MERD_OWNDID"].ToString();
            //貨號
            txb_MerdID.Text = dr["S_MERD_ID"].ToString();
            //國際條碼
            txS_merp_barcode1.Text = dr["S_MERP_BARCODE"].ToString();
            //商品系統碼
            txS_merp_barcode1.Tag = dr["L_RECS_MERDSYSNO"].ToString();
            //商品名稱
            txN_merd_name1.Text = dr["N_MERD_NAME"].ToString();
            //組別
            txS_merl_merpgroup1.Text = dr["S_MERL_MERPGROUP"].ToString();
            //批號
            txS_merl_lotno1.Text = dr["S_MERL_LOTNO"].ToString();

            //大類
            txS_PickCag.Text = dr["CategName"].ToString();

            //效期
            DateTime datetmp;
            string dt_Datetime = dr["D_MERL_EXPDATE"].ToString();
            if (dt_Datetime == "")
            {
                dt_Datetime = "2099/12/31";
            }
            datetmp = DateTime.Parse(dt_Datetime);//dt1.Rows[0]["D_MERL_EXPDATE"]
            txD_merl_expdate1.Text = datetmp.ToString("yyyy/MM/dd");

            //板標單號 34XX
            txb_recsID.Text = dr["L_recs_id"].ToString();

            //新儲位代號
            txS_recs_slodidNew1.Text = "";

            //驗收單號 33XX
            txL_recs_recrid.Text = dr["L_recs_recrid"].ToString();

            //mer_list代號
            txL_recs_merlsysno.Text = dr["L_recs_merlsysno"].ToString();

            //系統預帶儲位
            txS_recs_slodid1.Text = dr["S_recs_slodid"].ToString();

            //待上架量
            txL_recs_takenum1.Text = dr["L_RECS_TAKENUM"].ToString();

            //ABC備註
            lbl_ABC.Text = dr["S_merd_ABC"].ToString();
        }
        private void txL_recs_takenum1_TextChanged(object sender, EventArgs e)
        {
            BringPalletBoxPickSlotData();
        }
        /// <summary>
        /// 帶入箱入數, 組入數, 揀貨儲位
        /// </summary>
        private void BringPalletBoxPickSlotData()
        {
            #region 取得箱數,組數,揀貨儲位
            Hashtable hashtable1 = new Hashtable();

            //log開始
            reclog.ExLog("31", "Sta,取得箱數,組數,揀貨儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txb_OwnerID.Text + "," + txb_MerdID.Text + "," + txS_merl_merpgroup1.Text);

            string MER_PACKAGE_SQL =
            @"SELECT 
	            A.S_MERP_UNIT ,
	            A.I_MERP_1QTY  
            FROM MER_PACKAGE A with(nolock)
            INNER JOIN MER_DATA B with(nolock) ON A.S_MERP_OWNDID = B.S_MERD_OWNDID AND A.S_MERP_MERDID = B.S_MERD_ID
            WHERE A.S_MERP_OWNDID = @sMerdOwndid 
            AND A.S_MERP_MERDID= @sMerdId 
            AND A.S_merp_group = @txS_merl_merpgroup1
            ORDER BY A.I_MERP_1QTY DESC";
            hashtable1.Add("@sMerdOwndid", txb_OwnerID.Text);
            hashtable1.Add("@sMerdId", txb_MerdID.Text);
            hashtable1.Add("@txS_merl_merpgroup1", txS_merl_merpgroup1.Text);

            DataSet ds2 = IO.SqlQuery(Login_Server, MER_PACKAGE_SQL, hashtable1);
            if (ds2.Tables.Count > 0)
            {
                DataTable dt2 = ds2.Tables[0];

                if (dt2.Rows.Count > 0)
                {
                    //箱入數
                    if (dt2.Rows[0] != null)
                        takeqty1 = Convert.ToInt32(dt2.Rows[0]["I_MERP_1QTY"].ToString());

                    //組入數
                    if (dt2.Rows.Count >= 2)
                    {
                        if (dt2.Rows[1] != null)
                            takeqty2 = Convert.ToInt32(dt2.Rows[1]["I_MERP_1QTY"].ToString());
                        else
                            takeqty2 = takeqty1;
                    }
                    else
                        takeqty2 = takeqty1;


                    #region 帶入揀貨儲位數量
                    hashtable1.Clear();

                    string slod_pick_SQL =
                    @"select S_slod_id,L_slom_1qty=sum(ISNULL(L_slom_1qty,0))
                    from slot_data a
                    left join slot_mer b on a.S_slod_id=b.S_slom_slodid and a.L_slod_merdsysno=b.L_slom_merdsysno and a.S_slod_pick='P'
                    where a.L_slod_merdsysno=@merdsysno 
                    group by a.S_slod_id";
                    hashtable1.Add("@merdsysno", txS_merp_barcode1.Tag.ToString());
                    DataSet ds3 = IO.SqlQuery(Login_Server, slod_pick_SQL, hashtable1);
                    DataTable dt3 = ds3.Tables[0];
                    hashtable1.Clear();

                    if (dt3.Rows.Count > 0)
                    {
                        txS_slod_pick.Text = dt3.Rows[0]["S_slod_id"].ToString();
                        txS_slom_1qty.Text = dt3.Rows[0]["L_slom_1qty"].ToString();
                    }
                    else
                    {
                        txS_slod_pick.Text = "暫無揀貨儲位";
                        txS_slom_1qty.Text = "0";
                    }
                    #endregion

                    //揀貨總pcs
                    int s = Convert.ToInt32(txL_recs_takenum1.Text);

                    //箱數
                    txI_merp_unitNO1.Text = "0";
                    txI_merp_unitNO1.Text = takeqty1.ToString();
                    lbL_repi_replqty_out_box_value.Text = (s / takeqty1).ToString();
                    s = s % takeqty1;

                    //組數
                    txI_merp_unitNO2.Text = "0";
                    if (takeqty2 != 0)
                        txI_merp_unitNO2.Text = takeqty2.ToString();
                    lbL_repi_replqty_out_pallet_value.Text = (s / takeqty2 < 0 ? 0 : s / takeqty2).ToString();
                }
            }
            //log結束
            reclog.ExLog("31", "End,取得箱數,組數,揀貨儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txb_OwnerID.Text + "," + txb_MerdID.Text + "," + txS_merl_merpgroup1.Text);
            #endregion
        }
        #endregion

        #endregion

        #region 輸入儲位編號
        //檢查輸入的儲位編號合法並更改目的儲位
        private bool checkSloDId(string S_recs_slodid_old, string S_recs_slodid_new, string L_recd_merdsysno)
        {
            bool bCheck = false;

            #region 2014/12/24 若該保位已經有商品庫存，提示
            string cmd_CheckQty =
                        @"SELECT 
                            CntStatus=sum(CntStatus),CntStk=sum(CntStk)
                          FROM(
                            SELECT CntStatus=count(1),CntStk=0
                            FROM slot_data where S_slod_id=@slodid and I_slod_status=1
                            UNION ALL
                            SELECT CntStatus=0,CntStk=count(1)
                            FROM slot_mer where S_slom_slodid=@slodid and L_slom_1qty!=0) a";
            Hashtable ht_CheckQty = new Hashtable();
            ht_CheckQty.Add("@slodid", S_recs_slodid_new);
            DataSet ds_CheckQty = IO.SqlQuery(Login_Server, cmd_CheckQty, ht_CheckQty);
            if (ds_CheckQty.Tables[0].Rows[0]["CntStk"].ToString() != "0")
            {
                bool IsCheckQty = fMsg.messageshow("該儲位已有商品庫存\n是否繼續上架？", "已有庫存確認", true);
                if (IsCheckQty == false)
                {
                    return false;
                }
            }
            #endregion

            //log開始
            reclog.ExLog("31", "Sta,檢查儲位編號," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + S_recs_slodid_old + "," + S_recs_slodid_new);
            Hashtable hashtable1 = new Hashtable();

            if (lbl_mergFlag.Visible == true)
            {
                hashtable1.Add("@S_recs_pltno", txL_recs_id1.Text);
                hashtable1.Add("@S_recs_slodid", S_recs_slodid_new);
                hashtable1.Add("@I_inputtype", 1);
                hashtable1.Add("@S_empdid", UserInf.UserID);
                hashtable1.Add("@S_Computer", UserInf.ComputerName);
                hashtable1.Add("SpName", "SP_RECI_MERGEUPD");

                BW_checkSlodId.RunWorkerAsync(hashtable1);
                Car_Fun.WaitWindow.ShowForm("執行更換儲位");

                int I_result = Convert.ToInt32(ht_checkSlodId["@I_result"]);
                object S_result = ht_checkSlodId["@S_result"];
                ht_checkSlodId.Clear();

                if (I_result == 0)
                {
                    checkSlodIdErrString = "更換儲位成功！";
                    bCheck = true;
                    txS_recs_slodid1.Text = txS_recs_slodidNew1.Text;
                    TakeSlodDetail();
                }
                else
                {
                    checkSlodIdErrString = "更換儲位失敗！\n" + S_result;
                }
            }
            else
            {
                hashtable1.Add("@S_empd_id", UserInf.UserID);
                hashtable1.Add("@S_Computer", UserInf.ComputerName);
                hashtable1.Add("@I_inputtype", 1);
                hashtable1.Add("@S_recs_slodid_new", S_recs_slodid_new);
                hashtable1.Add("@S_recs_slodid_old", S_recs_slodid_old);
                hashtable1.Add("@L_recs_merdsysno", L_recd_merdsysno);
                hashtable1.Add("@L_recs_id", txb_recsID.Text);
                hashtable1.Add("@L_recs_recrid", txL_recs_recrid.Text);
                hashtable1.Add("@L_recs_merlsysno", txL_recs_merlsysno.Text);
                hashtable1.Add("SpName", "SP_reci_checkSlot");

                BW_checkSlodId.RunWorkerAsync(hashtable1);
                Car_Fun.WaitWindow.ShowForm("執行更換儲位");

                int I_result = Convert.ToInt32(ht_checkSlodId["@I_result"]);
                object S_result = ht_checkSlodId["@S_result"];
                ht_checkSlodId.Clear();

                if (I_result == 0)
                {
                    checkSlodIdErrString = "更換儲位成功！";
                    bCheck = true;
                    txS_recs_slodid1.Text = txS_recs_slodidNew1.Text;
                }
                else
                {
                    checkSlodIdErrString = "更換儲位失敗！\n" + S_result;
                }
            }
            //log結束
            reclog.ExLog("31", "End,檢查儲位編號," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + S_recs_slodid_old + "," + S_recs_slodid_new);
            return bCheck;
        }

        #region 背景作業:檢查儲位合法
        void BW_checkSlodId_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Car_Fun.WaitWindow.CloseForm("執行更換儲位完畢");
            ht_checkSlodId.Clear();
            ht_checkSlodId = (Hashtable)e.Result;
        }
        private void BW_checkSlodId_DoWork(object sender, DoWorkEventArgs e)
        {
            Hashtable hashtable1 = (Hashtable)e.Argument;
            string SpName = hashtable1["SpName"].ToString();
            hashtable1.Remove("SpName");
            Hashtable hashtable2 = new Hashtable();
            hashtable2.Add("@I_result", "");
            hashtable2.Add("@S_result", "");

            IO.SqlSp(Login_Server, SpName, hashtable1, ref hashtable2);
            e.Result = hashtable2;
        }
        #endregion

        //有更改到預設儲位的判斷
        private void txS_recs_slodidNew1_TextChanged(object sender, EventArgs e)
        {
            bCheckSlot = false;
        }

        //儲位驗證
        private void txS_recs_slodidNew1_Validated(object sender, EventArgs e)
        {
            if (txS_recs_slodidNew1.Text.Equals(string.Empty))
            {
                txMessage.Text = "儲位不能為空值!";
                bCheckSlot = false;
                txS_recs_slodidNew1.Focus();
                return;
            }

            if (txS_recs_slodidNew1.Text.Length > 7)
            {
                txS_recs_slodidNew1.Text = "";
                checkSlodIdErrString = "儲位長度超過7碼!";
                bCheckSlot = false;
            }
            else
            {
                txS_recs_slodidNew1.Text = txS_recs_slodidNew1.Text.Trim();

                //原本系統建議儲位
                if ((txS_recs_slodid1.Text != "無") && (txS_recs_slodid1.Text != ""))
                {
                    OldSlodId = txS_recs_slodid1.Text;
                }
                //有沒有帶入merd_sysno
                if (txS_merp_barcode1.Tag == null)
                    return;

                //檢查更換儲位合法性
                if (checkSloDId(OldSlodId, txS_recs_slodidNew1.Text, txS_merp_barcode1.Tag.ToString()))
                {
                    bCheckSlot = true;
                }
                else
                {
                    bCheckSlot = false;
                }
            }

            DisableAllKeyboard();

            if (bCheckSlot == true)
            {
                checkEnterCummitStatus = true;
                txMessage.Text = "確認資料無誤後按下\"確認\"";
            }
            else
            {
                txMessage.Text = checkSlodIdErrString;
                txS_recs_slodidNew1.Text = "";
                txS_recs_slodidNew1.Focus();
            }
        }

        #endregion

        #region 按下確認按鈕
        //按下確認
        void cummit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkEnterCummitStatus == true)
                AlarmUserNotFinish(0);
        }

        bool checkEnterCummitStatus = false;
        //按下確認按鈕
        private void cummit_Click(object sender, EventArgs e)
        {
            string strReturn = string.Empty;
            string strS_recs_pltno = "";
            int iTakeNum = 0;

            if ((txS_recs_slodid1.Text == "無") && (txS_recs_slodidNew1.Text == ""))
            {
                fMsg.messageshow("沒有儲位可供上架，請到WMS人員指派儲位上架!");
                txS_recs_slodidNew1.Focus();
                return;
            }

            if (!bCheckSlot)
            {
                fMsg.messageshow("請先確認儲位!");
                txS_recs_slodidNew1.Focus();
                return;
            }

            #region 上架確認查詢資料，確認前再次檢查是否已被其他人確認
            Hashtable hst_CheckLock = new Hashtable();
            //log開始
            reclog.ExLog("31", "Sta,上架確認查詢," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txL_recs_id1.Text);

            string sqlstr =
                @"SELECT top 1 0
                      FROM RECI_SLOT
                      WHERE  S_recs_pltno = @txL_recs_id1
                      AND I_RECS_PUT < 2";

            hst_CheckLock.Add("@txL_recs_id1", txL_recs_id1.Text);
            DataSet ds1 = IO.SqlQuery(Login_Server, sqlstr, hst_CheckLock);
            if (ds1.Tables[0].Rows.Count <= 0)
            {
                fMsg.messageshow("板標已被他人上架中！");
                return;
            }
            //log結束
            reclog.ExLog("31", "End,上架確認查詢," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txL_recs_id1.Text);

            #endregion

            #region 上架確認sp
            Hashtable hashtable1 = new Hashtable();

            DataTable dt1 = ds1.Tables[0];

            if (dt1.Rows.Count > 0)
            {
                //log開始
                string strMessageSP_RECI_PUTCFM = "";
                strMessageSP_RECI_PUTCFM = txb_recsID.Text
                    + "," + txL_recs_recrid.Text
                    + "," + txL_recs_merlsysno.Text;
                reclog.ExLog("31", "Sta,上架確認sp," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + strMessageSP_RECI_PUTCFM);
                bool bCheckSp = false;

                if (lbl_mergFlag.Visible == true)
                {
                    //----20140303
                    hashtable1.Add("@S_recs_pltno", txL_recs_id1.Text);
                    hashtable1.Add("@S_recs_slodid", txS_recs_slodid1.Text);
                    hashtable1.Add("@I_inputtype", 1);
                    hashtable1.Add("@S_empdid", UserInf.UserID);
                    hashtable1.Add("@S_computer", UserInf.ComputerName);
                    hashtable1.Add("SpName", "SP_RECI_MERGEPUTCFM");

                    BW_ReciPutCfm.RunWorkerAsync(hashtable1);
                    Car_Fun.WaitWindow.ShowForm("執行上架確認");
                }
                else
                {
                    //----20140303
                    hashtable1.Add("@L_recs_id", txb_recsID.Text);
                    hashtable1.Add("@L_recs_recrid", txL_recs_recrid.Text);
                    hashtable1.Add("@L_recs_merlsysno", txL_recs_merlsysno.Text);
                    hashtable1.Add("@I_recs_inputtype", 1);
                    hashtable1.Add("@I_recs_putqty", txL_recs_takenum1.Text);
                    hashtable1.Add("@S_empd_id", UserInf.UserID);
                    hashtable1.Add("@S_Computer", UserInf.ComputerName);
                    hashtable1.Add("@S_pltcfm", "N");
                    hashtable1.Add("SpName", "SP_RECI_PUTCFM");

                    BW_ReciPutCfm.RunWorkerAsync(hashtable1);
                    Car_Fun.WaitWindow.ShowForm("執行上架確認");
                }
                int I_result = Convert.ToInt32(ht_ReciPutCfm["@I_result"]);
                string S_result = ht_ReciPutCfm["@S_result"].ToString();

                //log結束
                reclog.ExLog("31", "End,上架確認sp," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + strMessageSP_RECI_PUTCFM);

                if (I_result == 0)
                {
                    #region 解除鎖定
                    LockRelease("reci_slot", txb_recsID.Text);
                    #endregion

                    SqlCarOperateLog(txL_recs_id1.Text, "C", 0, Convert.ToInt32(txL_recs_takenum1.Text));

                    bCheckSp = true;
                    checkEnterCummitStatus = false;
                    txMessage.Text = "上架成功！";
                    txL_recs_id1.Focus();
                    iTakeNum = Convert.ToInt32(txL_recs_takenum1.Text);
                    strS_recs_pltno = txL_recs_id1.Text;
                }
                else
                {
                    txMessage.Text = "上架失敗！" + S_result.ToString();
                }

                if (!bCheckSp)
                {
                    return;
                }
            }
            else
            {
                fMsg.messageshow("查無流程狀態為「儲位指派/上架中」資料，請重新輸入！");
                return;
            }
            #endregion

            Content_Reset();

            DisableAllKeyboard();
            this.txL_recs_id1.Focus();
        }

        #region 背景作業:檢查儲位合法
        void BW_ReciPutCfm_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Car_Fun.WaitWindow.CloseForm("執行上架確認完畢");
            ht_ReciPutCfm.Clear();
            ht_ReciPutCfm = (Hashtable)e.Result;
        }
        private void BW_ReciPutCfm_DoWork(object sender, DoWorkEventArgs e)
        {
            Hashtable hashtable1 = (Hashtable)e.Argument;
            string SpName = hashtable1["SpName"].ToString();
            hashtable1.Remove("SpName");
            Hashtable hashtable2 = new Hashtable();
            hashtable2.Add("@I_result", "");
            hashtable2.Add("@S_result", "");
            if (SpName == "SP_RECI_PUTCFM")
                hashtable2.Add("@S_put_slodid", "");

            IO.SqlSp(Login_Server, SpName, hashtable1, ref hashtable2);
            e.Result = hashtable2;
        }
        #endregion

        /// <summary>
        /// 清除頁面資訊
        /// </summary>
        void Content_Reset()
        {
            txL_recs_id1.Text = "";
            txS_merp_barcode1.Text = "";
            txN_merd_name1.Text = "";
            txS_merl_merpgroup1.Text = "";
            txS_merl_lotno1.Text = "";
            txD_merl_expdate1.Text = "";
            txS_recs_slodid1.Text = "";
            txS_recs_slodidNew1.Text = "";
            txL_recs_takenum1.Text = "";
            txL_recs_recrid.Text = "";
            txL_recs_merlsysno.Text = "";
            txI_merp_unitNO1.Text = "";
            txI_merp_unitNO2.Text = "";
            lbl_ABC.Text = "";
            lbL_repi_replqty_out_box_value.Text = "0";
            lbL_repi_replqty_out_pallet_value.Text = "0";
            ShowHide_mergFlag(false);
        }
        #endregion

        #region 詳細資訊顯示
        //顯示/隱藏  詳細資訊
        private void Show_Click(object sender, EventArgs e)
        {
            if (Details.Visible == true)
            {
                btn_ShowDetail.Text = "顯示詳細資訊";
                Details.Visible = false;
            }
            else
            {
                Details.Location = new System.Drawing.Point(53, 347);
                btn_ShowDetail.Text = "隱藏詳細資訊";
                Details.Visible = true;
                Details.BringToFront();
            }
        }

        //覆寫panel的外框
        private void Details_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.Red, 3);
            e.Graphics.DrawRectangle(pen1,
              e.ClipRectangle.Left,
              e.ClipRectangle.Top,
              e.ClipRectangle.Width - 1,
              e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        #region 更改數量顏色
        //更改數量顏色
        private void Merdid_Itemvalue_Change(Label sender)
        {
            int intLblText = 0;
            try
            {
                intLblText = Convert.ToInt32(sender.Text);
            }
            catch
            {
                intLblText = 0;
            }

            //數量不等於0
            if (intLblText != 0)
            {
                sender.ForeColor = Color_tbFocus_ForeColor;
                sender.BackColor = Color_tbFocus_BackColor;
            }
            else
            {
                sender.ForeColor = Color_ForeColor;
                sender.BackColor = Color_BackColor;
            }
            lbL_repi_replqty_out_box.ForeColor = lbL_repi_replqty_out_box_value.ForeColor;
            lbL_repi_replqty_out_box.BackColor = lbL_repi_replqty_out_box_value.BackColor;
            lbL_repi_replqty_out_pallet.ForeColor = lbL_repi_replqty_out_pallet_value.ForeColor;
            lbL_repi_replqty_out_pallet.BackColor = lbL_repi_replqty_out_pallet_value.BackColor;
        }
        //lbl_ABC更改文字
        private void lbl_ABC_TextChanged(object sender, EventArgs e)
        {
            if (lbl_ABC.Text != "")
                lbl_ABC.Visible = true;
            else
                lbl_ABC.Visible = false;
        }
        //數量文字更改
        private void lbL_repi_replqty_out_box_value_TextChanged(object sender, EventArgs e)
        {
            Merdid_Itemvalue_Change((Label)sender);
        }
        #endregion
        #endregion

        #region 併板標籤
        /// <summary>
        /// 顯示/隱藏 併板標籤和按鈕
        /// </summary>
        /// <param name="IsShow"></param>
        private void ShowHide_mergFlag(bool IsShow)
        {
            lbl_mergFlag.Visible = IsShow;
            btn_mergflagList.Visible = IsShow;
        }
        /// <summary>
        /// 標籤顯示筆數
        /// </summary>
        /// <param name="i"></param>
        private void BringDetail_mergFlag(int i)
        {
            btn_mergflagList.Text = i.ToString() + "/" + dt_recsId.Rows.Count.ToString();
        }

        /// <summary>
        /// 併板標籤切換商品內容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mergflagList_Click(object sender, EventArgs e)
        {
            int NowCount = Convert.ToInt32(btn_mergflagList.Text.Substring(0, btn_mergflagList.Text.IndexOf('/')));
            //下一筆
            if (NowCount < dt_recsId.Rows.Count)
                NowCount++;
            else
                NowCount = 1;

            NowCount -= 1;
            BringDetail(dt_recsId.Rows[NowCount]);

            NowCount++;  //回覆以1開始計數

            //切換顯示文字
            BringDetail_mergFlag(NowCount);
        }
        #endregion
    }
}
