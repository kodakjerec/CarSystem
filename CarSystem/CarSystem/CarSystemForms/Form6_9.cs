using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Car_Fun;
using Car_IO;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using RecLog;

namespace CarSystem
{
    public partial class Form6_9 : CarSystem_Sample_Form
    {
        int BaseMapWidth = 800, BaseMapHeight = 600;
        Bitmap bmp, DC1mapBig;
        Rectangle rg;
        FileStream fs2;
        DataTable dt_KIimage1;
        int FunSize = 1, Fun1XPOS = 0, Fun1YPOS = 0, FunSizeBig = 10;
        ErrLog Er = new ErrLog();

        public Form6_9()
        {
            InitializeComponent();
        }

        protected override void New_WSC_DLL_Form_Load(object sender, EventArgs e)
        {
            base.New_WSC_DLL_Form_Load(sender, e);

            //讀入圖片資訊
            bmp = new Bitmap(BaseMapWidth, BaseMapHeight);
            rg = new Rectangle(0, 0, 800, 600);
            if (Login_Server == "pxwms_n")
            {
                fs2 = File.OpenRead(Application.StartupPath + @"\Resources\DC1map001.jpg");
            }
            else if (Login_Server == "pxwms_me")
            {
                fs2 = File.OpenRead(Application.StartupPath + @"\Resources\DC1map001.jpg");
            }
            else
                fs2 = File.OpenRead(Application.StartupPath + @"\Resources\DC2map001.jpg");


            DC1mapBig = (Bitmap)Image.FromStream(fs2, true, false);

            //設定起始圖片大小
            KIimage1SetPixel();

            //BaseForm設定
            SetMasterBindingNavigator(null);
            SetButtonEnable("N E L P SE ");
            bindingNavigatorEditButton.Text = "建單";
            bindingNavigatorNewButton.Text = "調儲";

            //重新整理按鈕
            bindingNavigatorRefreshButton.Click += new EventHandler(Map_Refresh_Click);
            txL_repi_replqty_out.Click += Click_Show_frmKeyboardNumber;
            txS_repi_outslodid_out2.Click += Click_Show_frmKeyboardEngNumber;
            txS_repi_inslodid_in2.Click += Click_Show_frmKeyboardEngNumber;
            txS_merd_id_out2.Click += Click_Show_frmKeyboardNumber;
            txb_FilterMerDid.Click += Click_Show_frmKeyboardNumber;


            //新刪修時按鈕狀態統一化
            List<object> buttonlist = new List<object>();
            buttonlist.Add(txL_repi_replqty_out);
            buttonlist.Add(txS_repi_outslodid_out2);
            buttonlist.Add(txS_repi_inslodid_in2);
            this.MasterObj = buttonlist;
            SetButtonEnable(buttonlist, true);
        }

        #region Form_View

        #region 畫面放大縮小等視覺功能

        /// <summary>
        /// 重繪1:1 Map
        /// </summary>
        private void KIimage1SetPixel()
        {
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,繪製地圖," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));

            DC1mapBig.Dispose();
            DC1mapBig = (Bitmap)Image.FromStream(fs2, true, false);

            Graphics gBig = Graphics.FromImage(DC1mapBig);

            int X_POS = 0, Y_POS = 0, X_Width = 0, Y_Width = 0, Tqty = 0, MinFlag = 0, PickFlag = 0;
            string slodid = "";
            Font DrawFont = new Font(this.Font.Name, this.Font.Size + 6);
            Brush DrawBrushBack = new SolidBrush(Color.White),
                  DrawBrushFront = new SolidBrush(Color.Yellow),
                  DrawBrushFront2 = new SolidBrush(Color.Black);
            Color PixelColor = Color.Red;
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add("@slodid", "");
            hashtable1.Add("@itemno", txb_FilterMerDid.Text);
            hashtable1.Add("@Type", 2);
            hashtable1.Add("@Level", 1);
            Hashtable hashtable2 = new Hashtable();

            DataSet ds1 = IO.SqlSp(Login_Server, "spCarSystem_GetStockQty", hashtable1, ref hashtable2);
            dt_KIimage1 = ds1.Tables[0];

            foreach (DataRow dr in dt_KIimage1.Rows)
            {
                X_POS = Convert.ToInt32(dr["X_POS"]);
                Y_POS = Convert.ToInt32(dr["Y_POS"]);
                X_Width = Convert.ToInt32(dr["X_Width"]);
                Y_Width = Convert.ToInt32(dr["Y_Width"]);
                //設定儲位顏色
                Tqty = Convert.ToInt32(dr["Tqty"]);
                MinFlag = Convert.ToInt32(dr["MinFlag"]);
                PickFlag = Convert.ToInt32(dr["PickFlag"]);
                if (PickFlag > 0)
                {
                    //有設定揀貨儲位
                    if (MinFlag > 0)
                        PixelColor = Color_Dangerous;
                    else if (MinFlag == 0 && Tqty > 0)
                        PixelColor = Color_Normal;
                }
                else
                {
                    //無設定揀貨儲位
                    if (Tqty > 0)
                        PixelColor = Color.White;
                    else
                        continue;
                }

                //描繪像素點
                gBig.FillRectangle(new SolidBrush(PixelColor), X_POS, Y_POS, X_Width, Y_Width);
                //描繪框框
                gBig.FillRectangle(new SolidBrush(Color.Black), X_POS, Y_POS, X_Width, 1);
                gBig.FillRectangle(new SolidBrush(Color.Black), X_POS, Y_POS + Y_Width, X_Width, 1);
                gBig.FillRectangle(new SolidBrush(Color.Black), X_POS, Y_POS, 1, Y_Width);
                gBig.FillRectangle(new SolidBrush(Color.Black), X_POS + X_Width, Y_POS, 1, Y_Width);

                //畫出儲位名稱
                slodid = dr["S_slom_slodid"].ToString();

                gBig.DrawString(slodid, DrawFont, DrawBrushBack, new Point(X_POS + X_Width / 10, Y_POS + Y_Width / 2));
                if (PixelColor == Color.White)
                    gBig.DrawString(slodid, DrawFont, DrawBrushFront2, new Point(X_POS + X_Width / 10 - 1, Y_POS + Y_Width / 2 - 1));
                else
                    gBig.DrawString(slodid, DrawFont, DrawBrushFront, new Point(X_POS + X_Width / 10 - 1, Y_POS + Y_Width / 2 - 1));
            }
            gBig.Dispose();
            pictureBox1.Image = DC1mapBig;
            pictureBox1.Width = BaseMapWidth;
            pictureBox1.Height = BaseMapHeight;

            //log結束
            Er.ExLog(new Exception(), "61", "End,繪製地圖," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));

        }

        #region 地圖說明視窗
        //原始坐標軸
        Point tbc_MainPage_Settings_Location = new Point(0, 0);

        /// <summary>
        /// 地圖說明視窗可移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbc_MainPage_Settings_MouseUp(object sender, MouseEventArgs e)
        {
            Pan_MainPage_Settings.Location = new Point(MousePosition.X - tbc_MainPage_Settings_Location.X, MousePosition.Y - tbc_MainPage_Settings_Location.Y);
        }

        /// <summary>
        /// 地圖說明視窗消失
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbc_MainPage_Settings_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pan_MainPage_Settings.Visible = false;
        }

        /// <summary>
        /// 按下地圖視窗位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbc_MainPage_Settings_MouseDown(object sender, MouseEventArgs e)
        {
            //計算按下地圖說明視窗的鼠標位置
            tbc_MainPage_Settings_Location = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 地圖說明視窗顯示隱藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void SettingsButton_Click(object sender, EventArgs e)
        {
            base.SettingsButton_Click(sender, e);
            if (Pan_MainPage_Settings.Visible == true)
                Pan_MainPage_Settings.Visible = false;
            else
                Pan_MainPage_Settings.Visible = true;
        }

        #endregion

        #region 重新整理Map
        private void Map_Refresh_Click(object sender, EventArgs e)
        {
            MapPage_Reset();
            backgroundWorker1.RunWorkerAsync();
            Car_Fun.WaitWindow.ShowForm("Start Loading");
            Tick_Refresh = 10;
            Tick_CDtime = 1800;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            KIimage1SetPixel();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Car_Fun.WaitWindow.CloseForm("Loading Complete");
        }
        #endregion

        #region 定時自動重新整理地圖
        int Tick_Refresh = 0, Tick_CDtime = 1800;
        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            if (Tick_Refresh > 0)
            {
                bindingNavigatorRefreshButton.Text = "更新 " + Tick_Refresh.ToString();
                bindingNavigatorRefreshButton.Enabled = false;
                Tick_Refresh--;
            }
            else if (Tick_Refresh == 0)
            {
                bindingNavigatorRefreshButton.Text = "更新 ";
                bindingNavigatorRefreshButton.Enabled = true;
            }

            Tick_CDtime--;

            if (Tick_CDtime == 0)
            {
                bindingNavigatorRefreshButton.PerformClick();
                Tick_CDtime = 1800;
            }
        }
        #endregion


        /// <summary>
        /// Map放大縮小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int picWidth = pictureBox1.Width, picHeight = pictureBox1.Height;
            //按左鍵放大，右鍵縮小
            //放大後再按左鍵跳出功能選單
            if (e.Button == MouseButtons.Left)
            {
                if (FunSize == 1)
                {
                    int WidthRange = BaseMapWidth / 10, HeightRange = BaseMapHeight / 10;
                    bindingNavigatorRefreshButton.Visible = false;

                    #region 檢視坐標軸是否超出界線
                    //左邊界
                    Fun1XPOS = (e.X - WidthRange / 2 < 0) ? 0 : e.X - WidthRange / 2;
                    //上邊界
                    Fun1YPOS = (e.Y - HeightRange / 2 < 0) ? 0 : e.Y - HeightRange / 2;
                    //右邊界
                    Fun1XPOS = (e.X + WidthRange > picWidth) ? picWidth - WidthRange : Fun1XPOS;
                    //下邊界
                    Fun1YPOS = (e.Y + HeightRange > picHeight) ? picHeight - HeightRange : Fun1YPOS;
                    #endregion

                    //Picture 放大10倍
                    FunSize = FunSizeBig;
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawImage(DC1mapBig, rg, new Rectangle(Fun1XPOS * FunSize, Fun1YPOS * FunSize, WidthRange * FunSize, HeightRange * FunSize), GraphicsUnit.Pixel);
                    g.Dispose();
                    pictureBox1.Image = bmp;
                }
                else
                {
                    int X_POS = 0, Y_POS = 0, X_Width = 0, Y_Width = 0;
                    int Click_Fun1XPOS = e.X + Fun1XPOS * FunSize, Click_Fun1YPOS = e.Y + Fun1YPOS * FunSize;
                    //放大後代出列表
                    foreach (DataRow dr in dt_KIimage1.Rows)
                    {
                        X_POS = Convert.ToInt32(dr["X_POS"]);
                        Y_POS = Convert.ToInt32(dr["Y_POS"]);
                        X_Width = Convert.ToInt32(dr["X_Width"]);
                        Y_Width = Convert.ToInt32(dr["Y_Width"]);
                        if (Click_Fun1XPOS >= X_POS && Click_Fun1XPOS <= X_POS + X_Width
                            && Click_Fun1YPOS >= Y_POS && Click_Fun1YPOS <= Y_POS + Y_Width)
                        {
                            Select_InStockID(dr["S_slom_slodid"].ToString() + "%");
                        }
                    }

                }
            }
            else
            {
                bindingNavigatorPreviousButton.PerformClick();
            }
        }

        /// <summary>
        /// TextBox顏色設定_test
        /// </summary>
        /// <param name="listbutton"></param>
        /// <param name="IsEnable"></param>
        protected void SetButtonEnable(List<object> listbutton, bool IsEnable)
        {
            bindingNavigatorRefreshButton.Visible = false;
            if (FunSize == 1 && tbc_MainFunction.SelectedIndex == 0)
            {
                bindingNavigatorRefreshButton.Visible = true;
            }
        }
        #endregion

        #endregion

        #region Form_Control

        #region Map & CrePage 指定儲位編號 指定移入貨號
        Color Color_StopOutStockSelect = Color.Gray,    //無法補貨
              Color_Dangerous = Color.Red,              //<=小S
              Color_Normal = Color.Green;               //between 小S and 大S
        int InStock_NeedQty = 0;    //補到大S的需求量
        int CrePage_OriginQty = 0;  //儲位庫存量

        #region Map 指定移入儲位
        //Map 指定移入儲位
        private void Select_InStockID(string Slodid)
        {
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,指定移入儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Slodid);

            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add("@slodid", Slodid);
            hashtable1.Add("@itemno", "");
            hashtable1.Add("@Type", 0);
            hashtable1.Add("@Level", 1);
            Hashtable hashtableOut = new Hashtable();

            DataSet DsInStock = IO.SqlSp(Login_Server, "spCarSystem_GetStockQty", hashtable1, ref hashtableOut);

            #region 自動調整蘭寬

            dataGridView_InStock.DataSource = DsInStock.Tables[0];
            dataGridView_InStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //HScrollBar設定
            hSB_dataGridView_InStock.Maximum = dataGridView_InStock.Columns.Count;
            hSB_dataGridView_InStock.Scroll += new ScrollEventHandler(hSB_dataGridView_InStock_Scroll);
            hSB_dataGridView_InStock.Value = 0;

            #endregion

            #region 調整列高
            foreach (DataGridViewRow dgvr in dataGridView_InStock.Rows)
            {
                if (dgvr.Cells["S_slod_pick"].Value.ToString() == "P")
                {
                    //揀貨儲位
                    //沒有移出儲位的資料須著色並禁止按下
                    if (Convert.ToInt32(dgvr.Cells["OutQty"].Value) == 0)
                    {
                        dgvr.DefaultCellStyle.BackColor = Color_StopOutStockSelect;
                    }
                    else if (Convert.ToInt32(dgvr.Cells["L_slod_minqty"].Value) != 0 && Convert.ToInt32(dgvr.Cells["L_slom_1qty"].Value) > Convert.ToInt32(dgvr.Cells["L_slod_minqty"].Value))
                    {
                        dgvr.DefaultCellStyle.BackColor = Color_Normal;
                    }
                    else if (Convert.ToInt32(dgvr.Cells["L_slom_1qty"].Value) <= Convert.ToInt32(dgvr.Cells["L_slod_minqty"].Value))
                    {
                        dgvr.DefaultCellStyle.BackColor = Color_Dangerous;
                    }
                }
                else
                {
                    //保管儲位
                }
            }
            #endregion

            //c#預設自動選取第一行,會讓底色改變,此處自動改為不選取
            if (DsInStock.Tables[0].Rows.Count > 0)
                dataGridView_InStock.Rows[0].Selected = false;

            tbc_MainFunction.SelectedIndex += 1;

            //log結束
            Er.ExLog(new Exception(), "61", "End,指定移入儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Slodid);

        }

        /// <summary>
        /// InStock Scrollbar設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void hSB_dataGridView_InStock_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView_InStock.FirstDisplayedScrollingColumnIndex = hSB_dataGridView_InStock.Value;
        }
        #endregion

        //Map 選定移入儲位和貨號
        private void dataGridView_InStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //沒選到返回
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView_InStock.Rows[e.RowIndex];
            //底色是紅色表示沒有移出儲位的量
            if (row.DefaultCellStyle.BackColor == Color_StopOutStockSelect)
                return;

            txS_merd_id_out.Text = row.Cells["S_slom_merdid"].Value.ToString();
            txN_merd_name_out.Text = row.Cells["N_merd_name"].Value.ToString();
            txS_repi_inslodid_in.Text = row.Cells["S_slom_slodid"].Value.ToString();
            if (row.Cells["D_merl_expdate_in"].Value.ToString() == "")
                txD_merl_expdate_in.Text = "";
            else
                txD_merl_expdate_in.Text = ((DateTime)row.Cells["D_merl_expdate_in"].Value).ToString("yyyy-MM-dd");

            //帶出目前庫存量
            Lbl_Crepage_NowQty.Text = row.Cells["L_slom_1qty"].Value.ToString();

            //帶出需求量
            InStock_NeedQty = Convert.ToInt32(row.Cells["Needqty"].Value);

            //帶出移出儲位
            bool HavingOtherStockQty = Select_CrePageMerdid(row.Cells["S_slom_merdid"].Value.ToString(),
                                  row.Cells["S_slom_slodid"].Value.ToString());

            if (!HavingOtherStockQty)
            {
                F_Msg.messageshow("無其他保管儲位庫存");
                return;
            }

            #region 檢查是否已經有補貨單
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,檢查是否已經有補貨單," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + row.Cells["S_slom_slodid"].Value.ToString() + "," + row.Cells["S_slom_merdid"].Value.ToString());

            string CheckInStockDocument =
                @"select 0 from repl_head a 
                inner JOIN repl_item b on a.L_reph_id=b.L_repi_rephid 
                inner join mer_data c on b.L_repi_merdsysno=c.L_merd_sysno
                where I_repi_rfflag<=1 
                    and a.T_reph_creatdate>=getdate()-3 
                    and b.S_repi_inslodid=@inslodid and c.S_merd_id=@merdid
                    and a.I_reph_flag in (135,140) ";

            Hashtable hash_CheckInStockDocument = new Hashtable();
            hash_CheckInStockDocument.Add("@inslodid", txS_repi_inslodid_in.Text);
            hash_CheckInStockDocument.Add("@merdid", txS_merd_id_out.Text);
            DataSet ds_CheckInStockDocument = IO.SqlQuery(Login_Server, CheckInStockDocument, hash_CheckInStockDocument);
            if (ds_CheckInStockDocument.Tables[0].Rows.Count > 0)
            {
                lbL_61CreatPage_AlreadyStock.Visible = true;
            }
            else
            {
                lbL_61CreatPage_AlreadyStock.Visible = false;
            }
            //log結束
            Er.ExLog(new Exception(), "61", "Sta,檢查是否已經有補貨單," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + row.Cells["S_slom_slodid"].Value.ToString() + "," + row.Cells["S_slom_merdid"].Value.ToString());

            #endregion

            tbc_MainFunction.SelectedIndex += 1;
        }

        //Map 指定移入儲位後帶出移出儲位
        private bool Select_CrePageMerdid(string Merdid, string Slodid)
        {
            bool IsOk = false;
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,指定移入儲位後帶出移出儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Merdid + "," + Slodid);

            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add("@slodid", Slodid);
            hashtable1.Add("@itemno", Merdid);
            hashtable1.Add("@Type", 1);
            hashtable1.Add("@Level", 1);
            Hashtable hashtableOut = new Hashtable();
            DataSet DsInStock = IO.SqlSp(Login_Server, "spCarSystem_GetStockQty", hashtable1, ref hashtableOut);
            dataGridView_CrePage.DataSource = DsInStock.Tables[0];

            if (DsInStock.Tables[0].Rows.Count > 0)
            {
                //自動選擇第一筆儲位
                DataGridViewRow row = dataGridView_CrePage.Rows[0];
                Map_CrePage_Select(row);
                IsOk = true;
            }

            //log結束
            Er.ExLog(new Exception(), "61", "End,指定移入儲位後帶出移出儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + Merdid + "," + Slodid);

            return IsOk;
        }

        //CrePage選定移出儲位
        private void dataGridView_CrePage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView_CrePage.Rows[e.RowIndex];
            Map_CrePage_Select(row);
        }

        //選定移出儲位後更改表單資料
        void Map_CrePage_Select(DataGridViewRow row)
        {
            //移出儲位代號
            txS_repi_outslodid_out.Text = row.Cells["S_slom_slodid2"].Value.ToString();

            //移出儲位的最大庫存量
            CrePage_OriginQty = Convert.ToInt32(row.Cells["L_slom_1qty2"].Value);

            //可移出量 v.s. 需求量，取最小值(pcs)
            int PcsQty = Math.Min(Convert.ToInt32(row.Cells["L_slom_1qty2"].Value), InStock_NeedQty);
            int BoxQty = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(PcsQty) / Convert.ToDouble(row.Cells["I_merp_1qty"].Value)));
            txL_repi_replqty_out.Text = BoxQty.ToString();
            txL_repi_replqty_in.Text = txL_repi_replqty_out.Text;

            if (row.Cells["D_merl_expdate_Out"].Value.ToString() == "")
                txD_merl_expdate_Out.Text = "";
            else
                txD_merl_expdate_Out.Text = ((DateTime)row.Cells["D_merl_expdate_Out"].Value).ToString("yyyy-MM-dd");
        }

        #region 移出儲位更改數量
        /// <summary>
        /// 移出儲位更改數量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txL_repi_replqty_out_TextChanged(object sender, EventArgs e)
        {
            Calculate_replqty(txS_merd_id_out.Text, txL_repi_replqty_out.Text);
        }

        DataTable dt_Cal_replqty;
        private void Calculate_replqty(string S_merd_id, string BoxQty)
        {
            if (S_merd_id == "" || BoxQty == "")
            {
                lbL_repi_replqty_out_box_value.Text = "00";
                lbL_repi_replqty_out_pallet_value.Text = "00";
                return;
            }

            #region Step1:檢查是否需要重抓商品資料
            Boolean Flag_ReQuery = false;
            if (dt_Cal_replqty == null)
            {
                Flag_ReQuery = true;
            }
            else if (dt_Cal_replqty.Rows.Count <= 0)
            {
                Flag_ReQuery = true;
            }
            else if (dt_Cal_replqty.Rows[0][0].ToString() != S_merd_id)
            {
                Flag_ReQuery = true;
            }
            if (Flag_ReQuery)
            {
                //log開始
                Er.ExLog(new Exception(), "61", "Sta,重抓商品資料," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + S_merd_id);

                string Query_string = "SELECT S_merp_merdid, Boxqty=I_merp_1qty,Palletqty=convert(int,I_merp_pacti*I_merp_pachi*1.0*I_merp_1qty) from mer_package where S_merp_merdid=@S_merd_id AND I_merp_boxflag=1";
                Hashtable ht_requery = new Hashtable();
                ht_requery.Add("@S_merd_id", S_merd_id);
                DataSet ds = IO.SqlQuery(Login_Server, Query_string, ht_requery);
                dt_Cal_replqty = ds.Tables[0];
                if (dt_Cal_replqty.Rows.Count > 0)
                {
                    int BoxBaseQty = Convert.ToInt32(dt_Cal_replqty.Rows[0][1]);
                    int PallBaseQty = Convert.ToInt32(dt_Cal_replqty.Rows[0][2]);
                    lbL_repi_replqty_out_box_Base.Text = BoxBaseQty.ToString();
                    lbL_repi_replqty_out_pallet_Base.Text = (PallBaseQty / BoxBaseQty).ToString();
                }

                //log結束
                Er.ExLog(new Exception(), "61", "End,重抓商品資料," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + S_merd_id);
            }
            #endregion

            #region Step2:計算板箱個
            if (dt_Cal_replqty.Rows.Count > 0)
            {
                int I_Boxqty = Convert.ToInt32(BoxQty), I_Boxsize = Convert.ToInt32(dt_Cal_replqty.Rows[0][1]);
                int I_Pcsqty = I_Boxqty * I_Boxsize;
                int I_Palqty = 0, I_Palsize = Convert.ToInt32(dt_Cal_replqty.Rows[0][2]);

                //紀錄目前調的PCS
                lbL_repi_replqty_out_Pcs_value.Text = I_Pcsqty.ToString();

                I_Palqty = I_Pcsqty / I_Palsize;
                I_Pcsqty = I_Pcsqty % I_Palsize;
                I_Boxqty = I_Pcsqty / I_Boxsize;
                I_Pcsqty = I_Pcsqty % I_Boxsize;
                lbL_repi_replqty_out_box_value.Text = I_Boxqty.ToString("00");
                lbL_repi_replqty_out_pallet_value.Text = I_Palqty.ToString("00");
            }
            #endregion

            Merdid_Itemvalue_Change(lbL_repi_replqty_out_box_value);
            Merdid_Itemvalue_Change(lbL_repi_replqty_out_pallet_value);
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
        #endregion

        #endregion

        #region 單據相關操作

        #region CrePage 建立單據
        private void button_CrePage_Click(object sender, EventArgs e)
        {
            //建單時注意移出量不可超出移出儲位的庫存量
            if (txL_repi_replqty_out.Text == "")
                return;

            int CrePage_AdjQty = Convert.ToInt32(lbL_repi_replqty_out_Pcs_value.Text);
            if (CrePage_AdjQty > CrePage_OriginQty)
            {
                lb_CrePage_SuccessMessage.Text = "移出數量大於移出儲位庫存量";
                txL_repi_replqty_out.Focus();
                return;
            }
            else if (CrePage_AdjQty <= 0)
            {
                lb_CrePage_SuccessMessage.Text = "移出數量必定大於零";
                txL_repi_replqty_out.Focus();
                return;
            }

            //已經建完單回到庫存頁面繼續操作,Reset數據
            if (button_CrePage.Text == "完成" || ((DataTable)dataGridView_CrePage.DataSource).Rows.Count == 0)
            {
                CrePage_AdjQty = 0;
                bindingNavigatorEditButton.PerformClick();
                return;
            }

            //log開始
            Er.ExLog(new Exception(), "61", "Sta,建立單據," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));

            string cmdstring = "SELECT * from metr_head where 1=0 ";
            Hashtable hashtable1 = new Hashtable();
            DataSet Metr_Head = IO.SqlQuery(Login_Server, cmdstring, hashtable1);

            cmdstring = "SELECT * from metr_item where 1=0 ";
            DataSet Metr_Item = IO.SqlQuery(Login_Server, cmdstring, hashtable1);
            Metr_Item.Tables[0].Columns.Remove("L_meti_sysno");

            //log結束
            Er.ExLog(new Exception(), "61", "End,建立單據," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));

            #region 取得指定單號
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,取得指定單號," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));

            cmdstring = "sp_Head_idno";
            hashtable1.Add("@categ", "61");
            Hashtable iddnoOutput = new Hashtable();
            iddnoOutput.Add("@value", null);
            DataSet Metr_Item_Out = IO.SqlSp(Login_Server, cmdstring, hashtable1, ref iddnoOutput);

            //log開始
            Er.ExLog(new Exception(), "61", "End,取得指定單號," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));

            #endregion

            #region 新增metr_head 1-row
            DataRow Metr_head_row = Metr_Head.Tables[0].NewRow();
            Metr_head_row["L_METH_ID"] = iddnoOutput["@value"];
            Metr_head_row["I_meth_opname"] = 1;     //儲位調整(1)
            Metr_head_row["I_meth_flag"] = 5;       //通知狀態
            Metr_head_row["S_METH_OWNDID"] = "PXMART";
            Metr_head_row["S_METH_CFMEMPDID"] = DBNull.Value;
            Metr_head_row["T_METH_CFMDATE"] = DBNull.Value;
            Metr_head_row["N_METH_MEMO"] = "車機";
            Metr_head_row["S_METH_EMPDID"] = UserInf.UserID;
            Metr_head_row["L_METH_STOIID"] = DBNull.Value;
            Metr_head_row["D_METH_CREATDATE"] = DateTime.Now.ToString("yyyy-MM-dd");
            Metr_head_row["L_METH_LMSID"] = DBNull.Value;
            Metr_head_row["L_METH_SLOHID"] = 0;
            Metr_head_row["S_meth_erpid"] = "";
            Metr_head_row["I_meth_Form"] = 1;
            Metr_Head.Tables[0].Rows.Add(Metr_head_row);
            #endregion

            #region 新增metr_item 1-row
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,取得移出和移入儲位的資料," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_repi_outslodid_out.Text + "," + txS_repi_inslodid_in.Text);

            //取得移出和移入儲位的資料
            cmdstring = "select L_slom_sysno,L_slom_merdsysno,L_slom_merlsysno,I_merl_mersid,S_slom_unit1,S_merl_merpgroup,S_merl_lotno,S_merl_sbuid,S_merl_supdid,D_merl_expdate "
                + " from slot_mer a inner join mer_list b on a.L_slom_merlsysno=b.L_merl_sysno "
                + " where a.S_slom_merdid=@merd_id and S_slom_slodid=@in_slodid and (D_merl_expdate=@In_date or D_merl_expdate is null)";
            Hashtable hashtable_InOutMetrItems = new Hashtable();
            hashtable_InOutMetrItems.Add("@in_slodid", txS_repi_inslodid_in.Text);
            hashtable_InOutMetrItems.Add("@out_slodid", txS_repi_outslodid_out.Text);
            hashtable_InOutMetrItems.Add("@merd_id", txS_merd_id_out.Text);
            hashtable_InOutMetrItems.Add("@Out_date", txD_merl_expdate_Out.Text);
            hashtable_InOutMetrItems.Add("@In_date", txD_merl_expdate_in.Text);
            DataSet Metr_Item_InDetail = IO.SqlQuery(Login_Server, cmdstring, hashtable_InOutMetrItems);

            cmdstring = "select L_slom_sysno,L_slom_merdsysno,L_slom_merlsysno,I_merl_mersid,S_slom_unit1,S_merl_merpgroup,S_merl_lotno,S_merl_sbuid,S_merl_supdid,D_merl_expdate "
                + " from slot_mer a inner join mer_list b on a.L_slom_merlsysno=b.L_merl_sysno "
                + " inner join mer_package c on a.L_slom_merdsysno=c.L_merp_merdsysno AND c.I_merp_boxflag=1"
                + " where a.S_slom_merdid=@merd_id and S_slom_slodid=@out_slodid and (D_merl_expdate=@Out_date or D_merl_expdate is null)";
            DataSet Metr_Item_OutDetail = IO.SqlQuery(Login_Server, cmdstring, hashtable_InOutMetrItems);

            DataRow Metr_item_row = Metr_Item.Tables[0].NewRow();
            //固定欄位
            Metr_item_row["L_METI_METHID"] = iddnoOutput["@value"];
            Metr_item_row["L_METI_SEQ"] = 1;
            Metr_item_row["S_METI_SLODID"] = txS_repi_outslodid_out.Text;
            Metr_item_row["S_METI_NEWSLODID"] = txS_repi_inslodid_in.Text;
            Metr_item_row["L_METI_ADJQTY"] = lbL_repi_replqty_out_Pcs_value.Text;
            Metr_item_row["S_METI_ADJEMPDID"] = UserInf.UserID;
            Metr_item_row["T_METI_ADJDATE"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            Metr_item_row["I_METI_INPUTFLAG"] = 0;
            Metr_item_row["I_meti_flag"] = 0;
            Metr_item_row["S_meti_merdid"] = txS_merd_id_out.Text;
            Metr_item_row["S_meti_rboxhid"] = DBNull.Value;
            Metr_item_row["I_meti_execl"] = 0;

            //移出儲位和貨號
            Metr_item_row["L_METI_SLOMSYSNO"] = Metr_Item_OutDetail.Tables[0].Rows[0]["L_slom_sysno"];
            Metr_item_row["L_METI_MERDSYSNO"] = Metr_Item_OutDetail.Tables[0].Rows[0]["L_slom_merdsysno"];
            Metr_item_row["L_METI_MERLSYSNO"] = Metr_Item_OutDetail.Tables[0].Rows[0]["L_slom_merlsysno"];
            Metr_item_row["I_METI_MERSID"] = Metr_Item_OutDetail.Tables[0].Rows[0]["I_merl_mersid"];
            Metr_item_row["S_meti_merpgroup"] = Metr_Item_OutDetail.Tables[0].Rows[0]["S_merl_merpgroup"];

            //移入儲位和貨號
            if (Metr_Item_InDetail.Tables[0].Rows.Count > 0)
            {
                Metr_item_row["L_METI_NEWSLOMSYSNO"] = Metr_Item_InDetail.Tables[0].Rows[0]["L_slom_sysno"];
            }
            else
            {
                Metr_item_row["L_METI_NEWSLOMSYSNO"] = 0;
            }
            Metr_item_row["L_METI_NEWMERLSYSNO"] = Metr_Item_OutDetail.Tables[0].Rows[0]["L_slom_merlsysno"];
            Metr_item_row["I_METI_NEWMERSID"] = Metr_Item_OutDetail.Tables[0].Rows[0]["I_merl_mersid"];
            Metr_item_row["S_METI_UNIT"] = Metr_Item_OutDetail.Tables[0].Rows[0]["S_slom_unit1"].ToString();
            Metr_item_row["L_METI_NEWMERDSYSNO"] = Metr_Item_OutDetail.Tables[0].Rows[0]["L_slom_merdsysno"];
            Metr_item_row["S_meti_newlotno"] = Metr_Item_OutDetail.Tables[0].Rows[0]["S_merl_lotno"];
            Metr_item_row["S_meti_newsbuid"] = Metr_Item_OutDetail.Tables[0].Rows[0]["S_merl_sbuid"];
            Metr_item_row["S_meti_newsupdid"] = Metr_Item_OutDetail.Tables[0].Rows[0]["S_merl_supdid"];
            Metr_item_row["S_meti_newmerpgroup"] = Metr_Item_OutDetail.Tables[0].Rows[0]["S_merl_merpgroup"];
            Metr_item_row["D_meti_newexpdate"] = Metr_Item_OutDetail.Tables[0].Rows[0]["D_merl_expdate"];

            Metr_Item.Tables[0].Rows.Add(Metr_item_row);

            //log結束
            Er.ExLog(new Exception(), "61", "End,取得移出和移入儲位的資料," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_repi_outslodid_out.Text + "," + txS_repi_inslodid_in.Text);
            #endregion

            #region 建立塞入Metr_head的字串
            cmdstring = "Insert Into Metr_head values(";
            int Metr_head_column_now = 0,
                Metr_head_column_Max = Metr_Head.Tables[0].Columns.Count,
                Metr_head_SuccessCount = 0;
            string Metr_Head_Column_Type = "";
            hashtable1 = new Hashtable();
            foreach (DataColumn column in Metr_Head.Tables[0].Columns)
            {
                Metr_head_column_now++;
                if (Metr_head_column_now < Metr_head_column_Max)
                    cmdstring += "@" + column.ColumnName + ",";
                else
                    cmdstring += "@" + column.ColumnName + ")";
                Metr_Head_Column_Type = Metr_Head.Tables[0].Rows[0][column.ColumnName].GetType().ToString();
                if (Metr_Head_Column_Type == "System.DBNull")
                {
                    hashtable1.Add("@" + column.ColumnName, DBNull.Value);
                }
                else
                {
                    if (Metr_Head_Column_Type != "System.DateTime")
                        hashtable1.Add("@" + column.ColumnName, Metr_Head.Tables[0].Rows[0][column.ColumnName].ToString());
                    else
                        hashtable1.Add("@" + column.ColumnName, ((DateTime)Metr_Head.Tables[0].Rows[0][column.ColumnName]).ToString("yyyy-MM-dd"));
                }
            }
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,寫入metr_head," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + iddnoOutput["@value"].ToString());

            IO.SqlUpdate(Login_Server, cmdstring, hashtable1, ref Metr_head_SuccessCount);

            //log結束
            Er.ExLog(new Exception(), "61", "End,寫入metr_head," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + iddnoOutput["@value"].ToString());
            #endregion

            #region 寫入Metr_head Log
            if (Metr_head_SuccessCount > 0)
            {
                SqlCarOperateLog(Metr_head_row["L_METH_ID"].ToString(), "N", 0, 0);
            }
            #endregion

            #region 建立塞入Metr_item的字串
            cmdstring = "Insert Into Metr_item(";
            int Metr_item_column_now = 0,
                Metr_item_column_Max = Metr_Item.Tables[0].Columns.Count,
                Metr_item_SuccessCount = 0;
            string Metr_Item_Column_Type = "";
            hashtable1 = new Hashtable();
            foreach (DataColumn column in Metr_Item.Tables[0].Columns)
            {
                Metr_item_column_now++;
                if (Metr_item_column_now < Metr_item_column_Max)
                    cmdstring += column.ColumnName + ",";
                else
                    cmdstring += column.ColumnName + ")";

                Metr_Item_Column_Type = Metr_Item.Tables[0].Rows[0][column.ColumnName].GetType().ToString();
                if (Metr_Item_Column_Type == "System.DBNull")
                {
                    hashtable1.Add("@" + column.ColumnName, DBNull.Value);
                }
                else
                {
                    if (Metr_Item_Column_Type != "System.DateTime")
                        hashtable1.Add("@" + column.ColumnName, Metr_Item.Tables[0].Rows[0][column.ColumnName].ToString());
                    else
                        hashtable1.Add("@" + column.ColumnName, ((DateTime)Metr_Item.Tables[0].Rows[0][column.ColumnName]).ToString("yyyy-MM-dd"));
                }
            }
            Metr_item_column_now = 0;
            cmdstring += " values(";
            foreach (DataColumn column in Metr_Item.Tables[0].Columns)
            {
                Metr_item_column_now++;
                if (Metr_item_column_now < Metr_item_column_Max)
                    cmdstring += "@" + column.ColumnName + ",";
                else
                    cmdstring += "@" + column.ColumnName + ")";
            }
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,寫入metr_item," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + iddnoOutput["@value"].ToString());

            IO.SqlUpdate(Login_Server, cmdstring, hashtable1, ref Metr_item_SuccessCount);

            //log結束
            Er.ExLog(new Exception(), "61", "End,寫入metr_item," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + iddnoOutput["@value"].ToString());

            #endregion


            if (Metr_head_SuccessCount > 0 && Metr_item_SuccessCount > 0)
            {
                //將狀態還原
                ResetDataGrid();
                Form_Refresh();
                lb_CrePage_SuccessMessage.Text = "已成功建立單據 " + iddnoOutput["@value"].ToString() + "!!";
                button_CrePage.Text = "完成";
            }
            else
            {
                //將狀態還原
                ResetDataGrid();
                Form_Refresh();
                lb_CrePage_SuccessMessage.Text = "建立單據失敗!!請洽系統人員";
                button_CrePage.Text = "完成";
            }
        }
        #endregion

        #region InStock 確認單據
        /// <summary>
        /// 顯示尚未完成的調儲單據
        /// </summary>
        private void ChangeStock_NonCompleteDocument()
        {
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,顯示尚未完成的調儲單據," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")); ;

            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add("@slodid", "");
            hashtable1.Add("@itemno", "");
            hashtable1.Add("@Type", 5);
            hashtable1.Add("@Level", 0);
            Hashtable hashtableOut = new Hashtable();
            DataSet DsInStock_NonCompleteDocument = IO.SqlSp(Login_Server, "spCarSystem_GetStockQty", hashtable1, ref hashtableOut);

            dgv_Instock_NonComplete.AutoGenerateColumns = false;
            dgv_Instock_NonComplete.DataSource = DsInStock_NonCompleteDocument.Tables[0];
            dgv_Instock_NonComplete.ClearSelection();

            //log結束
            Er.ExLog(new Exception(), "61", "End,顯示尚未完成的調儲單據," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));

        }

        //刷入移出儲位
        private void txS_repi_outslodid_out2_Validated(object sender, EventArgs e)
        {
            Boolean txS_repi_outslodid_out2_Flag = false;

            //未輸入資料
            if (txS_repi_outslodid_out2.Text == "")
                txS_repi_outslodid_out2_Flag = true;

            //log開始
            Er.ExLog(new Exception(), "61", "Sta,刷入移出儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_repi_outslodid_out2.Text);

            #region 輸入移出儲位後先查詢資料作保存
            if (txS_repi_outslodid_out2_Flag == false)
            {
                txS_repi_outslodid_out2_Flag = !MetrItemChangeGetData();
            }
            #endregion

            if (txS_repi_outslodid_out2_Flag == true)
            {
                lb_ResultMsg.Text = "資料有誤,請刷入移出儲位";
                txS_repi_outslodid_out2.Text = "";
                txS_repi_outslodid_out2.Focus();
            }
            else
            {
                lb_ResultMsg.Text = "請刷入商品條碼/ITF";
            }

            //log結束
            Er.ExLog(new Exception(), "61", "End,刷入移出儲位," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_repi_outslodid_out2.Text);
        }

        //刷入商品條碼
        private void txS_merd_id_out2_Validated(object sender, EventArgs e)
        {
            Boolean txS_merd_id_out2_Flag = false;

            //未輸入資料
            if (txS_merd_id_out2.Text == "")
                txS_merd_id_out2_Flag = true;


            #region 輸入條碼後先檢查是否有與之前的資料重複
            if (txS_merd_id_out2_Flag == false)
            {
                //1.之前是否已有資料
                if (DsOutStock != null)
                {
                    if (DsOutStock.Tables.Count > 0)
                    {
                        if (DsOutStock.Tables[0].Rows.Count > 0)
                        {
                            //2.舊有儲位內容與現在的是否有關
                            int OldDataFindIndex = MyDictionaryFind(DsOutStock.Tables[0], "S_meti_slodid", txS_repi_outslodid_out2.Text);
                            if (OldDataFindIndex >= 0)
                            {
                                //3.舊有貨號內容與現在的是否有關
                                //貨號
                                OldDataFindIndex = MyDictionaryFind(DsOutStock.Tables[0], "S_meti_merdid", txS_merd_id_out2.Text);
                                //條碼
                                if (OldDataFindIndex < 0)
                                    OldDataFindIndex = MyDictionaryFind(DsOutStock.Tables[0], "S_merp_barcode", txS_merd_id_out2.Text);

                                if (OldDataFindIndex >= 0)
                                {
                                    //帶入儲位資料
                                    MetrItemChangeGetData_FillData(OldDataFindIndex);
                                }
                                else
                                {
                                    //資料有誤
                                    txS_merd_id_out2_Flag = true;
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            if (txS_merd_id_out2_Flag == true)
            {
                lb_ResultMsg.Text = "資料有誤,請刷入商品條碼/ITF";
                txS_merd_id_out2.Text = "";
                txS_merd_id_out2.Focus();
            }
            else
            {
                lb_ResultMsg.Text = "請刷入移入儲位";
            }
        }

        //刷入移入儲位後判斷資料正確性
        private void txS_repi_inslodid_in2_Validated(object sender, EventArgs e)
        {
            Boolean txS_repi_inslodid_in2_Flag = false;

            //未輸入資料
            if (txS_repi_inslodid_in2.Text == "")
                txS_repi_inslodid_in2_Flag = true;

            #region 查詢資料
            if (txS_repi_inslodid_in2_Flag == false)
            {
                int OldDataFindIndex = MyDictionaryFind(DsOutStock.Tables[0], "S_meti_newslodid", txS_repi_inslodid_in2.Text);
                if (OldDataFindIndex < 0)
                {
                    txS_repi_inslodid_in2_Flag = true;
                }
            }
            #endregion

            if (txS_repi_inslodid_in2_Flag == true)
            {
                lb_ResultMsg.Text = "資料有誤,請刷入移入儲位";
                txS_repi_inslodid_in2.Text = "";
                txS_repi_inslodid_in2.Focus();
            }
            else
            {
                button_CfmPage.Enabled = true;
                lb_ResultMsg.Text = "確認資料正確後，按下「確認」";
                button_CfmPage.Focus();
            }
        }

        DataSet DsOutStock;
        /// <summary>
        /// 調儲作業查詢資料
        /// </summary>
        /// <returns>回傳是否成功</returns>
        Boolean MetrItemChangeGetData()
        {
            Boolean SuccessFlag = false;

            #region 查詢資料
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,調儲作業查詢資料," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_repi_outslodid_out2.Text + "," + txS_merd_id_out2.Text);

            StartLoadingShow();
            DsOutStock = new DataSet();
            //I_meth_flag=5 通知狀態
            //I_meti_flag=20 建單狀態
            string cmdstring =
            @"select top 1 L_meti_adjqty,L_meti_adjqty_box=L_meti_adjqty/e.I_merp_1qty,S_meti_unit,S_meti_slodid,D_merl_expdate,S_meti_newslodid,D_meti_newexpdate,S_meti_merdid,N_merd_name,L_meth_id,e.S_merp_barcode
            from metr_head a inner join metr_item b on a.L_meth_id=L_meti_methid
            inner join mer_data c on b.S_meti_merdid=c.S_merd_id inner join mer_list d on b.L_meti_merlsysno=d.L_merl_sysno
            INNER JOIN mer_package e ON c.L_merd_sysno=e.L_merp_merdsysno AND e.I_merp_boxflag=1
            where I_meth_flag=5 and b.S_meti_slodid=@Outslodid";
            if (txS_merd_id_out2.Text != "")
                cmdstring += " and b.S_meti_merdid=@OutMerdid ";
            cmdstring += " order by D_meth_creatdate desc,L_meth_id desc ";

            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add("@Outslodid", txS_repi_outslodid_out2.Text);
            if (txS_merd_id_out2.Text != "")
                hashtable1.Add("@OutMerdid", txS_merd_id_out2.Text);

            DsOutStock = IO.SqlQuery(Login_Server, cmdstring, hashtable1);
            CloseLoadingShow();
            //log結束
            Er.ExLog(new Exception(), "61", "End,調儲作業查詢資料," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_repi_outslodid_out2.Text + "," + txS_merd_id_out2.Text);

            #endregion

            #region 帶入資料
            if (DsOutStock.Tables[0].Rows.Count > 0)
            {
                MetrItemChangeGetData_FillData(0);
                SuccessFlag = true;
            }
            else
                SuccessFlag = false;
            #endregion

            return SuccessFlag;
        }

        /// <summary>
        /// 可能會有多筆調儲單，再定位至正確的儲位
        /// </summary>
        /// <param name="RowIndex">Row的Index</param>
        void MetrItemChangeGetData_FillData(int RowIndex)
        {
            if (DsOutStock.Tables[0].Rows.Count <= RowIndex)
                return;
            txL_repi_replqty_out2.Text = DsOutStock.Tables[0].Rows[RowIndex]["L_meti_adjqty_box"].ToString();

            txD_merl_expdate_Out2.Text = DsOutStock.Tables[0].Rows[RowIndex]["D_merl_expdate"].ToString();
            if (txD_merl_expdate_Out2.Text != "")
                txD_merl_expdate_Out2.Text = Convert.ToDateTime(txD_merl_expdate_Out2.Text).ToString("yyyy/MM/dd");

            txD_merl_expdate_in2.Text = DsOutStock.Tables[0].Rows[RowIndex]["D_meti_newexpdate"].ToString();
            if (txD_merl_expdate_in2.Text != "")
                txD_merl_expdate_in2.Text = Convert.ToDateTime(txD_merl_expdate_in2.Text).ToString("yyyy/MM/dd");

            rtxN_merd_name.Text = DsOutStock.Tables[0].Rows[RowIndex]["N_merd_name"].ToString();
            txS_metr_id.Text = DsOutStock.Tables[0].Rows[RowIndex]["L_meth_id"].ToString();
            lbL_repi_replqty_out_Pcs_value_ChgPage.Text = DsOutStock.Tables[0].Rows[RowIndex]["L_meti_adjqty"].ToString();
        }

        //確認&完成單據
        private void button_CfmPage_Click(object sender, EventArgs e)
        {
            if (button_CfmPage.Text == "刷入下一筆")
            {
                CfmPage_Reset();
                return;
            }

            #region 確認單據
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,確認單據," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_metr_id.Text);
            Hashtable InputValue = new Hashtable(),
                      OutValue = new Hashtable();
            InputValue.Add("@L_meth_id", txS_metr_id.Text);
            InputValue.Add("@I_inputtype", 0);
            InputValue.Add("@S_empdid", UserInf.UserID);
            InputValue.Add("@S_computer", UserInf.ComputerName);
            OutValue.Add("@I_result", null);
            OutValue.Add("@S_result", null);
            DataSet DS_Cfm = IO.SqlSp(Login_Server, "SP_metr_cfm", InputValue, ref OutValue);
            if (Convert.ToInt32(OutValue["@I_result"]) == 0)
            {
                lb_ResultMsg.Text = "單據" + txS_metr_id.Text + "確認完成" + "\n";
                SqlCarOperateLog(txS_metr_id.Text, "C", Convert.ToInt32(lbL_repi_replqty_out_Pcs_value_ChgPage.Text), Convert.ToInt32(lbL_repi_replqty_out_Pcs_value_ChgPage.Text));
            }
            else
                lb_ResultMsg.Text = OutValue["@S_result"].ToString() + "\n";

            //log結束
            Er.ExLog(new Exception(), "61", "End,確認單據," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_metr_id.Text);

            #endregion

            #region 完成單據
            //log開始
            Er.ExLog(new Exception(), "61", "Sta,完成單據," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_metr_id.Text);

            Hashtable InputValue_finsih = new Hashtable(),
                      OutValue_finish = new Hashtable();
            InputValue_finsih.Add("@L_meth_id", txS_metr_id.Text);
            InputValue_finsih.Add("@L_meti_sysno", 0);
            InputValue_finsih.Add("@I_adjtype", 0);
            InputValue_finsih.Add("@I_inputtype", 0);
            InputValue_finsih.Add("@S_empdid", UserInf.UserID);
            InputValue_finsih.Add("@S_computer", UserInf.ComputerName);
            OutValue_finish.Add("@I_result", null);
            OutValue_finish.Add("@S_result", null);
            OutValue_finish.Add("@I_notfinish", null);
            DataSet DS_Finish = IO.SqlSp(Login_Server, "SP_metr_Finish", InputValue_finsih, ref OutValue_finish);
            if (Convert.ToInt32(OutValue_finish["@I_result"]) == 0)
            {
                lb_ResultMsg.Text += "單據" + txS_metr_id.Text + "調整完成" + "\n";
                DsOutStock = new DataSet();
                SqlCarOperateLog(txS_metr_id.Text, "F", Convert.ToInt32(lbL_repi_replqty_out_Pcs_value_ChgPage.Text), Convert.ToInt32(lbL_repi_replqty_out_Pcs_value_ChgPage.Text));
            }
            else
                lb_ResultMsg.Text += OutValue_finish["@S_result"].ToString() + "\n";
            #endregion

            button_CfmPage.Text = "刷入下一筆";

            //log開始
            Er.ExLog(new Exception(), "61", "End,完成單據," + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "," + txS_metr_id.Text);

        }

        #endregion

        #endregion

        #region 複寫原本按鈕功能
        //建單
        protected override void EditButton_Click(object sender, EventArgs e)
        {
            tbc_MainFunction.SelectedIndex = 0;
            ResetDataGrid();
            MapPage_Reset();
            CrePage_Reset();
            CfmPage_Reset();
        }

        //調儲
        protected override void NewButton_Click(object sender, EventArgs e)
        {
            tbc_MainFunction.SelectedIndex = 2;

            ChangeStock_NonCompleteDocument();

            ResetDataGrid();
            CrePage_Reset();
            CfmPage_Reset();
            Form_Refresh();
        }

        //Map按下返回上一頁
        protected override void PreviousButton_Click(object sender, EventArgs e)
        {
            MapPage_Reset();
        }

        #endregion

        #endregion

        #region Reset頁面數據

        //還原DataGridView數據
        private void ResetDataGrid()
        {
            if (dataGridView_InStock != null && dataGridView_InStock.Rows.Count > 0)
                ((DataTable)dataGridView_InStock.DataSource).Clear();
            if (dataGridView_CrePage != null && dataGridView_CrePage.Rows.Count > 0)
                ((DataTable)dataGridView_CrePage.DataSource).Clear();
        }
        //Map 頁面資料重置
        void MapPage_Reset()
        {
            switch (tbc_MainFunction.SelectedIndex)
            {
                case 0:
                    if (FunSize == 10)
                    {
                        ResetDataGrid();
                        Form_Refresh();
                    }
                    bindingNavigatorRefreshButton.Visible = true;
                    break;
                case 1:
                    tbc_MainFunction.SelectedIndex -= 1; break;
                case 2:
                    tbc_MainFunction.SelectedIndex -= 1; break;
                case 3: break;
            }
        }
        //CrePage 頁面資料重置
        void CrePage_Reset()
        {
            lb_CrePage_SuccessMessage.Text = "請指定移出儲位";
            button_CrePage.Text = "建單";
            txL_repi_replqty_in.Text = "";
            txL_repi_replqty_out.Text = "";
        }
        //InStock 頁面資料重置
        void CfmPage_Reset()
        {
            txL_repi_replqty_out2.Text = "";
            txD_merl_expdate_Out2.Text = "";
            txD_merl_expdate_in2.Text = "";
            txS_repi_outslodid_out2.Text = "";
            txS_repi_inslodid_in2.Text = "";
            txS_merd_id_out2.Text = "";
            rtxN_merd_name.Text = "";
            txS_metr_id.Text = "";
            button_CfmPage.Text = "確認";
            button_CfmPage.Enabled = false;
            txS_repi_outslodid_out2.Focus();
        }
        //回復成1:1視窗
        private void Form_Refresh()
        {
            Fun1XPOS = 0;
            Fun1YPOS = 0;
            FunSize = 1;
            pictureBox1.Image = DC1mapBig;
        }

        #endregion

        #region 字典搜尋
        /// <summary>
        /// 字典搜尋
        /// </summary>
        /// <param name="dt_Source">來源Table</param>
        /// <param name="ColumnName">欲查詢欄位</param>
        /// <param name="SearchString">查詢值</param>
        /// <returns>行數代號</returns>
        private int MyDictionaryFind(DataTable dt_Source, string ColumnName, string SearchString)
        {
            int Search_Index = -1;
            //建立Dictionary
            Dictionary<string, int> MyDictionary = new Dictionary<string, int>();
            int i = 0;
            foreach (DataRow dr in dt_Source.Rows)
            {
                if (MyDictionary.ContainsKey(dr[ColumnName].ToString()) == false)
                {
                    MyDictionary.Add(dr[ColumnName].ToString(), i);
                    i++;
                }
            }
            //查詢
            if (MyDictionary.ContainsKey(SearchString))
            {
                Search_Index = MyDictionary[SearchString];
            }
            return Search_Index;
        }
        #endregion

    }
}
