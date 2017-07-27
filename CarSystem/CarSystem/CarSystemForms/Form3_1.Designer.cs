namespace CarSystem
{
    partial class Form3_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbL_recs_id1 = new System.Windows.Forms.Label();
            this.lbN_merd_name1 = new System.Windows.Forms.Label();
            this.lbL_recs_takenum1 = new System.Windows.Forms.Label();
            this.lbS_merp_barcode1 = new System.Windows.Forms.Label();
            this.txL_recs_id1 = new System.Windows.Forms.TextBox();
            this.txS_recs_slodidNew1 = new System.Windows.Forms.TextBox();
            this.cummit = new Car_Fun.myButton();
            this.txS_merp_barcode1 = new System.Windows.Forms.TextBox();
            this.txN_merd_name1 = new System.Windows.Forms.TextBox();
            this.txL_recs_takenum1 = new System.Windows.Forms.TextBox();
            this.lbS_recs_slodidNew1 = new System.Windows.Forms.Label();
            this.txMessage = new System.Windows.Forms.Label();
            this.lbS_slod_pick = new System.Windows.Forms.Label();
            this.txS_slod_pick = new System.Windows.Forms.TextBox();
            this.Details = new System.Windows.Forms.Panel();
            this.txb_recsID = new System.Windows.Forms.TextBox();
            this.txb_MerdID = new System.Windows.Forms.TextBox();
            this.txb_OwnerID = new System.Windows.Forms.TextBox();
            this.txL_recs_merlsysno = new System.Windows.Forms.TextBox();
            this.txL_recs_recrid = new System.Windows.Forms.TextBox();
            this.txS_merl_lotno1 = new System.Windows.Forms.TextBox();
            this.txS_merl_merpgroup1 = new System.Windows.Forms.TextBox();
            this.lbL_recs_merlsysno = new System.Windows.Forms.Label();
            this.lbL_recs_recrid = new System.Windows.Forms.Label();
            this.lbS_merl_lotno1 = new System.Windows.Forms.Label();
            this.lbS_merl_merpgroup1 = new System.Windows.Forms.Label();
            this.lbS_recs_slodid1 = new System.Windows.Forms.Label();
            this.txD_merl_expdate1 = new System.Windows.Forms.TextBox();
            this.lbD_merl_expdate1 = new System.Windows.Forms.Label();
            this.txS_recs_slodid1 = new System.Windows.Forms.TextBox();
            this.btn_ShowDetail = new Car_Fun.myButton();
            this.txS_PickCag = new System.Windows.Forms.TextBox();
            this.lbS_PickCag = new System.Windows.Forms.Label();
            this.txS_slom_1qty = new System.Windows.Forms.TextBox();
            this.lbS_slom_1qty = new System.Windows.Forms.Label();
            this.lbL_repi_replqty_out_box_value = new System.Windows.Forms.Label();
            this.lbL_repi_replqty_out_box = new System.Windows.Forms.Label();
            this.lbL_repi_replqty_out_pallet_value = new System.Windows.Forms.Label();
            this.lbL_repi_replqty_out_pallet = new System.Windows.Forms.Label();
            this.lbl_ABC = new System.Windows.Forms.Label();
            this.txI_merp_unitNO1 = new System.Windows.Forms.Label();
            this.txI_merp_unitNO2 = new System.Windows.Forms.Label();
            this.BW_checkSlodId = new System.ComponentModel.BackgroundWorker();
            this.BW_checkPltNo = new System.ComponentModel.BackgroundWorker();
            this.BW_ReciPutCfm = new System.ComponentModel.BackgroundWorker();
            this.lbl_mergFlag = new System.Windows.Forms.Label();
            this.btn_mergflagList = new Car_Fun.myButton();
            this.Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbL_recs_id1
            // 
            this.lbL_recs_id1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbL_recs_id1.ForeColor = System.Drawing.Color.White;
            this.lbL_recs_id1.Location = new System.Drawing.Point(15, 15);
            this.lbL_recs_id1.Name = "lbL_recs_id1";
            this.lbL_recs_id1.Size = new System.Drawing.Size(150, 39);
            this.lbL_recs_id1.TabIndex = 3;
            this.lbL_recs_id1.Text = "驗收標籤";
            // 
            // lbN_merd_name1
            // 
            this.lbN_merd_name1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbN_merd_name1.ForeColor = System.Drawing.Color.White;
            this.lbN_merd_name1.Location = new System.Drawing.Point(15, 75);
            this.lbN_merd_name1.Name = "lbN_merd_name1";
            this.lbN_merd_name1.Size = new System.Drawing.Size(150, 39);
            this.lbN_merd_name1.TabIndex = 13;
            this.lbN_merd_name1.Text = "商品名稱";
            // 
            // lbL_recs_takenum1
            // 
            this.lbL_recs_takenum1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbL_recs_takenum1.ForeColor = System.Drawing.Color.White;
            this.lbL_recs_takenum1.Location = new System.Drawing.Point(15, 255);
            this.lbL_recs_takenum1.Name = "lbL_recs_takenum1";
            this.lbL_recs_takenum1.Size = new System.Drawing.Size(150, 39);
            this.lbL_recs_takenum1.TabIndex = 16;
            this.lbL_recs_takenum1.Text = "待上架數量";
            // 
            // lbS_merp_barcode1
            // 
            this.lbS_merp_barcode1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_merp_barcode1.ForeColor = System.Drawing.Color.White;
            this.lbS_merp_barcode1.Location = new System.Drawing.Point(15, 135);
            this.lbS_merp_barcode1.Name = "lbS_merp_barcode1";
            this.lbS_merp_barcode1.Size = new System.Drawing.Size(150, 39);
            this.lbS_merp_barcode1.TabIndex = 20;
            this.lbS_merp_barcode1.Text = "國際條碼";
            // 
            // txL_recs_id1
            // 
            this.txL_recs_id1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txL_recs_id1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txL_recs_id1.Font = new System.Drawing.Font("新細明體", 36F);
            this.txL_recs_id1.ForeColor = System.Drawing.SystemColors.Window;
            this.txL_recs_id1.Location = new System.Drawing.Point(171, 3);
            this.txL_recs_id1.Name = "txL_recs_id1";
            this.txL_recs_id1.Size = new System.Drawing.Size(308, 58);
            this.txL_recs_id1.TabIndex = 0;
            this.txL_recs_id1.Validated += new System.EventHandler(this.txL_recs_id1_Validated);
            this.txL_recs_id1.Enter += new System.EventHandler(this.txL_recs_id1_Enter);
            // 
            // txS_recs_slodidNew1
            // 
            this.txS_recs_slodidNew1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txS_recs_slodidNew1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_recs_slodidNew1.Font = new System.Drawing.Font("新細明體", 36F);
            this.txS_recs_slodidNew1.ForeColor = System.Drawing.SystemColors.Window;
            this.txS_recs_slodidNew1.Location = new System.Drawing.Point(373, 183);
            this.txS_recs_slodidNew1.Name = "txS_recs_slodidNew1";
            this.txS_recs_slodidNew1.Size = new System.Drawing.Size(204, 58);
            this.txS_recs_slodidNew1.TabIndex = 1;
            this.txS_recs_slodidNew1.TextChanged += new System.EventHandler(this.txS_recs_slodidNew1_TextChanged);
            this.txS_recs_slodidNew1.Validated += new System.EventHandler(this.txS_recs_slodidNew1_Validated);
            // 
            // cummit
            // 
            this.cummit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cummit.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cummit.Location = new System.Drawing.Point(637, 551);
            this.cummit.Name = "cummit";
            this.cummit.Size = new System.Drawing.Size(259, 97);
            this.cummit.TabIndex = 2;
            this.cummit.Text = "確認";
            this.cummit.UseVisualStyleBackColor = true;
            this.cummit.Click += new System.EventHandler(this.cummit_Click);
            this.cummit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cummit_KeyPress);
            // 
            // txS_merp_barcode1
            // 
            this.txS_merp_barcode1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_merp_barcode1.Font = new System.Drawing.Font("新細明體", 36F);
            this.txS_merp_barcode1.Location = new System.Drawing.Point(171, 123);
            this.txS_merp_barcode1.Name = "txS_merp_barcode1";
            this.txS_merp_barcode1.ReadOnly = true;
            this.txS_merp_barcode1.Size = new System.Drawing.Size(406, 58);
            this.txS_merp_barcode1.TabIndex = 213;
            // 
            // txN_merd_name1
            // 
            this.txN_merd_name1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txN_merd_name1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txN_merd_name1.Location = new System.Drawing.Point(171, 63);
            this.txN_merd_name1.Name = "txN_merd_name1";
            this.txN_merd_name1.ReadOnly = true;
            this.txN_merd_name1.Size = new System.Drawing.Size(786, 58);
            this.txN_merd_name1.TabIndex = 203;
            // 
            // txL_recs_takenum1
            // 
            this.txL_recs_takenum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txL_recs_takenum1.Font = new System.Drawing.Font("新細明體", 36F);
            this.txL_recs_takenum1.Location = new System.Drawing.Point(171, 243);
            this.txL_recs_takenum1.Name = "txL_recs_takenum1";
            this.txL_recs_takenum1.ReadOnly = true;
            this.txL_recs_takenum1.Size = new System.Drawing.Size(138, 58);
            this.txL_recs_takenum1.TabIndex = 208;
            this.txL_recs_takenum1.TextChanged += new System.EventHandler(this.txL_recs_takenum1_TextChanged);
            // 
            // lbS_recs_slodidNew1
            // 
            this.lbS_recs_slodidNew1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_recs_slodidNew1.ForeColor = System.Drawing.Color.White;
            this.lbS_recs_slodidNew1.Location = new System.Drawing.Point(15, 195);
            this.lbS_recs_slodidNew1.Name = "lbS_recs_slodidNew1";
            this.lbS_recs_slodidNew1.Size = new System.Drawing.Size(150, 39);
            this.lbS_recs_slodidNew1.TabIndex = 315;
            this.lbS_recs_slodidNew1.Text = "實際移入儲位";
            // 
            // txMessage
            // 
            this.txMessage.AutoSize = true;
            this.txMessage.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txMessage.ForeColor = System.Drawing.Color.Red;
            this.txMessage.Location = new System.Drawing.Point(13, 322);
            this.txMessage.MaximumSize = new System.Drawing.Size(800, 0);
            this.txMessage.Name = "txMessage";
            this.txMessage.Size = new System.Drawing.Size(260, 48);
            this.txMessage.TabIndex = 316;
            this.txMessage.Text = "請刷入板標";
            // 
            // lbS_slod_pick
            // 
            this.lbS_slod_pick.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_slod_pick.ForeColor = System.Drawing.Color.White;
            this.lbS_slod_pick.Location = new System.Drawing.Point(656, 135);
            this.lbS_slod_pick.Name = "lbS_slod_pick";
            this.lbS_slod_pick.Size = new System.Drawing.Size(145, 39);
            this.lbS_slod_pick.TabIndex = 317;
            this.lbS_slod_pick.Text = "揀位";
            // 
            // txS_slod_pick
            // 
            this.txS_slod_pick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_slod_pick.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txS_slod_pick.Location = new System.Drawing.Point(774, 123);
            this.txS_slod_pick.Name = "txS_slod_pick";
            this.txS_slod_pick.ReadOnly = true;
            this.txS_slod_pick.Size = new System.Drawing.Size(183, 58);
            this.txS_slod_pick.TabIndex = 318;
            // 
            // Details
            // 
            this.Details.Controls.Add(this.txb_recsID);
            this.Details.Controls.Add(this.txb_MerdID);
            this.Details.Controls.Add(this.txb_OwnerID);
            this.Details.Controls.Add(this.txL_recs_merlsysno);
            this.Details.Controls.Add(this.txL_recs_recrid);
            this.Details.Controls.Add(this.txS_merl_lotno1);
            this.Details.Controls.Add(this.txS_merl_merpgroup1);
            this.Details.Controls.Add(this.lbL_recs_merlsysno);
            this.Details.Controls.Add(this.lbL_recs_recrid);
            this.Details.Controls.Add(this.lbS_merl_lotno1);
            this.Details.Controls.Add(this.lbS_merl_merpgroup1);
            this.Details.Controls.Add(this.lbS_recs_slodid1);
            this.Details.Controls.Add(this.txD_merl_expdate1);
            this.Details.Controls.Add(this.lbD_merl_expdate1);
            this.Details.Location = new System.Drawing.Point(21, 373);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(935, 187);
            this.Details.TabIndex = 319;
            this.Details.Visible = false;
            this.Details.Paint += new System.Windows.Forms.PaintEventHandler(this.Details_Paint);
            // 
            // txb_recsID
            // 
            this.txb_recsID.Location = new System.Drawing.Point(824, 158);
            this.txb_recsID.Name = "txb_recsID";
            this.txb_recsID.Size = new System.Drawing.Size(100, 22);
            this.txb_recsID.TabIndex = 330;
            // 
            // txb_MerdID
            // 
            this.txb_MerdID.Location = new System.Drawing.Point(718, 158);
            this.txb_MerdID.Name = "txb_MerdID";
            this.txb_MerdID.Size = new System.Drawing.Size(100, 22);
            this.txb_MerdID.TabIndex = 329;
            // 
            // txb_OwnerID
            // 
            this.txb_OwnerID.Location = new System.Drawing.Point(612, 158);
            this.txb_OwnerID.Name = "txb_OwnerID";
            this.txb_OwnerID.Size = new System.Drawing.Size(100, 22);
            this.txb_OwnerID.TabIndex = 219;
            // 
            // txL_recs_merlsysno
            // 
            this.txL_recs_merlsysno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txL_recs_merlsysno.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txL_recs_merlsysno.Location = new System.Drawing.Point(612, 113);
            this.txL_recs_merlsysno.Name = "txL_recs_merlsysno";
            this.txL_recs_merlsysno.ReadOnly = true;
            this.txL_recs_merlsysno.Size = new System.Drawing.Size(312, 39);
            this.txL_recs_merlsysno.TabIndex = 218;
            this.txL_recs_merlsysno.Text = "merlsysno";
            // 
            // txL_recs_recrid
            // 
            this.txL_recs_recrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txL_recs_recrid.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txL_recs_recrid.Location = new System.Drawing.Point(612, 61);
            this.txL_recs_recrid.Name = "txL_recs_recrid";
            this.txL_recs_recrid.ReadOnly = true;
            this.txL_recs_recrid.Size = new System.Drawing.Size(312, 39);
            this.txL_recs_recrid.TabIndex = 217;
            this.txL_recs_recrid.Text = "recs_recrid";
            // 
            // txS_merl_lotno1
            // 
            this.txS_merl_lotno1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_merl_lotno1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txS_merl_lotno1.Location = new System.Drawing.Point(612, 8);
            this.txS_merl_lotno1.Name = "txS_merl_lotno1";
            this.txS_merl_lotno1.ReadOnly = true;
            this.txS_merl_lotno1.Size = new System.Drawing.Size(312, 39);
            this.txS_merl_lotno1.TabIndex = 216;
            this.txS_merl_lotno1.Text = "lotno";
            // 
            // txS_merl_merpgroup1
            // 
            this.txS_merl_merpgroup1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_merl_merpgroup1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txS_merl_merpgroup1.Location = new System.Drawing.Point(253, 115);
            this.txS_merl_merpgroup1.Name = "txS_merl_merpgroup1";
            this.txS_merl_merpgroup1.ReadOnly = true;
            this.txS_merl_merpgroup1.Size = new System.Drawing.Size(152, 39);
            this.txS_merl_merpgroup1.TabIndex = 215;
            this.txS_merl_merpgroup1.Text = "merpgroup";
            // 
            // lbL_recs_merlsysno
            // 
            this.lbL_recs_merlsysno.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbL_recs_merlsysno.ForeColor = System.Drawing.Color.White;
            this.lbL_recs_merlsysno.Location = new System.Drawing.Point(416, 116);
            this.lbL_recs_merlsysno.Name = "lbL_recs_merlsysno";
            this.lbL_recs_merlsysno.Size = new System.Drawing.Size(190, 40);
            this.lbL_recs_merlsysno.TabIndex = 211;
            this.lbL_recs_merlsysno.Text = "庫存屬性";
            // 
            // lbL_recs_recrid
            // 
            this.lbL_recs_recrid.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbL_recs_recrid.ForeColor = System.Drawing.Color.White;
            this.lbL_recs_recrid.Location = new System.Drawing.Point(415, 64);
            this.lbL_recs_recrid.Name = "lbL_recs_recrid";
            this.lbL_recs_recrid.Size = new System.Drawing.Size(191, 38);
            this.lbL_recs_recrid.TabIndex = 212;
            this.lbL_recs_recrid.Text = "收貨/驗收單號";
            // 
            // lbS_merl_lotno1
            // 
            this.lbS_merl_lotno1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_merl_lotno1.ForeColor = System.Drawing.Color.White;
            this.lbS_merl_lotno1.Location = new System.Drawing.Point(415, 11);
            this.lbS_merl_lotno1.Name = "lbS_merl_lotno1";
            this.lbS_merl_lotno1.Size = new System.Drawing.Size(191, 40);
            this.lbS_merl_lotno1.TabIndex = 213;
            this.lbS_merl_lotno1.Text = "批號";
            // 
            // lbS_merl_merpgroup1
            // 
            this.lbS_merl_merpgroup1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_merl_merpgroup1.ForeColor = System.Drawing.Color.White;
            this.lbS_merl_merpgroup1.Location = new System.Drawing.Point(15, 115);
            this.lbS_merl_merpgroup1.Name = "lbS_merl_merpgroup1";
            this.lbS_merl_merpgroup1.Size = new System.Drawing.Size(208, 40);
            this.lbS_merl_merpgroup1.TabIndex = 214;
            this.lbS_merl_merpgroup1.Text = "組別";
            this.lbS_merl_merpgroup1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbS_recs_slodid1
            // 
            this.lbS_recs_slodid1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_recs_slodid1.ForeColor = System.Drawing.Color.White;
            this.lbS_recs_slodid1.Location = new System.Drawing.Point(15, 61);
            this.lbS_recs_slodid1.Name = "lbS_recs_slodid1";
            this.lbS_recs_slodid1.Size = new System.Drawing.Size(210, 45);
            this.lbS_recs_slodid1.TabIndex = 209;
            this.lbS_recs_slodid1.Text = "預訂移入儲位";
            this.lbS_recs_slodid1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbS_recs_slodid1.Visible = false;
            // 
            // txD_merl_expdate1
            // 
            this.txD_merl_expdate1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txD_merl_expdate1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txD_merl_expdate1.Location = new System.Drawing.Point(253, 8);
            this.txD_merl_expdate1.Name = "txD_merl_expdate1";
            this.txD_merl_expdate1.ReadOnly = true;
            this.txD_merl_expdate1.Size = new System.Drawing.Size(152, 39);
            this.txD_merl_expdate1.TabIndex = 208;
            this.txD_merl_expdate1.Text = "expdate";
            // 
            // lbD_merl_expdate1
            // 
            this.lbD_merl_expdate1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbD_merl_expdate1.ForeColor = System.Drawing.Color.White;
            this.lbD_merl_expdate1.Location = new System.Drawing.Point(15, 11);
            this.lbD_merl_expdate1.Name = "lbD_merl_expdate1";
            this.lbD_merl_expdate1.Size = new System.Drawing.Size(208, 39);
            this.lbD_merl_expdate1.TabIndex = 207;
            this.lbD_merl_expdate1.Text = "效期";
            this.lbD_merl_expdate1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txS_recs_slodid1
            // 
            this.txS_recs_slodid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_recs_slodid1.Font = new System.Drawing.Font("新細明體", 36F);
            this.txS_recs_slodid1.Location = new System.Drawing.Point(171, 183);
            this.txS_recs_slodid1.Name = "txS_recs_slodid1";
            this.txS_recs_slodid1.ReadOnly = true;
            this.txS_recs_slodid1.Size = new System.Drawing.Size(200, 58);
            this.txS_recs_slodid1.TabIndex = 210;
            // 
            // btn_ShowDetail
            // 
            this.btn_ShowDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowDetail.Font = new System.Drawing.Font("新細明體", 28F);
            this.btn_ShowDetail.Location = new System.Drawing.Point(21, 551);
            this.btn_ShowDetail.Name = "btn_ShowDetail";
            this.btn_ShowDetail.Size = new System.Drawing.Size(305, 97);
            this.btn_ShowDetail.TabIndex = 3;
            this.btn_ShowDetail.Text = "顯示詳細資訊";
            this.btn_ShowDetail.UseVisualStyleBackColor = true;
            this.btn_ShowDetail.Click += new System.EventHandler(this.Show_Click);
            // 
            // txS_PickCag
            // 
            this.txS_PickCag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_PickCag.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txS_PickCag.Location = new System.Drawing.Point(807, 183);
            this.txS_PickCag.Name = "txS_PickCag";
            this.txS_PickCag.ReadOnly = true;
            this.txS_PickCag.Size = new System.Drawing.Size(150, 58);
            this.txS_PickCag.TabIndex = 322;
            // 
            // lbS_PickCag
            // 
            this.lbS_PickCag.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_PickCag.ForeColor = System.Drawing.Color.White;
            this.lbS_PickCag.Location = new System.Drawing.Point(656, 195);
            this.lbS_PickCag.Name = "lbS_PickCag";
            this.lbS_PickCag.Size = new System.Drawing.Size(150, 39);
            this.lbS_PickCag.TabIndex = 321;
            this.lbS_PickCag.Text = "商品大類";
            // 
            // txS_slom_1qty
            // 
            this.txS_slom_1qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_slom_1qty.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txS_slom_1qty.Location = new System.Drawing.Point(807, 243);
            this.txS_slom_1qty.Name = "txS_slom_1qty";
            this.txS_slom_1qty.ReadOnly = true;
            this.txS_slom_1qty.Size = new System.Drawing.Size(150, 58);
            this.txS_slom_1qty.TabIndex = 324;
            // 
            // lbS_slom_1qty
            // 
            this.lbS_slom_1qty.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_slom_1qty.ForeColor = System.Drawing.Color.White;
            this.lbS_slom_1qty.Location = new System.Drawing.Point(656, 255);
            this.lbS_slom_1qty.Name = "lbS_slom_1qty";
            this.lbS_slom_1qty.Size = new System.Drawing.Size(150, 39);
            this.lbS_slom_1qty.TabIndex = 323;
            this.lbS_slom_1qty.Text = "揀位庫存";
            // 
            // lbL_repi_replqty_out_box_value
            // 
            this.lbL_repi_replqty_out_box_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbL_repi_replqty_out_box_value.ForeColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_box_value.Location = new System.Drawing.Point(310, 243);
            this.lbL_repi_replqty_out_box_value.Name = "lbL_repi_replqty_out_box_value";
            this.lbL_repi_replqty_out_box_value.Size = new System.Drawing.Size(121, 62);
            this.lbL_repi_replqty_out_box_value.TabIndex = 325;
            this.lbL_repi_replqty_out_box_value.Text = "999";
            this.lbL_repi_replqty_out_box_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbL_repi_replqty_out_box_value.TextChanged += new System.EventHandler(this.lbL_repi_replqty_out_box_value_TextChanged);
            // 
            // lbL_repi_replqty_out_box
            // 
            this.lbL_repi_replqty_out_box.Font = new System.Drawing.Font("新細明體", 48F);
            this.lbL_repi_replqty_out_box.ForeColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_box.Location = new System.Drawing.Point(412, 243);
            this.lbL_repi_replqty_out_box.Name = "lbL_repi_replqty_out_box";
            this.lbL_repi_replqty_out_box.Size = new System.Drawing.Size(80, 62);
            this.lbL_repi_replqty_out_box.TabIndex = 326;
            this.lbL_repi_replqty_out_box.Text = "箱";
            this.lbL_repi_replqty_out_box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbL_repi_replqty_out_pallet_value
            // 
            this.lbL_repi_replqty_out_pallet_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbL_repi_replqty_out_pallet_value.ForeColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_pallet_value.Location = new System.Drawing.Point(480, 243);
            this.lbL_repi_replqty_out_pallet_value.Name = "lbL_repi_replqty_out_pallet_value";
            this.lbL_repi_replqty_out_pallet_value.Size = new System.Drawing.Size(122, 62);
            this.lbL_repi_replqty_out_pallet_value.TabIndex = 328;
            this.lbL_repi_replqty_out_pallet_value.Text = "999";
            this.lbL_repi_replqty_out_pallet_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbL_repi_replqty_out_pallet_value.TextChanged += new System.EventHandler(this.lbL_repi_replqty_out_box_value_TextChanged);
            // 
            // lbL_repi_replqty_out_pallet
            // 
            this.lbL_repi_replqty_out_pallet.Font = new System.Drawing.Font("新細明體", 48F);
            this.lbL_repi_replqty_out_pallet.ForeColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_pallet.Location = new System.Drawing.Point(582, 243);
            this.lbL_repi_replqty_out_pallet.Name = "lbL_repi_replqty_out_pallet";
            this.lbL_repi_replqty_out_pallet.Size = new System.Drawing.Size(80, 62);
            this.lbL_repi_replqty_out_pallet.TabIndex = 327;
            this.lbL_repi_replqty_out_pallet.Text = "組";
            this.lbL_repi_replqty_out_pallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ABC
            // 
            this.lbl_ABC.BackColor = System.Drawing.Color.Yellow;
            this.lbl_ABC.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ABC.Location = new System.Drawing.Point(583, 131);
            this.lbl_ABC.Name = "lbl_ABC";
            this.lbl_ABC.Size = new System.Drawing.Size(40, 40);
            this.lbl_ABC.TabIndex = 330;
            this.lbl_ABC.Tag = "ABCkind";
            this.lbl_ABC.Text = "A";
            this.lbl_ABC.Visible = false;
            this.lbl_ABC.TextChanged += new System.EventHandler(this.lbl_ABC_TextChanged);
            // 
            // txI_merp_unitNO1
            // 
            this.txI_merp_unitNO1.AutoSize = true;
            this.txI_merp_unitNO1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txI_merp_unitNO1.ForeColor = System.Drawing.Color.White;
            this.txI_merp_unitNO1.Location = new System.Drawing.Point(436, 307);
            this.txI_merp_unitNO1.Name = "txI_merp_unitNO1";
            this.txI_merp_unitNO1.Size = new System.Drawing.Size(43, 16);
            this.txI_merp_unitNO1.TabIndex = 331;
            this.txI_merp_unitNO1.Text = "Unit1";
            // 
            // txI_merp_unitNO2
            // 
            this.txI_merp_unitNO2.AutoSize = true;
            this.txI_merp_unitNO2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txI_merp_unitNO2.ForeColor = System.Drawing.Color.White;
            this.txI_merp_unitNO2.Location = new System.Drawing.Point(601, 307);
            this.txI_merp_unitNO2.Name = "txI_merp_unitNO2";
            this.txI_merp_unitNO2.Size = new System.Drawing.Size(43, 16);
            this.txI_merp_unitNO2.TabIndex = 332;
            this.txI_merp_unitNO2.Text = "Unit2";
            // 
            // BW_checkSlodId
            // 
            this.BW_checkSlodId.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_checkSlodId_DoWork);
            this.BW_checkSlodId.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_checkSlodId_RunWorkerCompleted);
            // 
            // BW_checkPltNo
            // 
            this.BW_checkPltNo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_checkPltNo_DoWork);
            this.BW_checkPltNo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_checkPltNo_RunWorkerCompleted);
            // 
            // BW_ReciPutCfm
            // 
            this.BW_ReciPutCfm.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_ReciPutCfm_DoWork);
            this.BW_ReciPutCfm.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_ReciPutCfm_RunWorkerCompleted);
            // 
            // lbl_mergFlag
            // 
            this.lbl_mergFlag.BackColor = System.Drawing.Color.Yellow;
            this.lbl_mergFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_mergFlag.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_mergFlag.Location = new System.Drawing.Point(480, 3);
            this.lbl_mergFlag.Name = "lbl_mergFlag";
            this.lbl_mergFlag.Size = new System.Drawing.Size(121, 57);
            this.lbl_mergFlag.TabIndex = 333;
            this.lbl_mergFlag.Tag = "ABCkind";
            this.lbl_mergFlag.Text = "併板";
            this.lbl_mergFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mergflagList
            // 
            this.btn_mergflagList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mergflagList.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_mergflagList.Location = new System.Drawing.Point(958, 63);
            this.btn_mergflagList.Name = "btn_mergflagList";
            this.btn_mergflagList.Size = new System.Drawing.Size(54, 58);
            this.btn_mergflagList.TabIndex = 334;
            this.btn_mergflagList.Text = "1/4";
            this.btn_mergflagList.UseVisualStyleBackColor = true;
            this.btn_mergflagList.Click += new System.EventHandler(this.btn_mergflagList_Click);
            // 
            // Form3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.btn_mergflagList);
            this.Controls.Add(this.lbl_mergFlag);
            this.Controls.Add(this.lbl_ABC);
            this.Controls.Add(this.lbL_repi_replqty_out_pallet);
            this.Controls.Add(this.lbL_repi_replqty_out_box);
            this.Controls.Add(this.txI_merp_unitNO2);
            this.Controls.Add(this.txI_merp_unitNO1);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.lbL_repi_replqty_out_pallet_value);
            this.Controls.Add(this.lbL_repi_replqty_out_box_value);
            this.Controls.Add(this.txS_slom_1qty);
            this.Controls.Add(this.lbS_slom_1qty);
            this.Controls.Add(this.txS_PickCag);
            this.Controls.Add(this.lbS_PickCag);
            this.Controls.Add(this.btn_ShowDetail);
            this.Controls.Add(this.txS_slod_pick);
            this.Controls.Add(this.lbS_slod_pick);
            this.Controls.Add(this.txS_recs_slodid1);
            this.Controls.Add(this.txMessage);
            this.Controls.Add(this.lbS_recs_slodidNew1);
            this.Controls.Add(this.txL_recs_takenum1);
            this.Controls.Add(this.txN_merd_name1);
            this.Controls.Add(this.txS_merp_barcode1);
            this.Controls.Add(this.cummit);
            this.Controls.Add(this.txS_recs_slodidNew1);
            this.Controls.Add(this.txL_recs_id1);
            this.Controls.Add(this.lbN_merd_name1);
            this.Controls.Add(this.lbL_recs_takenum1);
            this.Controls.Add(this.lbS_merp_barcode1);
            this.Controls.Add(this.lbL_recs_id1);
            this.Name = "Form3_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3_1";
            this.Load += new System.EventHandler(this.Form3_1_Load);
            this.Controls.SetChildIndex(this.lbL_recs_id1, 0);
            this.Controls.SetChildIndex(this.lbS_merp_barcode1, 0);
            this.Controls.SetChildIndex(this.lbL_recs_takenum1, 0);
            this.Controls.SetChildIndex(this.lbN_merd_name1, 0);
            this.Controls.SetChildIndex(this.txL_recs_id1, 0);
            this.Controls.SetChildIndex(this.txS_recs_slodidNew1, 0);
            this.Controls.SetChildIndex(this.cummit, 0);
            this.Controls.SetChildIndex(this.txS_merp_barcode1, 0);
            this.Controls.SetChildIndex(this.txN_merd_name1, 0);
            this.Controls.SetChildIndex(this.txL_recs_takenum1, 0);
            this.Controls.SetChildIndex(this.lbS_recs_slodidNew1, 0);
            this.Controls.SetChildIndex(this.txMessage, 0);
            this.Controls.SetChildIndex(this.txS_recs_slodid1, 0);
            this.Controls.SetChildIndex(this.lbS_slod_pick, 0);
            this.Controls.SetChildIndex(this.txS_slod_pick, 0);
            this.Controls.SetChildIndex(this.btn_ShowDetail, 0);
            this.Controls.SetChildIndex(this.lbS_PickCag, 0);
            this.Controls.SetChildIndex(this.txS_PickCag, 0);
            this.Controls.SetChildIndex(this.lbS_slom_1qty, 0);
            this.Controls.SetChildIndex(this.txS_slom_1qty, 0);
            this.Controls.SetChildIndex(this.lbL_repi_replqty_out_box_value, 0);
            this.Controls.SetChildIndex(this.lbL_repi_replqty_out_pallet_value, 0);
            this.Controls.SetChildIndex(this.Details, 0);
            this.Controls.SetChildIndex(this.txI_merp_unitNO1, 0);
            this.Controls.SetChildIndex(this.txI_merp_unitNO2, 0);
            this.Controls.SetChildIndex(this.lbL_repi_replqty_out_box, 0);
            this.Controls.SetChildIndex(this.lbL_repi_replqty_out_pallet, 0);
            this.Controls.SetChildIndex(this.lbl_ABC, 0);
            this.Controls.SetChildIndex(this.lbl_mergFlag, 0);
            this.Controls.SetChildIndex(this.btn_mergflagList, 0);
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbL_recs_id1;
        private System.Windows.Forms.Label lbN_merd_name1;
        private System.Windows.Forms.Label lbL_recs_takenum1;
        private System.Windows.Forms.Label lbS_merp_barcode1;
        private System.Windows.Forms.TextBox txL_recs_id1;
        private System.Windows.Forms.TextBox txS_recs_slodidNew1;
        private System.Windows.Forms.TextBox txS_merp_barcode1;
        private System.Windows.Forms.TextBox txN_merd_name1;
        private System.Windows.Forms.TextBox txL_recs_takenum1;
        private System.Windows.Forms.Label lbS_recs_slodidNew1;
        private System.Windows.Forms.Label txMessage;
        private System.Windows.Forms.Label lbS_slod_pick;
        private System.Windows.Forms.TextBox txS_slod_pick;
        private System.Windows.Forms.Panel Details;
        private System.Windows.Forms.TextBox txD_merl_expdate1;
        private System.Windows.Forms.Label lbD_merl_expdate1;
        private System.Windows.Forms.TextBox txL_recs_merlsysno;
        private System.Windows.Forms.TextBox txL_recs_recrid;
        private System.Windows.Forms.TextBox txS_merl_lotno1;
        private System.Windows.Forms.TextBox txS_merl_merpgroup1;
        private System.Windows.Forms.Label lbL_recs_merlsysno;
        private System.Windows.Forms.Label lbL_recs_recrid;
        private System.Windows.Forms.Label lbS_merl_lotno1;
        private System.Windows.Forms.Label lbS_merl_merpgroup1;
        private System.Windows.Forms.TextBox txS_recs_slodid1;
        private System.Windows.Forms.Label lbS_recs_slodid1;
        private System.Windows.Forms.TextBox txS_PickCag;
        private System.Windows.Forms.Label lbS_PickCag;
        private System.Windows.Forms.TextBox txS_slom_1qty;
        private System.Windows.Forms.Label lbS_slom_1qty;
        private System.Windows.Forms.Label lbL_repi_replqty_out_box_value;
        private System.Windows.Forms.Label lbL_repi_replqty_out_box;
        private System.Windows.Forms.Label lbL_repi_replqty_out_pallet_value;
        private System.Windows.Forms.Label lbL_repi_replqty_out_pallet;
        private System.Windows.Forms.TextBox txb_OwnerID;
        private System.Windows.Forms.TextBox txb_MerdID;
        private System.Windows.Forms.TextBox txb_recsID;
        private Car_Fun.myButton cummit;
        private Car_Fun.myButton btn_ShowDetail;
        private System.Windows.Forms.Label lbl_ABC;
        private System.Windows.Forms.Label txI_merp_unitNO1;
        private System.Windows.Forms.Label txI_merp_unitNO2;
        private System.ComponentModel.BackgroundWorker BW_checkSlodId;
        private System.ComponentModel.BackgroundWorker BW_checkPltNo;
        private System.ComponentModel.BackgroundWorker BW_ReciPutCfm;
        private System.Windows.Forms.Label lbl_mergFlag;
        private Car_Fun.myButton btn_mergflagList;
    }
}