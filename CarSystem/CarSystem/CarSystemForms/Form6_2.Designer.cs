namespace CarSystem
{
    partial class Form6_2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbg_SelectMode = new System.Windows.Forms.TabPage();
            this.btn_Seltype_Cute = new Car_Fun.myButton();
            this.btn_Seltype_Normal = new Car_Fun.myButton();
            this.tbg_SelectArea = new System.Windows.Forms.TabPage();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.Lbl_Item_SuccessMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_OrderNo = new System.Windows.Forms.DataGridView();
            this.col_dgvOrderNo_OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvOrderNo_Zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvOrderNo_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSB_OrderNo = new System.Windows.Forms.VScrollBar();
            this.lb_ResultMsg_SelectWorkArea_In_Warn = new System.Windows.Forms.Label();
            this.lb_ResultMsg_SelectWorkArea_Out_Warn = new System.Windows.Forms.Label();
            this.tbg_WorkContent = new System.Windows.Forms.TabPage();
            this.lbl_L_repi_replqty = new System.Windows.Forms.Label();
            this.lbl_L_repi_sysno = new System.Windows.Forms.Label();
            this.txMessage = new System.Windows.Forms.Label();
            this.txb_S_merd_id = new System.Windows.Forms.TextBox();
            this.lbl_Mode2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_PickOther = new System.Windows.Forms.DataGridView();
            this.col_dgvPickOther_Select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPickOther_Slodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPickOther_barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPickOther_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSB_PickOther = new System.Windows.Forms.VScrollBar();
            this.txb_Inslodid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txL_recs_takenum = new System.Windows.Forms.TextBox();
            this.lbL_recs_takenum1 = new System.Windows.Forms.Label();
            this.txN_merd_name = new System.Windows.Forms.TextBox();
            this.lbN_merd_name1 = new System.Windows.Forms.Label();
            this.txS_merp_barcode = new System.Windows.Forms.TextBox();
            this.lbS_merp_barcode1 = new System.Windows.Forms.Label();
            this.txS_recs_slodid = new System.Windows.Forms.TextBox();
            this.lbS_recs_slodidNew1 = new System.Windows.Forms.Label();
            this.txS_recs_slodidNew = new System.Windows.Forms.TextBox();
            this.lbl_OrderNo = new System.Windows.Forms.Label();
            this.tbg_ReturnContent = new System.Windows.Forms.TabPage();
            this.txMessage2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Return_slodid = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGV_Return = new System.Windows.Forms.DataGridView();
            this.col_dgvReturn_Slodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvReturn_barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvReturn_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSB_Return = new System.Windows.Forms.VScrollBar();
            this.tabControl1.SuspendLayout();
            this.tbg_SelectMode.SuspendLayout();
            this.tbg_SelectArea.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OrderNo)).BeginInit();
            this.tbg_WorkContent.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PickOther)).BeginInit();
            this.tbg_ReturnContent.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbg_SelectMode);
            this.tabControl1.Controls.Add(this.tbg_SelectArea);
            this.tabControl1.Controls.Add(this.tbg_WorkContent);
            this.tabControl1.Controls.Add(this.tbg_ReturnContent);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 568);
            this.tabControl1.TabIndex = 36;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbg_SelectMode
            // 
            this.tbg_SelectMode.BackColor = System.Drawing.Color.Black;
            this.tbg_SelectMode.Controls.Add(this.btn_Seltype_Cute);
            this.tbg_SelectMode.Controls.Add(this.btn_Seltype_Normal);
            this.tbg_SelectMode.Location = new System.Drawing.Point(4, 30);
            this.tbg_SelectMode.Name = "tbg_SelectMode";
            this.tbg_SelectMode.Size = new System.Drawing.Size(1008, 534);
            this.tbg_SelectMode.TabIndex = 2;
            this.tbg_SelectMode.Text = "選擇單據類別";
            this.tbg_SelectMode.UseVisualStyleBackColor = true;
            // 
            // btn_Seltype_Cute
            // 
            this.btn_Seltype_Cute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Seltype_Cute.Font = new System.Drawing.Font("細明體", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Seltype_Cute.ForeColor = System.Drawing.Color.White;
            this.btn_Seltype_Cute.Location = new System.Drawing.Point(572, 108);
            this.btn_Seltype_Cute.Name = "btn_Seltype_Cute";
            this.btn_Seltype_Cute.Size = new System.Drawing.Size(341, 341);
            this.btn_Seltype_Cute.TabIndex = 1;
            this.btn_Seltype_Cute.Text = "截單補貨";
            this.btn_Seltype_Cute.UseVisualStyleBackColor = true;
            this.btn_Seltype_Cute.Click += new System.EventHandler(this.btn_Seltype_Cute_Click);
            // 
            // btn_Seltype_Normal
            // 
            this.btn_Seltype_Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Seltype_Normal.Font = new System.Drawing.Font("細明體", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Seltype_Normal.ForeColor = System.Drawing.Color.White;
            this.btn_Seltype_Normal.Location = new System.Drawing.Point(87, 108);
            this.btn_Seltype_Normal.Name = "btn_Seltype_Normal";
            this.btn_Seltype_Normal.Size = new System.Drawing.Size(341, 341);
            this.btn_Seltype_Normal.TabIndex = 0;
            this.btn_Seltype_Normal.Text = "一般補貨";
            this.btn_Seltype_Normal.UseVisualStyleBackColor = true;
            this.btn_Seltype_Normal.Click += new System.EventHandler(this.btn_Seltype_Normal_Click);
            // 
            // tbg_SelectArea
            // 
            this.tbg_SelectArea.BackColor = System.Drawing.Color.Black;
            this.tbg_SelectArea.Controls.Add(this.lbl_Mode);
            this.tbg_SelectArea.Controls.Add(this.Lbl_Item_SuccessMessage);
            this.tbg_SelectArea.Controls.Add(this.panel1);
            this.tbg_SelectArea.Controls.Add(this.lb_ResultMsg_SelectWorkArea_In_Warn);
            this.tbg_SelectArea.Controls.Add(this.lb_ResultMsg_SelectWorkArea_Out_Warn);
            this.tbg_SelectArea.Location = new System.Drawing.Point(4, 30);
            this.tbg_SelectArea.Name = "tbg_SelectArea";
            this.tbg_SelectArea.Padding = new System.Windows.Forms.Padding(3);
            this.tbg_SelectArea.Size = new System.Drawing.Size(1008, 534);
            this.tbg_SelectArea.TabIndex = 0;
            this.tbg_SelectArea.Text = "指定單號";
            this.tbg_SelectArea.UseVisualStyleBackColor = true;
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Mode.ForeColor = System.Drawing.Color.White;
            this.lbl_Mode.Location = new System.Drawing.Point(0, 0);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(110, 39);
            this.lbl_Mode.TabIndex = 336;
            this.lbl_Mode.Text = "Mode";
            // 
            // Lbl_Item_SuccessMessage
            // 
            this.Lbl_Item_SuccessMessage.AutoSize = true;
            this.Lbl_Item_SuccessMessage.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Item_SuccessMessage.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Item_SuccessMessage.Location = new System.Drawing.Point(342, 5);
            this.Lbl_Item_SuccessMessage.MaximumSize = new System.Drawing.Size(400, 0);
            this.Lbl_Item_SuccessMessage.Name = "Lbl_Item_SuccessMessage";
            this.Lbl_Item_SuccessMessage.Size = new System.Drawing.Size(308, 48);
            this.Lbl_Item_SuccessMessage.TabIndex = 70;
            this.Lbl_Item_SuccessMessage.Text = "選擇補貨單據";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGV_OrderNo);
            this.panel1.Controls.Add(this.vSB_OrderNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 441);
            this.panel1.TabIndex = 69;
            // 
            // DGV_OrderNo
            // 
            this.DGV_OrderNo.AllowUserToAddRows = false;
            this.DGV_OrderNo.AllowUserToDeleteRows = false;
            this.DGV_OrderNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_OrderNo.ColumnHeadersHeight = 41;
            this.DGV_OrderNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvOrderNo_OrderNo,
            this.col_dgvOrderNo_Zone,
            this.col_dgvOrderNo_Status});
            this.DGV_OrderNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_OrderNo.Location = new System.Drawing.Point(0, 0);
            this.DGV_OrderNo.Name = "DGV_OrderNo";
            this.DGV_OrderNo.ReadOnly = true;
            this.DGV_OrderNo.RowHeadersVisible = false;
            this.DGV_OrderNo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGV_OrderNo.RowTemplate.Height = 80;
            this.DGV_OrderNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_OrderNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_OrderNo.Size = new System.Drawing.Size(945, 441);
            this.DGV_OrderNo.TabIndex = 67;
            this.DGV_OrderNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_OrderNo_CellClick);
            // 
            // col_dgvOrderNo_OrderNo
            // 
            this.col_dgvOrderNo_OrderNo.DataPropertyName = "L_reph_id";
            this.col_dgvOrderNo_OrderNo.HeaderText = "單號";
            this.col_dgvOrderNo_OrderNo.Name = "col_dgvOrderNo_OrderNo";
            this.col_dgvOrderNo_OrderNo.ReadOnly = true;
            // 
            // col_dgvOrderNo_Zone
            // 
            this.col_dgvOrderNo_Zone.DataPropertyName = "S_reph_sechid";
            this.col_dgvOrderNo_Zone.HeaderText = "作業區域";
            this.col_dgvOrderNo_Zone.Name = "col_dgvOrderNo_Zone";
            this.col_dgvOrderNo_Zone.ReadOnly = true;
            // 
            // col_dgvOrderNo_Status
            // 
            this.col_dgvOrderNo_Status.DataPropertyName = "S_reph_flag";
            this.col_dgvOrderNo_Status.HeaderText = "狀態";
            this.col_dgvOrderNo_Status.Name = "col_dgvOrderNo_Status";
            this.col_dgvOrderNo_Status.ReadOnly = true;
            // 
            // vSB_OrderNo
            // 
            this.vSB_OrderNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.vSB_OrderNo.Location = new System.Drawing.Point(945, 0);
            this.vSB_OrderNo.Name = "vSB_OrderNo";
            this.vSB_OrderNo.Size = new System.Drawing.Size(57, 441);
            this.vSB_OrderNo.TabIndex = 68;
            // 
            // lb_ResultMsg_SelectWorkArea_In_Warn
            // 
            this.lb_ResultMsg_SelectWorkArea_In_Warn.AutoSize = true;
            this.lb_ResultMsg_SelectWorkArea_In_Warn.BackColor = System.Drawing.Color.Black;
            this.lb_ResultMsg_SelectWorkArea_In_Warn.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_ResultMsg_SelectWorkArea_In_Warn.ForeColor = System.Drawing.Color.Red;
            this.lb_ResultMsg_SelectWorkArea_In_Warn.Location = new System.Drawing.Point(553, 589);
            this.lb_ResultMsg_SelectWorkArea_In_Warn.Name = "lb_ResultMsg_SelectWorkArea_In_Warn";
            this.lb_ResultMsg_SelectWorkArea_In_Warn.Size = new System.Drawing.Size(404, 48);
            this.lb_ResultMsg_SelectWorkArea_In_Warn.TabIndex = 62;
            this.lb_ResultMsg_SelectWorkArea_In_Warn.Tag = "Warning";
            this.lb_ResultMsg_SelectWorkArea_In_Warn.Text = "指定移入作業區域";
            // 
            // lb_ResultMsg_SelectWorkArea_Out_Warn
            // 
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.AutoSize = true;
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.BackColor = System.Drawing.Color.Black;
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.ForeColor = System.Drawing.Color.Red;
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.Location = new System.Drawing.Point(4, 589);
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.Name = "lb_ResultMsg_SelectWorkArea_Out_Warn";
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.Size = new System.Drawing.Size(404, 48);
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.TabIndex = 60;
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.Tag = "Warning";
            this.lb_ResultMsg_SelectWorkArea_Out_Warn.Text = "指定移出作業區域";
            // 
            // tbg_WorkContent
            // 
            this.tbg_WorkContent.BackColor = System.Drawing.Color.Black;
            this.tbg_WorkContent.Controls.Add(this.lbl_L_repi_replqty);
            this.tbg_WorkContent.Controls.Add(this.lbl_L_repi_sysno);
            this.tbg_WorkContent.Controls.Add(this.txMessage);
            this.tbg_WorkContent.Controls.Add(this.txb_S_merd_id);
            this.tbg_WorkContent.Controls.Add(this.lbl_Mode2);
            this.tbg_WorkContent.Controls.Add(this.panel2);
            this.tbg_WorkContent.Controls.Add(this.txb_Inslodid);
            this.tbg_WorkContent.Controls.Add(this.label1);
            this.tbg_WorkContent.Controls.Add(this.txL_recs_takenum);
            this.tbg_WorkContent.Controls.Add(this.lbL_recs_takenum1);
            this.tbg_WorkContent.Controls.Add(this.txN_merd_name);
            this.tbg_WorkContent.Controls.Add(this.lbN_merd_name1);
            this.tbg_WorkContent.Controls.Add(this.txS_merp_barcode);
            this.tbg_WorkContent.Controls.Add(this.lbS_merp_barcode1);
            this.tbg_WorkContent.Controls.Add(this.txS_recs_slodid);
            this.tbg_WorkContent.Controls.Add(this.lbS_recs_slodidNew1);
            this.tbg_WorkContent.Controls.Add(this.txS_recs_slodidNew);
            this.tbg_WorkContent.Controls.Add(this.lbl_OrderNo);
            this.tbg_WorkContent.ForeColor = System.Drawing.Color.White;
            this.tbg_WorkContent.Location = new System.Drawing.Point(4, 30);
            this.tbg_WorkContent.Name = "tbg_WorkContent";
            this.tbg_WorkContent.Padding = new System.Windows.Forms.Padding(3);
            this.tbg_WorkContent.Size = new System.Drawing.Size(1008, 534);
            this.tbg_WorkContent.TabIndex = 1;
            this.tbg_WorkContent.Text = "移出作業";
            this.tbg_WorkContent.UseVisualStyleBackColor = true;
            // 
            // lbl_L_repi_replqty
            // 
            this.lbl_L_repi_replqty.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_L_repi_replqty.ForeColor = System.Drawing.Color.White;
            this.lbl_L_repi_replqty.Location = new System.Drawing.Point(576, 62);
            this.lbl_L_repi_replqty.Name = "lbl_L_repi_replqty";
            this.lbl_L_repi_replqty.Size = new System.Drawing.Size(122, 20);
            this.lbl_L_repi_replqty.TabIndex = 339;
            this.lbl_L_repi_replqty.Text = "repi_replqty";
            // 
            // lbl_L_repi_sysno
            // 
            this.lbl_L_repi_sysno.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_L_repi_sysno.ForeColor = System.Drawing.Color.White;
            this.lbl_L_repi_sysno.Location = new System.Drawing.Point(576, 37);
            this.lbl_L_repi_sysno.Name = "lbl_L_repi_sysno";
            this.lbl_L_repi_sysno.Size = new System.Drawing.Size(122, 20);
            this.lbl_L_repi_sysno.TabIndex = 338;
            this.lbl_L_repi_sysno.Text = "repi_sysno";
            // 
            // txMessage
            // 
            this.txMessage.AutoSize = true;
            this.txMessage.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txMessage.ForeColor = System.Drawing.Color.Red;
            this.txMessage.Location = new System.Drawing.Point(8, 285);
            this.txMessage.Name = "txMessage";
            this.txMessage.Size = new System.Drawing.Size(260, 48);
            this.txMessage.TabIndex = 337;
            this.txMessage.Text = "請刷入儲位";
            // 
            // txb_S_merd_id
            // 
            this.txb_S_merd_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_S_merd_id.Font = new System.Drawing.Font("新細明體", 36F);
            this.txb_S_merd_id.Location = new System.Drawing.Point(526, 97);
            this.txb_S_merd_id.Name = "txb_S_merd_id";
            this.txb_S_merd_id.ReadOnly = true;
            this.txb_S_merd_id.Size = new System.Drawing.Size(200, 58);
            this.txb_S_merd_id.TabIndex = 336;
            // 
            // lbl_Mode2
            // 
            this.lbl_Mode2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Mode2.ForeColor = System.Drawing.Color.White;
            this.lbl_Mode2.Location = new System.Drawing.Point(0, 0);
            this.lbl_Mode2.Name = "lbl_Mode2";
            this.lbl_Mode2.Size = new System.Drawing.Size(110, 39);
            this.lbl_Mode2.TabIndex = 335;
            this.lbl_Mode2.Text = "Mode";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV_PickOther);
            this.panel2.Controls.Add(this.vSB_PickOther);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 212);
            this.panel2.TabIndex = 334;
            // 
            // DGV_PickOther
            // 
            this.DGV_PickOther.AllowUserToAddRows = false;
            this.DGV_PickOther.AllowUserToDeleteRows = false;
            this.DGV_PickOther.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PickOther.ColumnHeadersHeight = 41;
            this.DGV_PickOther.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvPickOther_Select,
            this.col_dgvPickOther_Slodid,
            this.col_dgvPickOther_barcode,
            this.col_dgvPickOther_Qty});
            this.DGV_PickOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PickOther.Location = new System.Drawing.Point(0, 0);
            this.DGV_PickOther.Name = "DGV_PickOther";
            this.DGV_PickOther.ReadOnly = true;
            this.DGV_PickOther.RowHeadersVisible = false;
            this.DGV_PickOther.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGV_PickOther.RowTemplate.Height = 80;
            this.DGV_PickOther.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_PickOther.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PickOther.Size = new System.Drawing.Size(945, 212);
            this.DGV_PickOther.TabIndex = 67;
            // 
            // col_dgvPickOther_Select
            // 
            this.col_dgvPickOther_Select.DataPropertyName = "Select";
            this.col_dgvPickOther_Select.HeaderText = "選擇";
            this.col_dgvPickOther_Select.Name = "col_dgvPickOther_Select";
            this.col_dgvPickOther_Select.ReadOnly = true;
            // 
            // col_dgvPickOther_Slodid
            // 
            this.col_dgvPickOther_Slodid.DataPropertyName = "S_slod_id";
            dataGridViewCellStyle7.Format = "yyyy/MM/dd";
            this.col_dgvPickOther_Slodid.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_dgvPickOther_Slodid.HeaderText = "揀貨儲位";
            this.col_dgvPickOther_Slodid.Name = "col_dgvPickOther_Slodid";
            this.col_dgvPickOther_Slodid.ReadOnly = true;
            // 
            // col_dgvPickOther_barcode
            // 
            this.col_dgvPickOther_barcode.DataPropertyName = "S_merp_barcode";
            this.col_dgvPickOther_barcode.HeaderText = "商品條碼";
            this.col_dgvPickOther_barcode.Name = "col_dgvPickOther_barcode";
            this.col_dgvPickOther_barcode.ReadOnly = true;
            // 
            // col_dgvPickOther_Qty
            // 
            this.col_dgvPickOther_Qty.DataPropertyName = "qty";
            this.col_dgvPickOther_Qty.HeaderText = "可用量";
            this.col_dgvPickOther_Qty.Name = "col_dgvPickOther_Qty";
            this.col_dgvPickOther_Qty.ReadOnly = true;
            // 
            // vSB_PickOther
            // 
            this.vSB_PickOther.Dock = System.Windows.Forms.DockStyle.Right;
            this.vSB_PickOther.Location = new System.Drawing.Point(945, 0);
            this.vSB_PickOther.Name = "vSB_PickOther";
            this.vSB_PickOther.Size = new System.Drawing.Size(57, 212);
            this.vSB_PickOther.TabIndex = 68;
            // 
            // txb_Inslodid
            // 
            this.txb_Inslodid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Inslodid.Font = new System.Drawing.Font("新細明體", 36F);
            this.txb_Inslodid.Location = new System.Drawing.Point(526, 217);
            this.txb_Inslodid.Name = "txb_Inslodid";
            this.txb_Inslodid.ReadOnly = true;
            this.txb_Inslodid.Size = new System.Drawing.Size(200, 58);
            this.txb_Inslodid.TabIndex = 332;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 333;
            this.label1.Text = "移入儲位";
            // 
            // txL_recs_takenum
            // 
            this.txL_recs_takenum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txL_recs_takenum.Font = new System.Drawing.Font("新細明體", 36F);
            this.txL_recs_takenum.Location = new System.Drawing.Point(164, 217);
            this.txL_recs_takenum.Name = "txL_recs_takenum";
            this.txL_recs_takenum.ReadOnly = true;
            this.txL_recs_takenum.Size = new System.Drawing.Size(200, 58);
            this.txL_recs_takenum.TabIndex = 331;
            // 
            // lbL_recs_takenum1
            // 
            this.lbL_recs_takenum1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbL_recs_takenum1.ForeColor = System.Drawing.Color.White;
            this.lbL_recs_takenum1.Location = new System.Drawing.Point(8, 229);
            this.lbL_recs_takenum1.Name = "lbL_recs_takenum1";
            this.lbL_recs_takenum1.Size = new System.Drawing.Size(150, 39);
            this.lbL_recs_takenum1.TabIndex = 330;
            this.lbL_recs_takenum1.Text = "移出數量";
            // 
            // txN_merd_name
            // 
            this.txN_merd_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txN_merd_name.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txN_merd_name.Location = new System.Drawing.Point(164, 157);
            this.txN_merd_name.Name = "txN_merd_name";
            this.txN_merd_name.ReadOnly = true;
            this.txN_merd_name.Size = new System.Drawing.Size(786, 58);
            this.txN_merd_name.TabIndex = 329;
            // 
            // lbN_merd_name1
            // 
            this.lbN_merd_name1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbN_merd_name1.ForeColor = System.Drawing.Color.White;
            this.lbN_merd_name1.Location = new System.Drawing.Point(8, 169);
            this.lbN_merd_name1.Name = "lbN_merd_name1";
            this.lbN_merd_name1.Size = new System.Drawing.Size(150, 39);
            this.lbN_merd_name1.TabIndex = 328;
            this.lbN_merd_name1.Text = "商品名稱";
            // 
            // txS_merp_barcode
            // 
            this.txS_merp_barcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_merp_barcode.Font = new System.Drawing.Font("新細明體", 36F);
            this.txS_merp_barcode.Location = new System.Drawing.Point(164, 97);
            this.txS_merp_barcode.Name = "txS_merp_barcode";
            this.txS_merp_barcode.ReadOnly = true;
            this.txS_merp_barcode.Size = new System.Drawing.Size(356, 58);
            this.txS_merp_barcode.TabIndex = 327;
            this.txS_merp_barcode.Text = "1234567890123";
            // 
            // lbS_merp_barcode1
            // 
            this.lbS_merp_barcode1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_merp_barcode1.ForeColor = System.Drawing.Color.White;
            this.lbS_merp_barcode1.Location = new System.Drawing.Point(8, 109);
            this.lbS_merp_barcode1.Name = "lbS_merp_barcode1";
            this.lbS_merp_barcode1.Size = new System.Drawing.Size(150, 39);
            this.lbS_merp_barcode1.TabIndex = 326;
            this.lbS_merp_barcode1.Text = "國際條碼";
            // 
            // txS_recs_slodid
            // 
            this.txS_recs_slodid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_recs_slodid.Font = new System.Drawing.Font("新細明體", 36F);
            this.txS_recs_slodid.Location = new System.Drawing.Point(164, 37);
            this.txS_recs_slodid.Name = "txS_recs_slodid";
            this.txS_recs_slodid.ReadOnly = true;
            this.txS_recs_slodid.Size = new System.Drawing.Size(200, 58);
            this.txS_recs_slodid.TabIndex = 324;
            this.txS_recs_slodid.Text = "AB123456";
            // 
            // lbS_recs_slodidNew1
            // 
            this.lbS_recs_slodidNew1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbS_recs_slodidNew1.ForeColor = System.Drawing.Color.White;
            this.lbS_recs_slodidNew1.Location = new System.Drawing.Point(8, 49);
            this.lbS_recs_slodidNew1.Name = "lbS_recs_slodidNew1";
            this.lbS_recs_slodidNew1.Size = new System.Drawing.Size(150, 39);
            this.lbS_recs_slodidNew1.TabIndex = 325;
            this.lbS_recs_slodidNew1.Text = "移出儲位";
            // 
            // txS_recs_slodidNew
            // 
            this.txS_recs_slodidNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txS_recs_slodidNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_recs_slodidNew.Font = new System.Drawing.Font("新細明體", 36F);
            this.txS_recs_slodidNew.ForeColor = System.Drawing.SystemColors.Window;
            this.txS_recs_slodidNew.Location = new System.Drawing.Point(366, 37);
            this.txS_recs_slodidNew.Name = "txS_recs_slodidNew";
            this.txS_recs_slodidNew.Size = new System.Drawing.Size(204, 58);
            this.txS_recs_slodidNew.TabIndex = 323;
            this.txS_recs_slodidNew.Text = "AB123456";
            this.txS_recs_slodidNew.TextChanged += new System.EventHandler(this.txS_recs_slodidNew_TextChanged);
            this.txS_recs_slodidNew.Validated += new System.EventHandler(this.txS_recs_slodidNew_Validated);
            // 
            // lbl_OrderNo
            // 
            this.lbl_OrderNo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_OrderNo.ForeColor = System.Drawing.Color.White;
            this.lbl_OrderNo.Location = new System.Drawing.Point(123, 0);
            this.lbl_OrderNo.Name = "lbl_OrderNo";
            this.lbl_OrderNo.Size = new System.Drawing.Size(237, 39);
            this.lbl_OrderNo.TabIndex = 322;
            this.lbl_OrderNo.Text = "OrderNo";
            // 
            // tbg_ReturnContent
            // 
            this.tbg_ReturnContent.BackColor = System.Drawing.Color.Black;
            this.tbg_ReturnContent.Controls.Add(this.txMessage2);
            this.tbg_ReturnContent.Controls.Add(this.label2);
            this.tbg_ReturnContent.Controls.Add(this.txb_Return_slodid);
            this.tbg_ReturnContent.Controls.Add(this.panel3);
            this.tbg_ReturnContent.Location = new System.Drawing.Point(4, 30);
            this.tbg_ReturnContent.Name = "tbg_ReturnContent";
            this.tbg_ReturnContent.Size = new System.Drawing.Size(1008, 534);
            this.tbg_ReturnContent.TabIndex = 3;
            this.tbg_ReturnContent.Text = "回庫作業";
            this.tbg_ReturnContent.UseVisualStyleBackColor = true;
            // 
            // txMessage2
            // 
            this.txMessage2.AutoSize = true;
            this.txMessage2.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txMessage2.ForeColor = System.Drawing.Color.Red;
            this.txMessage2.Location = new System.Drawing.Point(8, 285);
            this.txMessage2.Name = "txMessage2";
            this.txMessage2.Size = new System.Drawing.Size(260, 48);
            this.txMessage2.TabIndex = 338;
            this.txMessage2.Text = "請刷入儲位";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 39);
            this.label2.TabIndex = 337;
            this.label2.Text = "移入儲位";
            // 
            // txb_Return_slodid
            // 
            this.txb_Return_slodid.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txb_Return_slodid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Return_slodid.Font = new System.Drawing.Font("新細明體", 36F);
            this.txb_Return_slodid.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_Return_slodid.Location = new System.Drawing.Point(164, 37);
            this.txb_Return_slodid.Name = "txb_Return_slodid";
            this.txb_Return_slodid.Size = new System.Drawing.Size(204, 58);
            this.txb_Return_slodid.TabIndex = 336;
            this.txb_Return_slodid.TextChanged += new System.EventHandler(this.txb_Return_slodid_TextChanged);
            this.txb_Return_slodid.Validated += new System.EventHandler(this.txb_Return_slodid_Validated);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGV_Return);
            this.panel3.Controls.Add(this.vSB_Return);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 212);
            this.panel3.TabIndex = 335;
            // 
            // DGV_Return
            // 
            this.DGV_Return.AllowUserToAddRows = false;
            this.DGV_Return.AllowUserToDeleteRows = false;
            this.DGV_Return.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Return.ColumnHeadersHeight = 41;
            this.DGV_Return.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvReturn_Slodid,
            this.col_dgvReturn_barcode,
            this.col_dgvReturn_Qty});
            this.DGV_Return.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Return.Location = new System.Drawing.Point(0, 0);
            this.DGV_Return.Name = "DGV_Return";
            this.DGV_Return.ReadOnly = true;
            this.DGV_Return.RowHeadersVisible = false;
            this.DGV_Return.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGV_Return.RowTemplate.Height = 80;
            this.DGV_Return.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Return.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Return.Size = new System.Drawing.Size(951, 212);
            this.DGV_Return.TabIndex = 67;
            // 
            // col_dgvReturn_Slodid
            // 
            this.col_dgvReturn_Slodid.DataPropertyName = "OrderNo";
            dataGridViewCellStyle8.Format = "yyyy/MM/dd";
            this.col_dgvReturn_Slodid.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_dgvReturn_Slodid.HeaderText = "揀貨儲位";
            this.col_dgvReturn_Slodid.Name = "col_dgvReturn_Slodid";
            this.col_dgvReturn_Slodid.ReadOnly = true;
            // 
            // col_dgvReturn_barcode
            // 
            this.col_dgvReturn_barcode.HeaderText = "商品條碼";
            this.col_dgvReturn_barcode.Name = "col_dgvReturn_barcode";
            this.col_dgvReturn_barcode.ReadOnly = true;
            // 
            // col_dgvReturn_Qty
            // 
            this.col_dgvReturn_Qty.HeaderText = "可用量";
            this.col_dgvReturn_Qty.Name = "col_dgvReturn_Qty";
            this.col_dgvReturn_Qty.ReadOnly = true;
            // 
            // vSB_Return
            // 
            this.vSB_Return.Dock = System.Windows.Forms.DockStyle.Right;
            this.vSB_Return.Location = new System.Drawing.Point(951, 0);
            this.vSB_Return.Name = "vSB_Return";
            this.vSB_Return.Size = new System.Drawing.Size(57, 212);
            this.vSB_Return.TabIndex = 68;
            // 
            // Form6_2
            // 
            this.ClientSize = new System.Drawing.Size(1016, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form6_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form6_2_v2_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tbg_SelectMode.ResumeLayout(false);
            this.tbg_SelectArea.ResumeLayout(false);
            this.tbg_SelectArea.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OrderNo)).EndInit();
            this.tbg_WorkContent.ResumeLayout(false);
            this.tbg_WorkContent.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PickOther)).EndInit();
            this.tbg_ReturnContent.ResumeLayout(false);
            this.tbg_ReturnContent.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbg_SelectMode;
        private Car_Fun.myButton btn_Seltype_Cute;
        private Car_Fun.myButton btn_Seltype_Normal;
        private System.Windows.Forms.TabPage tbg_SelectArea;
        private System.Windows.Forms.Label lb_ResultMsg_SelectWorkArea_In_Warn;
        private System.Windows.Forms.Label lb_ResultMsg_SelectWorkArea_Out_Warn;
        private System.Windows.Forms.TabPage tbg_WorkContent;
        private System.Windows.Forms.TabPage tbg_ReturnContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vSB_OrderNo;
        private System.Windows.Forms.DataGridView DGV_OrderNo;
        private System.Windows.Forms.Label Lbl_Item_SuccessMessage;
        private System.Windows.Forms.Label lbl_OrderNo;
        private System.Windows.Forms.TextBox txS_recs_slodid;
        private System.Windows.Forms.Label lbS_recs_slodidNew1;
        private System.Windows.Forms.TextBox txS_recs_slodidNew;
        private System.Windows.Forms.TextBox txS_merp_barcode;
        private System.Windows.Forms.Label lbS_merp_barcode1;
        private System.Windows.Forms.TextBox txN_merd_name;
        private System.Windows.Forms.Label lbN_merd_name1;
        private System.Windows.Forms.TextBox txL_recs_takenum;
        private System.Windows.Forms.Label lbL_recs_takenum1;
        private System.Windows.Forms.TextBox txb_Inslodid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.VScrollBar vSB_PickOther;
        private System.Windows.Forms.DataGridView DGV_PickOther;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Return_slodid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.VScrollBar vSB_Return;
        private System.Windows.Forms.DataGridView DGV_Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvReturn_Slodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvReturn_barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvReturn_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvOrderNo_OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvOrderNo_Zone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvOrderNo_Status;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.Label lbl_Mode2;
        private System.Windows.Forms.TextBox txb_S_merd_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPickOther_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPickOther_Slodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPickOther_barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPickOther_Qty;
        private System.Windows.Forms.Label txMessage;
        private System.Windows.Forms.Label lbl_L_repi_sysno;
        private System.Windows.Forms.Label lbl_L_repi_replqty;
        private System.Windows.Forms.Label txMessage2;
    }
}
