namespace CarSystem
{
    partial class Form4_3
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
            this.S_groi_sechid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbP_Slod = new System.Windows.Forms.TabPage();
            this.lbl_WorkZone = new System.Windows.Forms.Label();
            this.lbl_SelectMode = new System.Windows.Forms.Label();
            this.pan_Slod = new System.Windows.Forms.Panel();
            this.DGV_Slod = new System.Windows.Forms.DataGridView();
            this.S_slod_pick_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_groh_opname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L_groh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_slod_pick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSB_Slod = new System.Windows.Forms.VScrollBar();
            this.Lbl_Slod_SuccessMsg = new System.Windows.Forms.Label();
            this.tbP_Working = new System.Windows.Forms.TabPage();
            this.lbl_EApack = new System.Windows.Forms.Label();
            this.lbl_EApack_Value = new System.Windows.Forms.Label();
            this.lbl_XDoverlap = new System.Windows.Forms.Label();
            this.lbl_groi_left = new System.Windows.Forms.Label();
            this.lbl_groi_left_value = new System.Windows.Forms.Label();
            this.lbl_S_slod_pick_name = new System.Windows.Forms.Label();
            this.lbl_S_slod_pick = new System.Windows.Forms.Label();
            this.txB_S_merp_barcode2 = new System.Windows.Forms.TextBox();
            this.lbl_I_merp_1qty = new System.Windows.Forms.Label();
            this.lbl_I_merp_1qty_value = new System.Windows.Forms.Label();
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
            this.lbL_recs_takenum1 = new System.Windows.Forms.Label();
            this.Lbl_Groh_id = new System.Windows.Forms.Label();
            this.lbl_WorkZone2 = new System.Windows.Forms.Label();
            this.lbl_SelectMode2 = new System.Windows.Forms.Label();
            this.lbl_takebox = new System.Windows.Forms.Label();
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
            this.tbP_Item.BackColor = System.Drawing.Color.Black;
            this.tbP_Item.Controls.Add(this.Lbl_Item_SuccessMessage2);
            this.tbP_Item.Controls.Add(this.Lbl_Item_SuccessMessage);
            this.tbP_Item.Controls.Add(this.vSB_Item);
            this.tbP_Item.Controls.Add(this.DGV_Item);
            this.tbP_Item.Font = new System.Drawing.Font("細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbP_Item.Location = new System.Drawing.Point(4, 30);
            this.tbP_Item.Name = "tbP_Item";
            this.tbP_Item.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_Item.Size = new System.Drawing.Size(1008, 617);
            this.tbP_Item.TabIndex = 1;
            this.tbP_Item.Text = "區域";
            // 
            // Lbl_Item_SuccessMessage2
            // 
            this.Lbl_Item_SuccessMessage2.AutoSize = true;
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
            this.DGV_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Item.ColumnHeadersHeight = 41;
            this.DGV_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_groi_sechid});
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
            // S_groi_sechid
            // 
            this.S_groi_sechid.DataPropertyName = "S_groi_sechid";
            dataGridViewCellStyle1.Format = "yyyy/MM/dd";
            this.S_groi_sechid.DefaultCellStyle = dataGridViewCellStyle1;
            this.S_groi_sechid.HeaderText = "區域";
            this.S_groi_sechid.Name = "S_groi_sechid";
            this.S_groi_sechid.ReadOnly = true;
            // 
            // tbP_Slod
            // 
            this.tbP_Slod.BackColor = System.Drawing.Color.Black;
            this.tbP_Slod.Controls.Add(this.lbl_WorkZone);
            this.tbP_Slod.Controls.Add(this.lbl_SelectMode);
            this.tbP_Slod.Controls.Add(this.pan_Slod);
            this.tbP_Slod.Controls.Add(this.Lbl_Slod_SuccessMsg);
            this.tbP_Slod.Font = new System.Drawing.Font("細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbP_Slod.Location = new System.Drawing.Point(4, 30);
            this.tbP_Slod.Name = "tbP_Slod";
            this.tbP_Slod.Size = new System.Drawing.Size(1008, 617);
            this.tbP_Slod.TabIndex = 2;
            this.tbP_Slod.Text = "單號";
            // 
            // lbl_WorkZone
            // 
            this.lbl_WorkZone.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_WorkZone.ForeColor = System.Drawing.Color.White;
            this.lbl_WorkZone.Location = new System.Drawing.Point(119, 5);
            this.lbl_WorkZone.Name = "lbl_WorkZone";
            this.lbl_WorkZone.Size = new System.Drawing.Size(150, 39);
            this.lbl_WorkZone.TabIndex = 320;
            this.lbl_WorkZone.Text = "Zone";
            // 
            // lbl_SelectMode
            // 
            this.lbl_SelectMode.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.pan_Slod.Location = new System.Drawing.Point(0, 106);
            this.pan_Slod.Name = "pan_Slod";
            this.pan_Slod.Size = new System.Drawing.Size(1008, 511);
            this.pan_Slod.TabIndex = 76;
            // 
            // DGV_Slod
            // 
            this.DGV_Slod.AllowUserToAddRows = false;
            this.DGV_Slod.AllowUserToDeleteRows = false;
            this.DGV_Slod.ColumnHeadersHeight = 41;
            this.DGV_Slod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_slod_pick_name,
            this.S_groh_opname,
            this.L_groh_id,
            this.IsLock,
            this.S_slod_pick});
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
            // S_slod_pick_name
            // 
            this.S_slod_pick_name.DataPropertyName = "S_slod_pick_name";
            this.S_slod_pick_name.HeaderText = "儲位類別";
            this.S_slod_pick_name.Name = "S_slod_pick_name";
            this.S_slod_pick_name.ReadOnly = true;
            this.S_slod_pick_name.Width = 300;
            // 
            // S_groh_opname
            // 
            this.S_groh_opname.DataPropertyName = "S_groh_opname";
            this.S_groh_opname.HeaderText = "彙總類別";
            this.S_groh_opname.Name = "S_groh_opname";
            this.S_groh_opname.ReadOnly = true;
            this.S_groh_opname.Width = 230;
            // 
            // L_groh_id
            // 
            this.L_groh_id.DataPropertyName = "L_groh_id";
            this.L_groh_id.HeaderText = "彙總單號";
            this.L_groh_id.Name = "L_groh_id";
            this.L_groh_id.ReadOnly = true;
            this.L_groh_id.Width = 404;
            // 
            // IsLock
            // 
            this.IsLock.DataPropertyName = "IsLock";
            this.IsLock.HeaderText = "IsLock";
            this.IsLock.Name = "IsLock";
            this.IsLock.ReadOnly = true;
            this.IsLock.Visible = false;
            // 
            // S_slod_pick
            // 
            this.S_slod_pick.DataPropertyName = "S_slod_pick";
            this.S_slod_pick.HeaderText = "S_slod_pick";
            this.S_slod_pick.Name = "S_slod_pick";
            this.S_slod_pick.ReadOnly = true;
            this.S_slod_pick.Visible = false;
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
            this.Lbl_Slod_SuccessMsg.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Slod_SuccessMsg.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Slod_SuccessMsg.Location = new System.Drawing.Point(312, 5);
            this.Lbl_Slod_SuccessMsg.MaximumSize = new System.Drawing.Size(800, 0);
            this.Lbl_Slod_SuccessMsg.Name = "Lbl_Slod_SuccessMsg";
            this.Lbl_Slod_SuccessMsg.Size = new System.Drawing.Size(308, 48);
            this.Lbl_Slod_SuccessMsg.TabIndex = 72;
            this.Lbl_Slod_SuccessMsg.Text = "選擇彙總單號";
            // 
            // tbP_Working
            // 
            this.tbP_Working.BackColor = System.Drawing.Color.Black;
            this.tbP_Working.Controls.Add(this.lbl_EApack);
            this.tbP_Working.Controls.Add(this.lbl_EApack_Value);
            this.tbP_Working.Controls.Add(this.lbl_XDoverlap);
            this.tbP_Working.Controls.Add(this.lbl_groi_left);
            this.tbP_Working.Controls.Add(this.lbl_groi_left_value);
            this.tbP_Working.Controls.Add(this.lbl_S_slod_pick_name);
            this.tbP_Working.Controls.Add(this.lbl_S_slod_pick);
            this.tbP_Working.Controls.Add(this.txB_S_merp_barcode2);
            this.tbP_Working.Controls.Add(this.lbl_I_merp_1qty);
            this.tbP_Working.Controls.Add(this.lbl_I_merp_1qty_value);
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
            this.tbP_Working.Controls.Add(this.lbL_recs_takenum1);
            this.tbP_Working.Controls.Add(this.Lbl_Groh_id);
            this.tbP_Working.Controls.Add(this.lbl_WorkZone2);
            this.tbP_Working.Controls.Add(this.lbl_SelectMode2);
            this.tbP_Working.Controls.Add(this.lbl_takebox);
            this.tbP_Working.ForeColor = System.Drawing.Color.White;
            this.tbP_Working.Location = new System.Drawing.Point(4, 30);
            this.tbP_Working.Name = "tbP_Working";
            this.tbP_Working.Size = new System.Drawing.Size(1008, 617);
            this.tbP_Working.TabIndex = 3;
            this.tbP_Working.Text = "實際作業";
            // 
            // lbl_EApack
            // 
            this.lbl_EApack.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbl_EApack.ForeColor = System.Drawing.Color.White;
            this.lbl_EApack.Location = new System.Drawing.Point(480, 243);
            this.lbl_EApack.Name = "lbl_EApack";
            this.lbl_EApack.Size = new System.Drawing.Size(36, 64);
            this.lbl_EApack.TabIndex = 360;
            this.lbl_EApack.Text = "小包裝";
            this.lbl_EApack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_EApack_Value
            // 
            this.lbl_EApack_Value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbl_EApack_Value.ForeColor = System.Drawing.Color.White;
            this.lbl_EApack_Value.Location = new System.Drawing.Point(505, 243);
            this.lbl_EApack_Value.Name = "lbl_EApack_Value";
            this.lbl_EApack_Value.Size = new System.Drawing.Size(90, 64);
            this.lbl_EApack_Value.TabIndex = 359;
            this.lbl_EApack_Value.Text = "00";
            this.lbl_EApack_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_XDoverlap
            // 
            this.lbl_XDoverlap.BackColor = System.Drawing.Color.Yellow;
            this.lbl_XDoverlap.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_XDoverlap.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_XDoverlap.Location = new System.Drawing.Point(171, 54);
            this.lbl_XDoverlap.Name = "lbl_XDoverlap";
            this.lbl_XDoverlap.Size = new System.Drawing.Size(308, 66);
            this.lbl_XDoverlap.TabIndex = 357;
            this.lbl_XDoverlap.Text = "與XD撞單";
            this.lbl_XDoverlap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_XDoverlap.Visible = false;
            // 
            // lbl_groi_left
            // 
            this.lbl_groi_left.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbl_groi_left.ForeColor = System.Drawing.Color.White;
            this.lbl_groi_left.Location = new System.Drawing.Point(762, 307);
            this.lbl_groi_left.Name = "lbl_groi_left";
            this.lbl_groi_left.Size = new System.Drawing.Size(36, 64);
            this.lbl_groi_left.TabIndex = 356;
            this.lbl_groi_left.Text = "剩餘量";
            this.lbl_groi_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_groi_left_value
            // 
            this.lbl_groi_left_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbl_groi_left_value.ForeColor = System.Drawing.Color.White;
            this.lbl_groi_left_value.Location = new System.Drawing.Point(787, 307);
            this.lbl_groi_left_value.Name = "lbl_groi_left_value";
            this.lbl_groi_left_value.Size = new System.Drawing.Size(152, 64);
            this.lbl_groi_left_value.TabIndex = 355;
            this.lbl_groi_left_value.Text = "0000";
            this.lbl_groi_left_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_S_slod_pick_name
            // 
            this.lbl_S_slod_pick_name.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_S_slod_pick_name.ForeColor = System.Drawing.Color.White;
            this.lbl_S_slod_pick_name.Location = new System.Drawing.Point(530, 5);
            this.lbl_S_slod_pick_name.Name = "lbl_S_slod_pick_name";
            this.lbl_S_slod_pick_name.Size = new System.Drawing.Size(150, 39);
            this.lbl_S_slod_pick_name.TabIndex = 354;
            this.lbl_S_slod_pick_name.Text = "ZoneName";
            // 
            // lbl_S_slod_pick
            // 
            this.lbl_S_slod_pick.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_S_slod_pick.ForeColor = System.Drawing.Color.White;
            this.lbl_S_slod_pick.Location = new System.Drawing.Point(492, 5);
            this.lbl_S_slod_pick.Name = "lbl_S_slod_pick";
            this.lbl_S_slod_pick.Size = new System.Drawing.Size(37, 39);
            this.lbl_S_slod_pick.TabIndex = 353;
            this.lbl_S_slod_pick.Text = "ZoneId";
            // 
            // txB_S_merp_barcode2
            // 
            this.txB_S_merp_barcode2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_S_merp_barcode2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txB_S_merp_barcode2.Location = new System.Drawing.Point(816, 212);
            this.txB_S_merp_barcode2.Name = "txB_S_merp_barcode2";
            this.txB_S_merp_barcode2.ReadOnly = true;
            this.txB_S_merp_barcode2.Size = new System.Drawing.Size(169, 29);
            this.txB_S_merp_barcode2.TabIndex = 350;
            // 
            // lbl_I_merp_1qty
            // 
            this.lbl_I_merp_1qty.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbl_I_merp_1qty.ForeColor = System.Drawing.Color.White;
            this.lbl_I_merp_1qty.Location = new System.Drawing.Point(350, 243);
            this.lbl_I_merp_1qty.Name = "lbl_I_merp_1qty";
            this.lbl_I_merp_1qty.Size = new System.Drawing.Size(36, 64);
            this.lbl_I_merp_1qty.TabIndex = 349;
            this.lbl_I_merp_1qty.Text = "組入數";
            this.lbl_I_merp_1qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_I_merp_1qty_value
            // 
            this.lbl_I_merp_1qty_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbl_I_merp_1qty_value.ForeColor = System.Drawing.Color.White;
            this.lbl_I_merp_1qty_value.Location = new System.Drawing.Point(375, 243);
            this.lbl_I_merp_1qty_value.Name = "lbl_I_merp_1qty_value";
            this.lbl_I_merp_1qty_value.Size = new System.Drawing.Size(121, 64);
            this.lbl_I_merp_1qty_value.TabIndex = 348;
            this.lbl_I_merp_1qty_value.Text = "000";
            this.lbl_I_merp_1qty_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txB_S_Merd_id
            // 
            this.txB_S_Merd_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_S_Merd_id.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txB_S_Merd_id.Location = new System.Drawing.Point(816, 182);
            this.txB_S_Merd_id.Name = "txB_S_Merd_id";
            this.txB_S_Merd_id.ReadOnly = true;
            this.txB_S_Merd_id.Size = new System.Drawing.Size(169, 29);
            this.txB_S_Merd_id.TabIndex = 346;
            // 
            // Lbl_WarringMsg
            // 
            this.Lbl_WarringMsg.AutoSize = true;
            this.Lbl_WarringMsg.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_WarringMsg.ForeColor = System.Drawing.Color.Red;
            this.Lbl_WarringMsg.Location = new System.Drawing.Point(13, 410);
            this.Lbl_WarringMsg.MaximumSize = new System.Drawing.Size(800, 0);
            this.Lbl_WarringMsg.Name = "Lbl_WarringMsg";
            this.Lbl_WarringMsg.Size = new System.Drawing.Size(308, 48);
            this.Lbl_WarringMsg.TabIndex = 345;
            this.Lbl_WarringMsg.Text = "刷入商品條碼";
            // 
            // cummit
            // 
            this.cummit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cummit.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cummit.Location = new System.Drawing.Point(171, 310);
            this.cummit.Name = "cummit";
            this.cummit.Size = new System.Drawing.Size(308, 97);
            this.cummit.TabIndex = 2;
            this.cummit.Text = "完成";
            this.cummit.UseVisualStyleBackColor = true;
            this.cummit.Click += new System.EventHandler(this.cummit_Click);
            // 
            // txB_picQty
            // 
            this.txB_picQty.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txB_picQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_picQty.Font = new System.Drawing.Font("新細明體", 36F);
            this.txB_picQty.ForeColor = System.Drawing.SystemColors.Window;
            this.txB_picQty.Location = new System.Drawing.Point(171, 243);
            this.txB_picQty.Name = "txB_picQty";
            this.txB_picQty.Size = new System.Drawing.Size(100, 58);
            this.txB_picQty.TabIndex = 1;
            this.txB_picQty.Validated += new System.EventHandler(this.txB_picQty_Validated);
            // 
            // txB_D_merl_expdate
            // 
            this.txB_D_merl_expdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_D_merl_expdate.Font = new System.Drawing.Font("新細明體", 36F);
            this.txB_D_merl_expdate.Location = new System.Drawing.Point(492, 183);
            this.txB_D_merl_expdate.Name = "txB_D_merl_expdate";
            this.txB_D_merl_expdate.ReadOnly = true;
            this.txB_D_merl_expdate.Size = new System.Drawing.Size(308, 58);
            this.txB_D_merl_expdate.TabIndex = 342;
            // 
            // txB_SlodId
            // 
            this.txB_SlodId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_SlodId.Font = new System.Drawing.Font("新細明體", 36F);
            this.txB_SlodId.Location = new System.Drawing.Point(171, 123);
            this.txB_SlodId.Name = "txB_SlodId";
            this.txB_SlodId.ReadOnly = true;
            this.txB_SlodId.Size = new System.Drawing.Size(320, 58);
            this.txB_SlodId.TabIndex = 341;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 39);
            this.label2.TabIndex = 340;
            this.label2.Text = "儲位編號";
            // 
            // rtxN_merd_name
            // 
            this.rtxN_merd_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxN_merd_name.Location = new System.Drawing.Point(492, 54);
            this.rtxN_merd_name.Name = "rtxN_merd_name";
            this.rtxN_merd_name.ReadOnly = true;
            this.rtxN_merd_name.Size = new System.Drawing.Size(493, 127);
            this.rtxN_merd_name.TabIndex = 339;
            this.rtxN_merd_name.Text = "";
            // 
            // txB_merdId
            // 
            this.txB_merdId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txB_merdId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_merdId.Font = new System.Drawing.Font("新細明體", 36F);
            this.txB_merdId.ForeColor = System.Drawing.SystemColors.Window;
            this.txB_merdId.Location = new System.Drawing.Point(171, 183);
            this.txB_merdId.Name = "txB_merdId";
            this.txB_merdId.Size = new System.Drawing.Size(320, 58);
            this.txB_merdId.TabIndex = 0;
            this.txB_merdId.Validated += new System.EventHandler(this.txB_merdId_Validated);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 338;
            this.label1.Text = "商品條碼";
            // 
            // lbL_repi_replqty_out_pallet_value
            // 
            this.lbL_repi_replqty_out_pallet_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbL_repi_replqty_out_pallet_value.ForeColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_pallet_value.Location = new System.Drawing.Point(787, 243);
            this.lbL_repi_replqty_out_pallet_value.Name = "lbL_repi_replqty_out_pallet_value";
            this.lbL_repi_replqty_out_pallet_value.Size = new System.Drawing.Size(152, 64);
            this.lbL_repi_replqty_out_pallet_value.TabIndex = 336;
            this.lbL_repi_replqty_out_pallet_value.Text = "0000";
            this.lbL_repi_replqty_out_pallet_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbL_repi_replqty_out_pallet_value.TextChanged += new System.EventHandler(this.lbL_repi_replqty_out_pallet_value_TextChanged);
            // 
            // lbL_repi_replqty_out_pallet
            // 
            this.lbL_repi_replqty_out_pallet.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbL_repi_replqty_out_pallet.ForeColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_pallet.Location = new System.Drawing.Point(761, 243);
            this.lbL_repi_replqty_out_pallet.Name = "lbL_repi_replqty_out_pallet";
            this.lbL_repi_replqty_out_pallet.Size = new System.Drawing.Size(37, 64);
            this.lbL_repi_replqty_out_pallet.TabIndex = 335;
            this.lbL_repi_replqty_out_pallet.Text = "已揀";
            this.lbL_repi_replqty_out_pallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbL_repi_replqty_out_box
            // 
            this.lbL_repi_replqty_out_box.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbL_repi_replqty_out_box.ForeColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_box.Location = new System.Drawing.Point(590, 243);
            this.lbL_repi_replqty_out_box.Name = "lbL_repi_replqty_out_box";
            this.lbL_repi_replqty_out_box.Size = new System.Drawing.Size(36, 64);
            this.lbL_repi_replqty_out_box.TabIndex = 334;
            this.lbL_repi_replqty_out_box.Text = "應揀";
            this.lbL_repi_replqty_out_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbL_repi_replqty_out_box_value
            // 
            this.lbL_repi_replqty_out_box_value.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold);
            this.lbL_repi_replqty_out_box_value.ForeColor = System.Drawing.Color.White;
            this.lbL_repi_replqty_out_box_value.Location = new System.Drawing.Point(615, 243);
            this.lbL_repi_replqty_out_box_value.Name = "lbL_repi_replqty_out_box_value";
            this.lbL_repi_replqty_out_box_value.Size = new System.Drawing.Size(152, 64);
            this.lbL_repi_replqty_out_box_value.TabIndex = 333;
            this.lbL_repi_replqty_out_box_value.Text = "0000";
            this.lbL_repi_replqty_out_box_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbL_repi_replqty_out_box_value.TextChanged += new System.EventHandler(this.lbL_repi_replqty_out_box_value_TextChanged);
            // 
            // lbL_recs_takenum1
            // 
            this.lbL_recs_takenum1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbL_recs_takenum1.ForeColor = System.Drawing.Color.White;
            this.lbL_recs_takenum1.Location = new System.Drawing.Point(15, 255);
            this.lbL_recs_takenum1.Name = "lbL_recs_takenum1";
            this.lbL_recs_takenum1.Size = new System.Drawing.Size(150, 39);
            this.lbL_recs_takenum1.TabIndex = 329;
            this.lbL_recs_takenum1.Text = "待  揀  量";
            // 
            // Lbl_Groh_id
            // 
            this.Lbl_Groh_id.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Groh_id.ForeColor = System.Drawing.Color.White;
            this.Lbl_Groh_id.Location = new System.Drawing.Point(270, 5);
            this.Lbl_Groh_id.Name = "Lbl_Groh_id";
            this.Lbl_Groh_id.Size = new System.Drawing.Size(216, 39);
            this.Lbl_Groh_id.TabIndex = 323;
            this.Lbl_Groh_id.Text = "PichId";
            // 
            // lbl_WorkZone2
            // 
            this.lbl_WorkZone2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_WorkZone2.ForeColor = System.Drawing.Color.White;
            this.lbl_WorkZone2.Location = new System.Drawing.Point(119, 5);
            this.lbl_WorkZone2.Name = "lbl_WorkZone2";
            this.lbl_WorkZone2.Size = new System.Drawing.Size(150, 39);
            this.lbl_WorkZone2.TabIndex = 322;
            this.lbl_WorkZone2.Text = "Zone";
            // 
            // lbl_SelectMode2
            // 
            this.lbl_SelectMode2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SelectMode2.ForeColor = System.Drawing.Color.White;
            this.lbl_SelectMode2.Location = new System.Drawing.Point(3, 5);
            this.lbl_SelectMode2.Name = "lbl_SelectMode2";
            this.lbl_SelectMode2.Size = new System.Drawing.Size(110, 39);
            this.lbl_SelectMode2.TabIndex = 321;
            this.lbl_SelectMode2.Text = "Mode";
            // 
            // lbl_takebox
            // 
            this.lbl_takebox.Font = new System.Drawing.Font("新細明體", 48F);
            this.lbl_takebox.ForeColor = System.Drawing.Color.White;
            this.lbl_takebox.Location = new System.Drawing.Point(267, 243);
            this.lbl_takebox.Name = "lbl_takebox";
            this.lbl_takebox.Size = new System.Drawing.Size(80, 62);
            this.lbl_takebox.TabIndex = 358;
            this.lbl_takebox.Text = "箱";
            this.lbl_takebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4_3";
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
        private System.Windows.Forms.Label Lbl_Groh_id;
        private System.Windows.Forms.Label lbL_recs_takenum1;
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
        private System.Windows.Forms.TextBox txB_S_Merd_id;
        private System.Windows.Forms.Label lbl_I_merp_1qty;
        private System.Windows.Forms.Label lbl_I_merp_1qty_value;
        private System.Windows.Forms.TextBox txB_S_merp_barcode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_groi_sechid;
        private System.Windows.Forms.Label lbl_S_slod_pick;
        private System.Windows.Forms.Label lbl_S_slod_pick_name;
        private System.Windows.Forms.Label lbl_groi_left;
        private System.Windows.Forms.Label lbl_groi_left_value;
        private System.Windows.Forms.Label lbl_XDoverlap;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_slod_pick_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_groh_opname;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_groh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_slod_pick;
        private System.Windows.Forms.Label lbl_takebox;
        private System.Windows.Forms.Label lbl_EApack;
        private System.Windows.Forms.Label lbl_EApack_Value;
        private Car_Fun.myButton cummit;
    }
}
