namespace CarSysUpLoad
{
    partial class CarLoadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarLoadForm));
            this.lbx_UploadList = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Dle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmi_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_DC = new System.Windows.Forms.GroupBox();
            this.ckb_DC02 = new System.Windows.Forms.CheckBox();
            this.ckb_DC01 = new System.Windows.Forms.CheckBox();
            this.ckb_DC3 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.gb_DC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_UploadList
            // 
            this.lbx_UploadList.AllowDrop = true;
            this.lbx_UploadList.FormattingEnabled = true;
            this.lbx_UploadList.ItemHeight = 12;
            this.lbx_UploadList.Location = new System.Drawing.Point(29, 74);
            this.lbx_UploadList.Name = "lbx_UploadList";
            this.lbx_UploadList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbx_UploadList.Size = new System.Drawing.Size(603, 196);
            this.lbx_UploadList.TabIndex = 1;
            this.lbx_UploadList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbx_UploadList_DragDrop);
            this.lbx_UploadList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbx_UploadList_DragEnter);
            this.lbx_UploadList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbx_UploadList_MouseDown);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(29, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(156, 44);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "加入上傳";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Load.ForeColor = System.Drawing.Color.Blue;
            this.btn_Load.Location = new System.Drawing.Point(257, 310);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(129, 67);
            this.btn_Load.TabIndex = 3;
            this.btn_Load.Text = "上傳";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Dle
            // 
            this.btn_Dle.Location = new System.Drawing.Point(476, 13);
            this.btn_Dle.Name = "btn_Dle";
            this.btn_Dle.Size = new System.Drawing.Size(156, 44);
            this.btn_Dle.TabIndex = 4;
            this.btn_Dle.Text = "刪除";
            this.btn_Dle.UseVisualStyleBackColor = true;
            this.btn_Dle.Click += new System.EventHandler(this.btn_Dle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_Del});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // tmi_Del
            // 
            this.tmi_Del.Image = ((System.Drawing.Image)(resources.GetObject("tmi_Del.Image")));
            this.tmi_Del.Name = "tmi_Del";
            this.tmi_Del.Size = new System.Drawing.Size(94, 22);
            this.tmi_Del.Text = "刪除";
            this.tmi_Del.Click += new System.EventHandler(this.tmi_Del_Click);
            // 
            // gb_DC
            // 
            this.gb_DC.Controls.Add(this.ckb_DC3);
            this.gb_DC.Controls.Add(this.ckb_DC02);
            this.gb_DC.Controls.Add(this.ckb_DC01);
            this.gb_DC.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb_DC.Location = new System.Drawing.Point(29, 276);
            this.gb_DC.Name = "gb_DC";
            this.gb_DC.Size = new System.Drawing.Size(200, 118);
            this.gb_DC.TabIndex = 7;
            this.gb_DC.TabStop = false;
            this.gb_DC.Text = "倉別";
            // 
            // ckb_DC02
            // 
            this.ckb_DC02.AutoSize = true;
            this.ckb_DC02.Location = new System.Drawing.Point(38, 55);
            this.ckb_DC02.Name = "ckb_DC02";
            this.ckb_DC02.Size = new System.Drawing.Size(148, 23);
            this.ckb_DC02.TabIndex = 1;
            this.ckb_DC02.Tag = "pxwms_s";
            this.ckb_DC02.Text = "岡山物流中心";
            this.ckb_DC02.UseVisualStyleBackColor = true;
            // 
            // ckb_DC01
            // 
            this.ckb_DC01.AutoSize = true;
            this.ckb_DC01.Location = new System.Drawing.Point(38, 30);
            this.ckb_DC01.Name = "ckb_DC01";
            this.ckb_DC01.Size = new System.Drawing.Size(148, 23);
            this.ckb_DC01.TabIndex = 0;
            this.ckb_DC01.Tag = "pxwms_n";
            this.ckb_DC01.Text = "觀音物流中心";
            this.ckb_DC01.UseVisualStyleBackColor = true;
            // 
            // ckb_DC3
            // 
            this.ckb_DC3.AutoSize = true;
            this.ckb_DC3.Location = new System.Drawing.Point(38, 80);
            this.ckb_DC3.Name = "ckb_DC3";
            this.ckb_DC3.Size = new System.Drawing.Size(148, 23);
            this.ckb_DC3.TabIndex = 2;
            this.ckb_DC3.Tag = "pxwms_c";
            this.ckb_DC3.Text = "梧棲物流中心";
            this.ckb_DC3.UseVisualStyleBackColor = true;
            // 
            // CarLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(668, 406);
            this.Controls.Add(this.gb_DC);
            this.Controls.Add(this.btn_Dle);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbx_UploadList);
            this.Controls.Add(this.btn_Load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CarLoadForm";
            this.Text = "車堆高機程式上傳系統 V1.1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.gb_DC.ResumeLayout(false);
            this.gb_DC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_UploadList;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Dle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmi_Del;
        private System.Windows.Forms.GroupBox gb_DC;
        private System.Windows.Forms.CheckBox ckb_DC02;
        private System.Windows.Forms.CheckBox ckb_DC01;
        private System.Windows.Forms.CheckBox ckb_DC3;
    }
}

