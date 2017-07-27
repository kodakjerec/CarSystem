namespace CarSystem
{
    partial class Form4_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Seltype_Cute = new System.Windows.Forms.Button();
            this.btn_Seltype_Normal = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbP_Item = new System.Windows.Forms.TabPage();
            this.Lbl_Item_SuccessMessage2 = new System.Windows.Forms.Label();
            this.Lbl_Item_SuccessMessage = new System.Windows.Forms.Label();
            this.vSB_Item = new System.Windows.Forms.VScrollBar();
            this.DGV_Item = new System.Windows.Forms.DataGridView();
            this.N_picz_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_pich_sechid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbP_Slod = new System.Windows.Forms.TabPage();
            this.lbl_WorkZone = new System.Windows.Forms.Label();
            this.lbl_SelectMode = new System.Windows.Forms.Label();
            this.pan_Slod = new System.Windows.Forms.Panel();
            this.DGV_Slod = new System.Windows.Forms.DataGridView();
            this.L_pich_idr9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_cusd_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_cusd_sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L_pich_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSB_Slod = new System.Windows.Forms.VScrollBar();
            this.Lbl_Slod_SuccessMsg = new System.Windows.Forms.Label();
            this.tbP_Working = new System.Windows.Forms.TabPage();
            this.lbl_EApack = new System.Windows.Forms.Label();
            this.lbl_EApack_Value = new System.Windows.Forms.Label();
            this.txB_S_merp_barcode2 = new System.Windows.Forms.TextBox();
            this.lbl_I_merp_1qty = new System.Windows.Forms.Label();
            this.lbl_I_merp_1qty_value = new System.Windows.Forms.Label();
            this.txB_S_merp_barcode = new System.Windows.Forms.TextBox();
            this.txB_S_Merd_id = new System.Windows.Forms.TextBox();
            this.Lbl_WarringMsg = new System.Windows.Forms.Label();
            this.cummit = new Car_Fun.myButton();
            this.txB_picQty = new System.Windows.Forms.TextBox();
            this.txB_D_merl_expdate = new System.Windows.Forms.TextBox();
            this.txB_SlodId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxN_merd_name = new System.Windows.Forms.RichTextBox();
            this.txB_merdId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbL_repi_replqty_out_pallet_value = new System.Windows.Forms.Label();
            this.lbL_repi_replqty_out_pallet = new System.Windows.Forms.Label();
            this.lbL_repi_replqty_out_box = new System.Windows.Forms.Label();
            this.lbL_repi_replqty_out_box_value = new System.Windows.Forms.Label();
            this.txB_BoxId = new System.Windows.Forms.TextBox();
            this.lbL_recs_takenum1 = new System.Windows.Forms.Label();
            this.lbL_recs_id1 = new System.Windows.Forms.Label();
            this.Lbl_cusName = new System.Windows.Forms.Label();
            this.Lbl_cusId = new System.Windows.Forms.Label();
            this.Lbl_Pich_id = new System.Windows.Forms.Label();
            this.lbl_WorkZone2 = new System.Windows.Forms.Label();
            this.lbl_SelectMode2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbP_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Item)).BeginInit();
            this.tbP_Slod.SuspendLayout();
            this.pan_Slod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Slod)).BeginInit();
            this.tbP_Working.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tbP_Item);
            this.tabControl1.Controls.Add(this.tbP_Slod);
            this.tabControl1.Controls.Add(this.tbP_Working);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 651);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbP_Item
            // 
            this.tbP_Item.Controls.Add(this.Lbl_Item_SuccessMessage2);
            this.tbP_Item.Controls.Add(this.Lbl_Item_SuccessMessage);
            this.tbP_Item.Controls.Add(this.vSB_Item);
            this.tbP_Item.Controls.Add(this.DGV_Item);
            this.tbP_Item.Location = new System.Drawing.Point(4, 30);
            this.tbP_Item.Name = "tbP_Item";
            this.tbP_Item.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_Item.Size = new System.Drawing.Size(1008, 617);
            this.tbP_Item.TabIndex = 1;
            this.tbP_Item.Text = "區域";
            this.tbP_Item.UseVisualStyleBackColor = true;
            // 
            // Lbl_Item_SuccessMessage2
            // 
            this.Lbl_Item_SuccessMessage2.AutoSize = true;
            this.Lbl_Item_SuccessMessage2.BackColor = System.Drawing.Color.White;
            this.Lbl_Item_SuccessMessage2.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Item_SuccessMessage2.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Item_SuccessMessage2.Location = new System.Drawing.Point(312, 86);
            this.Lbl_Item_SuccessMessage2.MaximumSize = new System.Drawing.Size(800, 0);
            this.Lbl_Item_SuccessMessage2.Name = "Lbl_Item_SuccessMessage2";
            this.Lbl_Item_SuccessMessage2.Size = new System.Drawing.Size(31, 48);
            this.Lbl_Item_SuccessMessage2.TabIndex = 68;
            this.Lbl_Item_SuccessMessage2.Text = ".";
            // 
            // Lbl_Item_SuccessMessage
            // 
            this.Lbl_Item_SuccessMessage.AutoSize = true;
            this.Lbl_Item_SuccessMessage.BackColor = System.Drawing.Color.White;
            this.Lbl_Item_SuccessMessage.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Item_SuccessMessage.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Item_SuccessMessage.Location = new System.Drawing.Point(312, 5);
            this.Lbl_Item_SuccessMessage.MaximumSize = new System.Drawing.Size(400, 0);
            this.Lbl_Item_SuccessMessage.Name = "Lbl_Item_SuccessMessage";
            this.Lbl_Item_SuccessMessage.Size = new System.Drawing.Size(308, 48);
            this.Lbl_Item_SuccessMessage.TabIndex = 67;
            this.Lbl_Item_SuccessMessage.Text = "選擇作業區域";
            // 
            // vSB_Item
            // 
            this.vSB_Item.Location = new System.Drawing.Point(933, 152);
            this.vSB_Item.Name = "vSB_Item";
            this.vSB_Item.Size = new System.Drawing.Size(70, 488);
            this.vSB_Item.TabIndex = 66;
            // 
            // DGV_Item
            // 
            this.DGV_Item.AllowUserToAddRows = false;
            this.DGV_Item.AllowUserToDeleteRows = false;
            this.DGV_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Item.ColumnHeadersHeight = 41;
            this.DGV_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_picz_name,
            this.S_pich_sechid});
            this.DGV_Item.Location = new System.Drawing.Point(3, 152);
            this.DGV_Item.Name = "DGV_Item";
            this.DGV_Item.ReadOnly = true;
            this.DGV_Item.RowHeadersVisible = false;
            this.DGV_Item.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGV_Item.RowTemplate.Height = 80;
            this.DGV_Item.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Item.Size = new System.Drawing.Size(930, 488);
            this.DGV_Item.TabIndex = 53;
            this.DGV_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Item_CellClick);
            // 
            // N_picz_name
            // 
            this.N_picz_name.DataPropertyName = "N_picz_name";
            this.N_picz_name.HeaderText = "名稱";
            this.N_picz_name.Name = "N_picz_name";
            this.N_picz_name.ReadOnly = true;
            this.N_picz_name.Visible = false;
            // 
            // S_pich_sechid
            // 
            this.S_pich_sechid.DataPropertyName = "S_pich_sechid";
            dataGridViewCellStyle1.Format = "yyyy/MM/dd";
            this.S_pich_sechid.DefaultCellStyle = dataGridViewCellStyle1;
            this.S_pich_sechid.HeaderText = "區域";
            this.S_pich_sechid.Name = "S_pich_sechid";
            this.S_pich_sechid.ReadOnly = true;
            // 
            // tbP_Slod
            // 
            this.tbP_Slod.Controls.Add(this.lbl_WorkZone);
            this.tbP_Slod.Controls.Add(this.lbl_SelectMode);
            this.tbP_Slod.Controls.Add(this.pan_Slod);
            this.tbP_Slod.Controls.Add(this.Lbl_Slod_SuccessMsg);
            this.tbP_Slod.Location = new System.Drawing.Point(4, 41);
            this.tbP_Slod.Name = "tbP_Slod";
            this.tbP_Slod.Size = new System.Drawing.Size(1008, 606);
            this.tbP_Slod.TabIndex = 2;
            this.tbP_Slod.Text = "單號";
            this.tbP_Slod.UseVisualStyleBackColor = true;
            // 
            // lbl_WorkZone
            // 
            this.lbl_WorkZone.BackColor = System.Drawing.Color.Teal;
            this.lbl_WorkZone.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_WorkZone.ForeColor = System.Drawing.Color.White;
            this.lbl_WorkZone.Location = new System.Drawing.Point(119, 5);
            this.lbl_WorkZone.Name = "lbl_WorkZone";
            this.lbl_WorkZone.Size = new System.Drawing.Size(145, 39);
            this.lbl_WorkZone.TabIndex = 320;
            this.lbl_WorkZone.Text = "Zone";
            // 
            // lbl_SelectMode
            // 
            this.lbl_SelectMode.BackColor = System.Drawing.Color.Teal;
            this.lbl_SelectMode.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SelectMode.ForeColor = System.Drawing.Color.White;
            this.lbl_SelectMode.Location = new System.Drawing.Point(3, 5);
            this.lbl_SelectMode.Name = "lbl_SelectMode";
            this.lbl_SelectMode.Size = new System.Drawing.Size(110, 39);
            this.lbl_SelectMode.TabIndex = 319;
            this.lbl_SelectMode.Text = "Mode";
            // 
            // pan_Slod
            // 
            this.pan_Slod.Controls.Add(this.DGV_Slod);
            this.pan_Slod.Controls.Add(this.vSB_Slod);
            this.pan_Slod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Slod.Location = new System.Drawing.Point(0, 95);
            this.pan_Slod.Name = "pan_Slod";
            this.pan_Slod.Size = new System.Drawing.Size(1008, 511);
            this.pan_Slod.TabIndex = 76;
            // 
            // DGV_Slod
            // 
            this.DGV_Slod.AllowUserToAddRows = false;
            this.DGV_Slod.AllowUserToDeleteRows = false;
            this.DGV_Slod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Slod.ColumnHeadersHeight = 41;
            this.DGV_Slod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L_pich_idr9,
            this.S_cusd_id,
            this.N_cusd_sname,
            this.L_pich_id,
            this.IsLock});
            this.DGV_Slod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Slod.Location = new System.Drawing.Point(0, 0);
            this.DGV_Slod.Name = "DGV_Slod";
            this.DGV_Slod.ReadOnly = true;
            this.DGV_Slod.RowHeadersVisible = false;
            this.DGV_Slod.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("細明體", 36F);
            this.DGV_Slod.RowTemplate.Height = 80;
            this.DGV_Slod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Slod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Slod.Size = new System.Drawing.Size(938, 511);
            this.DGV_Slod.TabIndex = 76;
            this.DGV_Slod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Slod_CellClick);
            // 
            // L_pich_idr9
            // 
            this.L_pich_idr9.DataPropertyName = "L_pich_idr9";
            this.L_pich_idr9.HeaderText = "揀貨單號後九碼";
            this.L_pich_idr9.Name = "L_pich_idr9";
            this.L_pich_idr9.ReadOnly = true;
            // 
            // S_cusd_id
            // 
            this.S_cusd_id.DataPropertyName = "S_cusd_id";
            this.S_cusd_id.HeaderText = "營業所代號";
            this.S_cusd_id.Name = "S_cusd_id";
            this.S_cusd_id.ReadOnly = true;
            // 
            // N_cusd_sname
            // 
            this.N_cusd_sname.DataPropertyName = "N_cusd_sname";
            this.N_cusd_sname.HeaderText = "名稱";
            this.N_cusd_sname.Name = "N_cusd_sname";
            this.N_cusd_sname.ReadOnly = true;
            // 
            // L_pich_id
            // 
            this.L_pich_id.DataPropertyName = "L_pich_id";
            this.L_pich_id.HeaderText = "L_pich_id";
            this.L_pich_id.Name = "L_pich_id";
            this.L_pich_id.ReadOnly = true;
            this.L_pich_id.Visible = false;
            // 
            // IsLock
            // 
            this.IsLock.DataPropertyName = "IsLock";
            this.IsLock.HeaderText = "IsLock";
            this.IsLock.Name = "IsLock";
            this.IsLock.ReadOnly = true;
            this.IsLock.Visible = false;
            // 
            // vSB_Slod
            // 
            this.vSB_Slod.Dock = System.Windows.Forms.DockStyle.Right;
            this.vSB_Slod.Location = new System.Drawing.Point(938, 0);
            this.vSB_Slod.Name = "vSB_Slod";
            this.vSB_Slod.Size = new System.Drawing.Size(70, 511);
            this.vSB_Slod.TabIndex = 77;
            // 
            // Lbl_Slod_SuccessMsg
            // 
            this.Lbl_Slod_SuccessMsg.AutoSize = true;
            this.Lbl_Slod_SuccessMsg.BackColor = System.Drawing.Color.White;
            this.Lbl_Slod_SuccessMsg.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Slod_SuccessMsg.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Slod_SuccessMsg.Location = new System.Drawing.Point(312, 5);
            this.Lbl_Slod_SuccessMsg.MaximumSize = new System.Drawing.Size(800, 0);
            this.Lbl_Slod_SuccessMsg.Name = "Lbl_Slod_SuccessMsg";
            this.Lbl_Slod_SuccessMsg.Size = new System.Drawing.Size(308, 48);
            this.Lbl_Slod_SuccessMsg.TabIndex = 72;
            this.Lbl_Slod_SuccessMsg.Text = "選擇揀貨單號";
            // 
            // tbP_Working
            // 
            this.tbP_Working.Controls.Add(this.lbl_EApack);
            this.tbP_Working.Controls.Add(this.lbl_EApack_Value);
            this.tbP_Working.Controls.Add(this.txB_S_merp_barcode2);
            this.tbP_Working.Controls.Add(this.lbl_I_merp_1qty);
            this.tbP_Working.Controls.Add(this.lbl_I_merp_1qty_value);
            this.tbP_Working.Controls.Add(this.txB_S_merp_barcode);
            this.tbP_Working.Controls.Add(this.txB_S_Merd_id);
            this.tbP_Working.Controls.Add(this.Lbl_WarringMsg);
            this.tbP_Working.Controls.Add(this.cummit);
            this.tbP_Working.Controls.Add(this.txB_picQty);
            this.tbP_Working.Controls.Add(this.txB_D_merl_expdate);
            this.tbP_Working.Controls.Add(this.txB_SlodId);
            this.tbP_Working.Controls.Add(this.label2);
            this.tbP_Working.Controls.Add(this.rtxN_merd_name);
            this.tbP_Working.Controls.Add(this.txB_merdId);
            this.tbP_Working.Controls.Add(this.label1);
            this.tbP_Working.Controls.Add(this.lbL_repi_replqty_out_pallet_value);
            this.tbP_Working.Controls.Add(this.lbL_repi_replqty_out_pallet);
            this.tbP_Working.Controls.Add(this.lbL_repi_replqty_out_box);
            this.tbP_Working.Controls.Add(this.lbL_repi_replqty_out_box_value);
            this.tbP_Working.Controls.Add(this.txB_BoxId);
            this.tbP_Working.Controls.Add(this.lbL_recs_takenum1);
            this.tbP_Working.Controls.Add(this.lbL_recs_id1);
            this.tbP_Working.Controls.Add(this.Lbl_cusName);
            this.tbP_Working.Controls.Add(this.Lbl_cusId);
            this.tbP_Working.Controls.Add(this.Lbl_Pich_id);
            this.tbP_Working.Controls.Add(this.lbl_WorkZone2);
            this.tbP_Working.Controls.Add(this.lbl_SelectMode2);
            this.tbP_Working.Location = new System.Drawing.Point(4, 41);
            this.tbP_Working.Name = "tbP_Working";
            this.tbP_Working.Size = new System.Drawing.Size(1008, 606);
            this.tbP_Working.TabIndex = 3;
            this.tbP_Working.Text = "實際作業";
            this.tbP_Working.UseVisualStyleBackColor = true;
            // 
            // lbl_EApack
            // 
            this.lbl_EApack.BackColor = System.Drawing.Color.White;
            this.lbl_EApack.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbl_EApack.Location = new System.Drawing.Point(427, 260);
            this.lbl_EApack.Name = "lbl_EApack";
            this.lbl_EApack.Size = new System.Drawing.Size(37, 64);
            this.lbl_EApack.TabIndex = 362;
            this.lbl_EApack.Text = "小包裝";
            this.lbl_EApack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_EApack_Value
            // 
            this.lbl_EApack_Value.AutoSize = true;
            this.lbl_EApack_Value.BackColor = System.Drawing.Color.White;
            this.lbl_EApack_Value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbl_EApack_Value.Location = new System.Drawing.Point(452, 260);
            this.lbl_EApack_Value.Name = "lbl_EApack_Value";
            this.lbl_EApack_Value.Size = new System.Drawing.Size(90, 64);
            this.lbl_EApack_Value.TabIndex = 361;
            this.lbl_EApack_Value.Text = "00";
            this.lbl_EApack_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txB_S_merp_barcode2
            // 
            this.txB_S_merp_barcode2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txB_S_merp_barcode2.Location = new System.Drawing.Point(806, 259);
            this.txB_S_merp_barcode2.Name = "txB_S_merp_barcode2";
            this.txB_S_merp_barcode2.ReadOnly = true;
            this.txB_S_merp_barcode2.Size = new System.Drawing.Size(169, 36);
            this.txB_S_merp_barcode2.TabIndex = 350;
            // 
            // lbl_I_merp_1qty
            // 
            this.lbl_I_merp_1qty.BackColor = System.Drawing.Color.White;
            this.lbl_I_merp_1qty.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbl_I_merp_1qty.Location = new System.Drawing.Point(318, 260);
            this.lbl_I_merp_1qty.Name = "lbl_I_merp_1qty";
            this.lbl_I_merp_1qty.Size = new System.Drawing.Size(37, 64);
            this.lbl_I_merp_1qty.TabIndex = 349;
            this.lbl_I_merp_1qty.Text = "組入數";
            this.lbl_I_merp_1qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_I_merp_1qty_value
            // 
            this.lbl_I_merp_1qty_value.AutoSize = true;
            this.lbl_I_merp_1qty_value.BackColor = System.Drawing.Color.White;
            this.lbl_I_merp_1qty_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbl_I_merp_1qty_value.Location = new System.Drawing.Point(343, 260);
            this.lbl_I_merp_1qty_value.Name = "lbl_I_merp_1qty_value";
            this.lbl_I_merp_1qty_value.Size = new System.Drawing.Size(90, 64);
            this.lbl_I_merp_1qty_value.TabIndex = 348;
            this.lbl_I_merp_1qty_value.Text = "00";
            this.lbl_I_merp_1qty_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txB_S_merp_barcode
            // 
            this.txB_S_merp_barcode.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txB_S_merp_barcode.Location = new System.Drawing.Point(806, 223);
            this.txB_S_merp_barcode.Name = "txB_S_merp_barcode";
            this.txB_S_merp_barcode.ReadOnly = true;
            this.txB_S_merp_barcode.Size = new System.Drawing.Size(169, 36);
            this.txB_S_merp_barcode.TabIndex = 347;
            // 
            // txB_S_Merd_id
            // 
            this.txB_S_Merd_id.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txB_S_Merd_id.Location = new System.Drawing.Point(806, 187);
            this.txB_S_Merd_id.Name = "txB_S_Merd_id";
            this.txB_S_Merd_id.ReadOnly = true;
            this.txB_S_Merd_id.Size = new System.Drawing.Size(169, 36);
            this.txB_S_Merd_id.TabIndex = 346;
            // 
            // Lbl_WarringMsg
            // 
            this.Lbl_WarringMsg.AutoSize = true;
            this.Lbl_WarringMsg.BackColor = System.Drawing.Color.White;
            this.Lbl_WarringMsg.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_WarringMsg.ForeColor = System.Drawing.Color.Red;
            this.Lbl_WarringMsg.Location = new System.Drawing.Point(8, 455);
            this.Lbl_WarringMsg.MaximumSize = new System.Drawing.Size(800, 0);
            this.Lbl_WarringMsg.Name = "Lbl_WarringMsg";
            this.Lbl_WarringMsg.Size = new System.Drawing.Size(356, 48);
            this.Lbl_WarringMsg.TabIndex = 345;
            this.Lbl_WarringMsg.Text = "刷入物流箱標籤";
            // 
            // cummit
            // 
            this.cummit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cummit.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cummit.Location = new System.Drawing.Point(177, 345);
            this.cummit.Name = "cummit";
            this.cummit.Size = new System.Drawing.Size(259, 97);
            this.cummit.TabIndex = 3;
            this.cummit.Text = "完成";
            this.cummit.UseVisualStyleBackColor = true;
            this.cummit.Click += new System.EventHandler(this.cummit_Click);
            // 
            // txB_picQty
            // 
            this.txB_picQty.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txB_picQty.Font = new System.Drawing.Font("新細明體", 36F);
            this.txB_picQty.ForeColor = System.Drawing.SystemColors.Window;
            this.txB_picQty.Location = new System.Drawing.Point(177, 264);
            this.txB_picQty.Name = "txB_picQty";
            this.txB_picQty.Size = new System.Drawing.Size(139, 65);
            this.txB_picQty.TabIndex = 2;
            this.txB_picQty.Validated += new System.EventHandler(this.txB_picQty_Validated);
            // 
            // txB_D_merl_expdate
            // 
            this.txB_D_merl_expdate.Font = new System.Drawing.Font("新細明體", 36F);
            this.txB_D_merl_expdate.Location = new System.Drawing.Point(492, 190);
            this.txB_D_merl_expdate.Name = "txB_D_merl_expdate";
            this.txB_D_merl_expdate.ReadOnly = true;
            this.txB_D_merl_expdate.Size = new System.Drawing.Size(308, 65);
            this.txB_D_merl_expdate.TabIndex = 342;
            // 
            // txB_SlodId
            // 
            this.txB_SlodId.Font = new System.Drawing.Font("新細明體", 36F);
            this.txB_SlodId.Location = new System.Drawing.Point(178, 118);
            this.txB_SlodId.Name = "txB_SlodId";
            this.txB_SlodId.ReadOnly = true;
            this.txB_SlodId.Size = new System.Drawing.Size(308, 65);
            this.txB_SlodId.TabIndex = 341;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 38);
            this.label2.TabIndex = 340;
            this.label2.Text = "儲位編號";
            // 
            // rtxN_merd_name
            // 
            this.rtxN_merd_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxN_merd_name.Location = new System.Drawing.Point(492, 47);
            this.rtxN_merd_name.Name = "rtxN_merd_name";
            this.rtxN_merd_name.ReadOnly = true;
            this.rtxN_merd_name.Size = new System.Drawing.Size(483, 140);
            this.rtxN_merd_name.TabIndex = 339;
            this.rtxN_merd_name.Text = "";
            // 
            // txB_merdId
            // 
            this.txB_merdId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txB_merdId.Font = new System.Drawing.Font("新細明體", 36F);
            this.txB_merdId.ForeColor = System.Drawing.SystemColors.Window;
            this.txB_merdId.Location = new System.Drawing.Point(178, 190);
            this.txB_merdId.Name = "txB_merdId";
            this.txB_merdId.Size = new System.Drawing.Size(308, 65);
            this.txB_merdId.TabIndex = 1;
            this.txB_merdId.Validated += new System.EventHandler(this.txB_merdId_Validated);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 338;
            this.label1.Text = "商品條碼";
            // 
            // lbL_repi_replqty_out_pallet_value
            // 
            this.lbL_repi_replqty_out_pallet_value.AutoSize = true;
            this.lbL_repi_replqty_out_pallet_value.BackColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_pallet_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbL_repi_replqty_out_pallet_value.Location = new System.Drawing.Point(709, 260);
            this.lbL_repi_replqty_out_pallet_value.Name = "lbL_repi_replqty_out_pallet_value";
            this.lbL_repi_replqty_out_pallet_value.Size = new System.Drawing.Size(90, 64);
            this.lbL_repi_replqty_out_pallet_value.TabIndex = 336;
            this.lbL_repi_replqty_out_pallet_value.Text = "00";
            this.lbL_repi_replqty_out_pallet_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbL_repi_replqty_out_pallet
            // 
            this.lbL_repi_replqty_out_pallet.BackColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_pallet.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbL_repi_replqty_out_pallet.Location = new System.Drawing.Point(682, 260);
            this.lbL_repi_replqty_out_pallet.Name = "lbL_repi_replqty_out_pallet";
            this.lbL_repi_replqty_out_pallet.Size = new System.Drawing.Size(38, 64);
            this.lbL_repi_replqty_out_pallet.TabIndex = 335;
            this.lbL_repi_replqty_out_pallet.Text = "已揀";
            this.lbL_repi_replqty_out_pallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbL_repi_replqty_out_box
            // 
            this.lbL_repi_replqty_out_box.BackColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_box.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbL_repi_replqty_out_box.Location = new System.Drawing.Point(558, 260);
            this.lbL_repi_replqty_out_box.Name = "lbL_repi_replqty_out_box";
            this.lbL_repi_replqty_out_box.Size = new System.Drawing.Size(37, 64);
            this.lbL_repi_replqty_out_box.TabIndex = 334;
            this.lbL_repi_replqty_out_box.Text = "應揀";
            this.lbL_repi_replqty_out_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbL_repi_replqty_out_box_value
            // 
            this.lbL_repi_replqty_out_box_value.AutoSize = true;
            this.lbL_repi_replqty_out_box_value.BackColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_box_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbL_repi_replqty_out_box_value.Location = new System.Drawing.Point(583, 260);
            this.lbL_repi_replqty_out_box_value.Name = "lbL_repi_replqty_out_box_value";
            this.lbL_repi_replqty_out_box_value.Size = new System.Drawing.Size(90, 64);
            this.lbL_repi_replqty_out_box_value.TabIndex = 333;
            this.lbL_repi_replqty_out_box_value.Text = "00";
            this.lbL_repi_replqty_out_box_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txB_BoxId
            // 
            this.txB_BoxId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txB_BoxId.Font = new System.Drawing.Font("新細明體", 30F);
            this.txB_BoxId.ForeColor = System.Drawing.SystemColors.Window;
            this.txB_BoxId.Location = new System.Drawing.Point(178, 47);
            this.txB_BoxId.Name = "txB_BoxId";
            this.txB_BoxId.Size = new System.Drawing.Size(308, 55);
            this.txB_BoxId.TabIndex = 0;
            this.txB_BoxId.Validated += new System.EventHandler(this.txB_BoxId_Validated);
            // 
            // lbL_recs_takenum1
            // 
            this.lbL_recs_takenum1.BackColor = System.Drawing.Color.Teal;
            this.lbL_recs_takenum1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbL_recs_takenum1.ForeColor = System.Drawing.Color.White;
            this.lbL_recs_takenum1.Location = new System.Drawing.Point(8, 275);
            this.lbL_recs_takenum1.Name = "lbL_recs_takenum1";
            this.lbL_recs_takenum1.Size = new System.Drawing.Size(164, 39);
            this.lbL_recs_takenum1.TabIndex = 329;
            this.lbL_recs_takenum1.Text = "待  揀  量";
            // 
            // lbL_recs_id1
            // 
            this.lbL_recs_id1.BackColor = System.Drawing.Color.Teal;
            this.lbL_recs_id1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbL_recs_id1.ForeColor = System.Drawing.Color.White;
            this.lbL_recs_id1.Location = new System.Drawing.Point(8, 62);
            this.lbL_recs_id1.Name = "lbL_recs_id1";
            this.lbL_recs_id1.Size = new System.Drawing.Size(164, 38);
            this.lbL_recs_id1.TabIndex = 327;
            this.lbL_recs_id1.Text = "容器標籤";
            // 
            // Lbl_cusName
            // 
            this.Lbl_cusName.BackColor = System.Drawing.Color.Teal;
            this.Lbl_cusName.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_cusName.ForeColor = System.Drawing.Color.White;
            this.Lbl_cusName.Location = new System.Drawing.Point(704, 5);
            this.Lbl_cusName.Name = "Lbl_cusName";
            this.Lbl_cusName.Size = new System.Drawing.Size(271, 39);
            this.Lbl_cusName.TabIndex = 325;
            this.Lbl_cusName.Text = "cusName";
            // 
            // Lbl_cusId
            // 
            this.Lbl_cusId.BackColor = System.Drawing.Color.Teal;
            this.Lbl_cusId.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_cusId.ForeColor = System.Drawing.Color.White;
            this.Lbl_cusId.Location = new System.Drawing.Point(593, 5);
            this.Lbl_cusId.Name = "Lbl_cusId";
            this.Lbl_cusId.Size = new System.Drawing.Size(105, 39);
            this.Lbl_cusId.TabIndex = 324;
            this.Lbl_cusId.Text = "cusdId";
            // 
            // Lbl_Pich_id
            // 
            this.Lbl_Pich_id.BackColor = System.Drawing.Color.Teal;
            this.Lbl_Pich_id.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Pich_id.ForeColor = System.Drawing.Color.White;
            this.Lbl_Pich_id.Location = new System.Drawing.Point(270, 5);
            this.Lbl_Pich_id.Name = "Lbl_Pich_id";
            this.Lbl_Pich_id.Size = new System.Drawing.Size(216, 39);
            this.Lbl_Pich_id.TabIndex = 323;
            this.Lbl_Pich_id.Text = "PichId";
            // 
            // lbl_WorkZone2
            // 
            this.lbl_WorkZone2.BackColor = System.Drawing.Color.Teal;
            this.lbl_WorkZone2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_WorkZone2.ForeColor = System.Drawing.Color.White;
            this.lbl_WorkZone2.Location = new System.Drawing.Point(119, 5);
            this.lbl_WorkZone2.Name = "lbl_WorkZone2";
            this.lbl_WorkZone2.Size = new System.Drawing.Size(145, 39);
            this.lbl_WorkZone2.TabIndex = 322;
            this.lbl_WorkZone2.Text = "Zone";
            // 
            // lbl_SelectMode2
            // 
            this.lbl_SelectMode2.BackColor = System.Drawing.Color.Teal;
            this.lbl_SelectMode2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SelectMode2.ForeColor = System.Drawing.Color.White;
            this.lbl_SelectMode2.Location = new System.Drawing.Point(3, 5);
            this.lbl_SelectMode2.Name = "lbl_SelectMode2";
            this.lbl_SelectMode2.Size = new System.Drawing.Size(110, 39);
            this.lbl_SelectMode2.TabIndex = 321;
            this.lbl_SelectMode2.Text = "Mode";
            // 
            // Form4_2
            // 
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tbP_Item.ResumeLayout(false);
            this.tbP_Item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Item)).EndInit();
            this.tbP_Slod.ResumeLayout(false);
            this.tbP_Slod.PerformLayout();
            this.pan_Slod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Slod)).EndInit();
            this.tbP_Working.ResumeLayout(false);
            this.tbP_Working.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Seltype_Cute;
        private System.Windows.Forms.Button btn_Seltype_Normal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbP_Item;
        private System.Windows.Forms.TabPage tbP_Slod;
        private System.Windows.Forms.DataGridView DGV_Item;
        private System.Windows.Forms.VScrollBar vSB_Item;
        private System.Windows.Forms.Label Lbl_Item_SuccessMessage;
        private System.Windows.Forms.Label Lbl_Slod_SuccessMsg;
        private System.Windows.Forms.Panel pan_Slod;
        private System.Windows.Forms.DataGridView DGV_Slod;
        private System.Windows.Forms.VScrollBar vSB_Slod;
        private System.Windows.Forms.Label Lbl_Item_SuccessMessage2;
        private System.Windows.Forms.Label lbl_WorkZone;
        private System.Windows.Forms.Label lbl_SelectMode;
        private System.Windows.Forms.TabPage tbP_Working;
        private System.Windows.Forms.Label lbl_WorkZone2;
        private System.Windows.Forms.Label lbl_SelectMode2;
        private System.Windows.Forms.Label Lbl_Pich_id;
        private System.Windows.Forms.Label Lbl_cusName;
        private System.Windows.Forms.Label Lbl_cusId;
        private System.Windows.Forms.TextBox txB_BoxId;
        private System.Windows.Forms.Label lbL_recs_takenum1;
        private System.Windows.Forms.Label lbL_recs_id1;
        private System.Windows.Forms.TextBox txB_merdId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbL_repi_replqty_out_pallet_value;
        private System.Windows.Forms.Label lbL_repi_replqty_out_pallet;
        private System.Windows.Forms.Label lbL_repi_replqty_out_box;
        private System.Windows.Forms.Label lbL_repi_replqty_out_box_value;
        private System.Windows.Forms.RichTextBox rtxN_merd_name;
        private System.Windows.Forms.TextBox txB_SlodId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txB_picQty;
        private System.Windows.Forms.TextBox txB_D_merl_expdate;
        private System.Windows.Forms.Label Lbl_WarringMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_pich_idr9;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_cusd_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_cusd_sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_pich_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsLock;
        private System.Windows.Forms.TextBox txB_S_merp_barcode;
        private System.Windows.Forms.TextBox txB_S_Merd_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_picz_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_pich_sechid;
        private System.Windows.Forms.Label lbl_I_merp_1qty;
        private System.Windows.Forms.Label lbl_I_merp_1qty_value;
        private System.Windows.Forms.TextBox txB_S_merp_barcode2;
        private System.Windows.Forms.Label lbl_EApack;
        private System.Windows.Forms.Label lbl_EApack_Value;
        private Car_Fun.myButton cummit;
    }
}
