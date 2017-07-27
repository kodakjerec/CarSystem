namespace CarSystem
{
    partial class Form9_1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Seltype_Cute = new System.Windows.Forms.Button();
            this.btn_Seltype_Normal = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbP_SelectMode = new System.Windows.Forms.TabPage();
            this.btn_Slod = new Car_Fun.myButton();
            this.btn_Item = new Car_Fun.myButton();
            this.tbP_Item = new System.Windows.Forms.TabPage();
            this.pan_Item = new System.Windows.Forms.Panel();
            this.DGV_Item = new System.Windows.Forms.DataGridView();
            this.col_DGV_Item_N_merd_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGV_Item_S_slom_slodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGV_Item_D_merl_expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGV_Item_Tqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGV_Item_TBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VSB_Item = new System.Windows.Forms.VScrollBar();
            this.Lbl_Item_SuccessMessage = new System.Windows.Forms.Label();
            this.rtxN_merd_name = new System.Windows.Forms.RichTextBox();
            this.lbN_merd_name = new System.Windows.Forms.Label();
            this.lbS_merd_id = new System.Windows.Forms.Label();
            this.txS_merd_id = new System.Windows.Forms.TextBox();
            this.tbP_Slod = new System.Windows.Forms.TabPage();
            this.pan_Slod = new System.Windows.Forms.Panel();
            this.DGV_Slod = new System.Windows.Forms.DataGridView();
            this.col_DGVslod_S_slom_merdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGVslod_S_merp_barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGVslod_Tqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGV_Slod_TBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGVslod_D_merl_expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DGVslod_N_merd_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSB_Slod = new System.Windows.Forms.HScrollBar();
            this.VSB_Slod = new System.Windows.Forms.VScrollBar();
            this.Lbl_Slod_SuccessMsg = new System.Windows.Forms.Label();
            this.Lbl_Slodid = new System.Windows.Forms.Label();
            this.txS_Slod_Id = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbP_SelectMode.SuspendLayout();
            this.tbP_Item.SuspendLayout();
            this.pan_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Item)).BeginInit();
            this.tbP_Slod.SuspendLayout();
            this.pan_Slod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Slod)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Seltype_Cute
            // 
            this.btn_Seltype_Cute.Font = new System.Drawing.Font("細明體", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Seltype_Cute.Location = new System.Drawing.Point(572, 108);
            this.btn_Seltype_Cute.Name = "btn_Seltype_Cute";
            this.btn_Seltype_Cute.Size = new System.Drawing.Size(341, 341);
            this.btn_Seltype_Cute.TabIndex = 1;
            this.btn_Seltype_Cute.Text = "截單補貨";
            this.btn_Seltype_Cute.UseVisualStyleBackColor = true;
            // 
            // btn_Seltype_Normal
            // 
            this.btn_Seltype_Normal.Font = new System.Drawing.Font("細明體", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Seltype_Normal.Location = new System.Drawing.Point(87, 108);
            this.btn_Seltype_Normal.Name = "btn_Seltype_Normal";
            this.btn_Seltype_Normal.Size = new System.Drawing.Size(341, 341);
            this.btn_Seltype_Normal.TabIndex = 0;
            this.btn_Seltype_Normal.Text = "一般補貨";
            this.btn_Seltype_Normal.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbP_SelectMode);
            this.tabControl1.Controls.Add(this.tbP_Item);
            this.tabControl1.Controls.Add(this.tbP_Slod);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 685);
            this.tabControl1.TabIndex = 4;
            // 
            // tbP_SelectMode
            // 
            this.tbP_SelectMode.BackColor = System.Drawing.Color.Black;
            this.tbP_SelectMode.Controls.Add(this.btn_Slod);
            this.tbP_SelectMode.Controls.Add(this.btn_Item);
            this.tbP_SelectMode.Location = new System.Drawing.Point(4, 30);
            this.tbP_SelectMode.Name = "tbP_SelectMode";
            this.tbP_SelectMode.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_SelectMode.Size = new System.Drawing.Size(1016, 651);
            this.tbP_SelectMode.TabIndex = 0;
            this.tbP_SelectMode.Text = "選擇查詢方式";
            // 
            // btn_Slod
            // 
            this.btn_Slod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Slod.Font = new System.Drawing.Font("細明體", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Slod.Location = new System.Drawing.Point(572, 108);
            this.btn_Slod.Name = "btn_Slod";
            this.btn_Slod.Size = new System.Drawing.Size(341, 341);
            this.btn_Slod.TabIndex = 5;
            this.btn_Slod.Text = "儲位代號";
            this.btn_Slod.UseVisualStyleBackColor = true;
            // 
            // btn_Item
            // 
            this.btn_Item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Item.Font = new System.Drawing.Font("細明體", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Item.Location = new System.Drawing.Point(87, 108);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(341, 341);
            this.btn_Item.TabIndex = 4;
            this.btn_Item.Text = "貨號ITF";
            this.btn_Item.UseVisualStyleBackColor = true;
            // 
            // tbP_Item
            // 
            this.tbP_Item.BackColor = System.Drawing.Color.Black;
            this.tbP_Item.Controls.Add(this.pan_Item);
            this.tbP_Item.Controls.Add(this.Lbl_Item_SuccessMessage);
            this.tbP_Item.Controls.Add(this.rtxN_merd_name);
            this.tbP_Item.Controls.Add(this.lbN_merd_name);
            this.tbP_Item.Controls.Add(this.lbS_merd_id);
            this.tbP_Item.Controls.Add(this.txS_merd_id);
            this.tbP_Item.Font = new System.Drawing.Font("細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbP_Item.Location = new System.Drawing.Point(4, 41);
            this.tbP_Item.Name = "tbP_Item";
            this.tbP_Item.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_Item.Size = new System.Drawing.Size(1016, 640);
            this.tbP_Item.TabIndex = 1;
            this.tbP_Item.Text = "商品查詢";
            // 
            // pan_Item
            // 
            this.pan_Item.Controls.Add(this.DGV_Item);
            this.pan_Item.Controls.Add(this.VSB_Item);
            this.pan_Item.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Item.Location = new System.Drawing.Point(3, 114);
            this.pan_Item.Name = "pan_Item";
            this.pan_Item.Size = new System.Drawing.Size(1010, 523);
            this.pan_Item.TabIndex = 68;
            // 
            // DGV_Item
            // 
            this.DGV_Item.AllowUserToAddRows = false;
            this.DGV_Item.AllowUserToDeleteRows = false;
            this.DGV_Item.ColumnHeadersHeight = 41;
            this.DGV_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DGV_Item_N_merd_name,
            this.col_DGV_Item_S_slom_slodid,
            this.col_DGV_Item_D_merl_expdate,
            this.col_DGV_Item_Tqty,
            this.col_DGV_Item_TBox});
            this.DGV_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Item.Location = new System.Drawing.Point(0, 0);
            this.DGV_Item.Name = "DGV_Item";
            this.DGV_Item.ReadOnly = true;
            this.DGV_Item.RowHeadersVisible = false;
            this.DGV_Item.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGV_Item.RowTemplate.Height = 80;
            this.DGV_Item.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Item.Size = new System.Drawing.Size(940, 523);
            this.DGV_Item.TabIndex = 53;
            // 
            // col_DGV_Item_N_merd_name
            // 
            this.col_DGV_Item_N_merd_name.DataPropertyName = "N_merd_name";
            this.col_DGV_Item_N_merd_name.HeaderText = "品名規格";
            this.col_DGV_Item_N_merd_name.Name = "col_DGV_Item_N_merd_name";
            this.col_DGV_Item_N_merd_name.ReadOnly = true;
            this.col_DGV_Item_N_merd_name.Visible = false;
            this.col_DGV_Item_N_merd_name.Width = 61;
            // 
            // col_DGV_Item_S_slom_slodid
            // 
            this.col_DGV_Item_S_slom_slodid.DataPropertyName = "S_slom_slodid";
            this.col_DGV_Item_S_slom_slodid.HeaderText = "儲位";
            this.col_DGV_Item_S_slom_slodid.Name = "col_DGV_Item_S_slom_slodid";
            this.col_DGV_Item_S_slom_slodid.ReadOnly = true;
            this.col_DGV_Item_S_slom_slodid.Width = 234;
            // 
            // col_DGV_Item_D_merl_expdate
            // 
            this.col_DGV_Item_D_merl_expdate.DataPropertyName = "D_merl_expdate";
            dataGridViewCellStyle10.Format = "yyyy/MM/dd";
            this.col_DGV_Item_D_merl_expdate.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_DGV_Item_D_merl_expdate.HeaderText = "效期";
            this.col_DGV_Item_D_merl_expdate.Name = "col_DGV_Item_D_merl_expdate";
            this.col_DGV_Item_D_merl_expdate.ReadOnly = true;
            this.col_DGV_Item_D_merl_expdate.Width = 334;
            // 
            // col_DGV_Item_Tqty
            // 
            this.col_DGV_Item_Tqty.DataPropertyName = "Tqty";
            this.col_DGV_Item_Tqty.HeaderText = "庫存量";
            this.col_DGV_Item_Tqty.Name = "col_DGV_Item_Tqty";
            this.col_DGV_Item_Tqty.ReadOnly = true;
            this.col_DGV_Item_Tqty.Width = 234;
            // 
            // col_DGV_Item_TBox
            // 
            this.col_DGV_Item_TBox.DataPropertyName = "TBox";
            this.col_DGV_Item_TBox.HeaderText = "箱";
            this.col_DGV_Item_TBox.Name = "col_DGV_Item_TBox";
            this.col_DGV_Item_TBox.ReadOnly = true;
            this.col_DGV_Item_TBox.Width = 134;
            // 
            // VSB_Item
            // 
            this.VSB_Item.Dock = System.Windows.Forms.DockStyle.Right;
            this.VSB_Item.Location = new System.Drawing.Point(940, 0);
            this.VSB_Item.Name = "VSB_Item";
            this.VSB_Item.Size = new System.Drawing.Size(70, 523);
            this.VSB_Item.TabIndex = 66;
            // 
            // Lbl_Item_SuccessMessage
            // 
            this.Lbl_Item_SuccessMessage.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Item_SuccessMessage.Location = new System.Drawing.Point(444, 3);
            this.Lbl_Item_SuccessMessage.Name = "Lbl_Item_SuccessMessage";
            this.Lbl_Item_SuccessMessage.Size = new System.Drawing.Size(484, 56);
            this.Lbl_Item_SuccessMessage.TabIndex = 67;
            this.Lbl_Item_SuccessMessage.Text = "請刷入貨號/ITF";
            // 
            // rtxN_merd_name
            // 
            this.rtxN_merd_name.BackColor = System.Drawing.SystemColors.Control;
            this.rtxN_merd_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxN_merd_name.Location = new System.Drawing.Point(171, 63);
            this.rtxN_merd_name.Name = "rtxN_merd_name";
            this.rtxN_merd_name.ReadOnly = true;
            this.rtxN_merd_name.Size = new System.Drawing.Size(762, 53);
            this.rtxN_merd_name.TabIndex = 51;
            this.rtxN_merd_name.Text = "";
            // 
            // lbN_merd_name
            // 
            this.lbN_merd_name.Font = new System.Drawing.Font("新細明體", 24F);
            this.lbN_merd_name.ForeColor = System.Drawing.Color.White;
            this.lbN_merd_name.Location = new System.Drawing.Point(15, 75);
            this.lbN_merd_name.Name = "lbN_merd_name";
            this.lbN_merd_name.Size = new System.Drawing.Size(148, 41);
            this.lbN_merd_name.TabIndex = 52;
            this.lbN_merd_name.Text = "商品名稱";
            this.lbN_merd_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbS_merd_id
            // 
            this.lbS_merd_id.Font = new System.Drawing.Font("新細明體", 24F);
            this.lbS_merd_id.ForeColor = System.Drawing.Color.White;
            this.lbS_merd_id.Location = new System.Drawing.Point(15, 15);
            this.lbS_merd_id.Name = "lbS_merd_id";
            this.lbS_merd_id.Size = new System.Drawing.Size(148, 41);
            this.lbS_merd_id.TabIndex = 49;
            this.lbS_merd_id.Text = "商品編號";
            this.lbS_merd_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txS_merd_id
            // 
            this.txS_merd_id.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txS_merd_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_merd_id.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txS_merd_id.ForeColor = System.Drawing.SystemColors.Window;
            this.txS_merd_id.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txS_merd_id.Location = new System.Drawing.Point(171, 3);
            this.txS_merd_id.MaxLength = 20;
            this.txS_merd_id.Name = "txS_merd_id";
            this.txS_merd_id.Size = new System.Drawing.Size(272, 58);
            this.txS_merd_id.TabIndex = 48;
            this.txS_merd_id.Validated += new System.EventHandler(this.txS_merd_id_Validated);
            // 
            // tbP_Slod
            // 
            this.tbP_Slod.BackColor = System.Drawing.Color.Black;
            this.tbP_Slod.Controls.Add(this.pan_Slod);
            this.tbP_Slod.Controls.Add(this.Lbl_Slod_SuccessMsg);
            this.tbP_Slod.Controls.Add(this.Lbl_Slodid);
            this.tbP_Slod.Controls.Add(this.txS_Slod_Id);
            this.tbP_Slod.Font = new System.Drawing.Font("細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbP_Slod.Location = new System.Drawing.Point(4, 41);
            this.tbP_Slod.Name = "tbP_Slod";
            this.tbP_Slod.Size = new System.Drawing.Size(1016, 640);
            this.tbP_Slod.TabIndex = 2;
            this.tbP_Slod.Text = "儲位查詢";
            // 
            // pan_Slod
            // 
            this.pan_Slod.Controls.Add(this.DGV_Slod);
            this.pan_Slod.Controls.Add(this.HSB_Slod);
            this.pan_Slod.Controls.Add(this.VSB_Slod);
            this.pan_Slod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Slod.Location = new System.Drawing.Point(0, 119);
            this.pan_Slod.Name = "pan_Slod";
            this.pan_Slod.Size = new System.Drawing.Size(1016, 521);
            this.pan_Slod.TabIndex = 76;
            // 
            // DGV_Slod
            // 
            this.DGV_Slod.AllowUserToAddRows = false;
            this.DGV_Slod.AllowUserToDeleteRows = false;
            this.DGV_Slod.ColumnHeadersHeight = 41;
            this.DGV_Slod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DGVslod_S_slom_merdid,
            this.col_DGVslod_S_merp_barcode,
            this.col_DGVslod_Tqty,
            this.col_DGV_Slod_TBox,
            this.col_DGVslod_D_merl_expdate,
            this.col_DGVslod_N_merd_name});
            this.DGV_Slod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Slod.Location = new System.Drawing.Point(0, 0);
            this.DGV_Slod.Name = "DGV_Slod";
            this.DGV_Slod.ReadOnly = true;
            this.DGV_Slod.RowHeadersVisible = false;
            this.DGV_Slod.RowTemplate.Height = 80;
            this.DGV_Slod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Slod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Slod.Size = new System.Drawing.Size(946, 451);
            this.DGV_Slod.TabIndex = 76;
            // 
            // col_DGVslod_S_slom_merdid
            // 
            this.col_DGVslod_S_slom_merdid.DataPropertyName = "S_slom_merdid";
            this.col_DGVslod_S_slom_merdid.HeaderText = "貨號";
            this.col_DGVslod_S_slom_merdid.Name = "col_DGVslod_S_slom_merdid";
            this.col_DGVslod_S_slom_merdid.ReadOnly = true;
            // 
            // col_DGVslod_S_merp_barcode
            // 
            this.col_DGVslod_S_merp_barcode.DataPropertyName = "S_merp_barcode";
            this.col_DGVslod_S_merp_barcode.HeaderText = "ITF";
            this.col_DGVslod_S_merp_barcode.Name = "col_DGVslod_S_merp_barcode";
            this.col_DGVslod_S_merp_barcode.ReadOnly = true;
            this.col_DGVslod_S_merp_barcode.Width = 207;
            // 
            // col_DGVslod_Tqty
            // 
            this.col_DGVslod_Tqty.DataPropertyName = "Tqty";
            this.col_DGVslod_Tqty.HeaderText = "庫存量";
            this.col_DGVslod_Tqty.Name = "col_DGVslod_Tqty";
            this.col_DGVslod_Tqty.ReadOnly = true;
            // 
            // col_DGV_Slod_TBox
            // 
            this.col_DGV_Slod_TBox.DataPropertyName = "TBox";
            this.col_DGV_Slod_TBox.HeaderText = "箱";
            this.col_DGV_Slod_TBox.Name = "col_DGV_Slod_TBox";
            this.col_DGV_Slod_TBox.ReadOnly = true;
            this.col_DGV_Slod_TBox.Width = 50;
            // 
            // col_DGVslod_D_merl_expdate
            // 
            this.col_DGVslod_D_merl_expdate.DataPropertyName = "D_merl_expdate";
            dataGridViewCellStyle11.Format = "yyyy/MM/dd";
            this.col_DGVslod_D_merl_expdate.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_DGVslod_D_merl_expdate.HeaderText = "效期";
            this.col_DGVslod_D_merl_expdate.Name = "col_DGVslod_D_merl_expdate";
            this.col_DGVslod_D_merl_expdate.ReadOnly = true;
            this.col_DGVslod_D_merl_expdate.Width = 130;
            // 
            // col_DGVslod_N_merd_name
            // 
            this.col_DGVslod_N_merd_name.DataPropertyName = "N_merd_name";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_DGVslod_N_merd_name.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_DGVslod_N_merd_name.HeaderText = "品名規格";
            this.col_DGVslod_N_merd_name.Name = "col_DGVslod_N_merd_name";
            this.col_DGVslod_N_merd_name.ReadOnly = true;
            this.col_DGVslod_N_merd_name.Width = 355;
            // 
            // HSB_Slod
            // 
            this.HSB_Slod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HSB_Slod.Location = new System.Drawing.Point(0, 451);
            this.HSB_Slod.Name = "HSB_Slod";
            this.HSB_Slod.Size = new System.Drawing.Size(946, 70);
            this.HSB_Slod.TabIndex = 78;
            // 
            // VSB_Slod
            // 
            this.VSB_Slod.Dock = System.Windows.Forms.DockStyle.Right;
            this.VSB_Slod.Location = new System.Drawing.Point(946, 0);
            this.VSB_Slod.Name = "VSB_Slod";
            this.VSB_Slod.Size = new System.Drawing.Size(70, 521);
            this.VSB_Slod.TabIndex = 77;
            // 
            // Lbl_Slod_SuccessMsg
            // 
            this.Lbl_Slod_SuccessMsg.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Slod_SuccessMsg.Location = new System.Drawing.Point(446, 3);
            this.Lbl_Slod_SuccessMsg.Name = "Lbl_Slod_SuccessMsg";
            this.Lbl_Slod_SuccessMsg.Size = new System.Drawing.Size(488, 57);
            this.Lbl_Slod_SuccessMsg.TabIndex = 72;
            this.Lbl_Slod_SuccessMsg.Text = "請刷入儲位編號";
            // 
            // Lbl_Slodid
            // 
            this.Lbl_Slodid.Font = new System.Drawing.Font("新細明體", 24F);
            this.Lbl_Slodid.ForeColor = System.Drawing.Color.White;
            this.Lbl_Slodid.Location = new System.Drawing.Point(15, 15);
            this.Lbl_Slodid.Name = "Lbl_Slodid";
            this.Lbl_Slodid.Size = new System.Drawing.Size(148, 41);
            this.Lbl_Slodid.TabIndex = 69;
            this.Lbl_Slodid.Text = "儲位編號";
            this.Lbl_Slodid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txS_Slod_Id
            // 
            this.txS_Slod_Id.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txS_Slod_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txS_Slod_Id.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txS_Slod_Id.ForeColor = System.Drawing.SystemColors.Window;
            this.txS_Slod_Id.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txS_Slod_Id.Location = new System.Drawing.Point(171, 3);
            this.txS_Slod_Id.MaxLength = 20;
            this.txS_Slod_Id.Name = "txS_Slod_Id";
            this.txS_Slod_Id.Size = new System.Drawing.Size(272, 58);
            this.txS_Slod_Id.TabIndex = 68;
            this.txS_Slod_Id.Validated += new System.EventHandler(this.Txb_SlodId_Validated);
            // 
            // Form9_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form9_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tbP_SelectMode.ResumeLayout(false);
            this.tbP_Item.ResumeLayout(false);
            this.tbP_Item.PerformLayout();
            this.pan_Item.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Item)).EndInit();
            this.tbP_Slod.ResumeLayout(false);
            this.tbP_Slod.PerformLayout();
            this.pan_Slod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Slod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Seltype_Cute;
        private System.Windows.Forms.Button btn_Seltype_Normal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbP_SelectMode;
        private System.Windows.Forms.TabPage tbP_Item;
        private System.Windows.Forms.TabPage tbP_Slod;
        private System.Windows.Forms.Label lbS_merd_id;
        private System.Windows.Forms.TextBox txS_merd_id;
        private System.Windows.Forms.RichTextBox rtxN_merd_name;
        private System.Windows.Forms.Label lbN_merd_name;
        private System.Windows.Forms.DataGridView DGV_Item;
        private System.Windows.Forms.VScrollBar VSB_Item;
        private System.Windows.Forms.Label Lbl_Item_SuccessMessage;
        private System.Windows.Forms.Label Lbl_Slod_SuccessMsg;
        private System.Windows.Forms.Label Lbl_Slodid;
        private System.Windows.Forms.TextBox txS_Slod_Id;
        private System.Windows.Forms.Panel pan_Slod;
        private System.Windows.Forms.DataGridView DGV_Slod;
        private System.Windows.Forms.HScrollBar HSB_Slod;
        private System.Windows.Forms.VScrollBar VSB_Slod;
        private Car_Fun.myButton btn_Slod;
        private Car_Fun.myButton btn_Item;
        private System.Windows.Forms.Panel pan_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGVslod_S_slom_merdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGVslod_S_merp_barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGVslod_Tqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGV_Slod_TBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGVslod_D_merl_expdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGVslod_N_merd_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGV_Item_N_merd_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGV_Item_S_slom_slodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGV_Item_D_merl_expdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGV_Item_Tqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DGV_Item_TBox;
    }
}
