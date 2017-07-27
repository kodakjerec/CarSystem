namespace Car_Fun
{
    partial class CarSystem_Sample_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSystem_Sample_Form));
            this.CarSystem_FormBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorLeaveButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorNewButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDelButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCanceButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearchButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddItemButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDelItemButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPreviousButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSettingsButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorOKButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.CarSystem_FormBindingNavigator)).BeginInit();
            this.CarSystem_FormBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarSystem_FormBindingNavigator
            // 
            this.CarSystem_FormBindingNavigator.AddNewItem = null;
            this.CarSystem_FormBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.CarSystem_FormBindingNavigator.CountItem = null;
            this.CarSystem_FormBindingNavigator.DeleteItem = null;
            this.CarSystem_FormBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CarSystem_FormBindingNavigator.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.CarSystem_FormBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorLeaveButton,
            this.bindingNavigatorNewButton,
            this.bindingNavigatorEditButton,
            this.bindingNavigatorDelButton,
            this.bindingNavigatorSaveButton,
            this.bindingNavigatorCanceButton,
            this.bindingNavigatorSearchButton,
            this.bindingNavigatorAddItemButton,
            this.bindingNavigatorDelItemButton,
            this.bindingNavigatorPreviousButton,
            this.bindingNavigatorRefreshButton,
            this.bindingNavigatorSettingsButton,
            this.bindingNavigatorOKButton});
            this.CarSystem_FormBindingNavigator.Location = new System.Drawing.Point(0, 685);
            this.CarSystem_FormBindingNavigator.MoveFirstItem = null;
            this.CarSystem_FormBindingNavigator.MoveLastItem = null;
            this.CarSystem_FormBindingNavigator.MoveNextItem = null;
            this.CarSystem_FormBindingNavigator.MovePreviousItem = null;
            this.CarSystem_FormBindingNavigator.Name = "CarSystem_FormBindingNavigator";
            this.CarSystem_FormBindingNavigator.PositionItem = null;
            this.CarSystem_FormBindingNavigator.Size = new System.Drawing.Size(1024, 83);
            this.CarSystem_FormBindingNavigator.TabIndex = 1;
            this.CarSystem_FormBindingNavigator.Text = "功能表";
            // 
            // bindingNavigatorLeaveButton
            // 
            this.bindingNavigatorLeaveButton.AutoSize = false;
            this.bindingNavigatorLeaveButton.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorLeaveButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorLeaveButton.Image")));
            this.bindingNavigatorLeaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorLeaveButton.Name = "bindingNavigatorLeaveButton";
            this.bindingNavigatorLeaveButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorLeaveButton.Text = "離開(ESC)";
            this.bindingNavigatorLeaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorLeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // bindingNavigatorNewButton
            // 
            this.bindingNavigatorNewButton.AutoSize = false;
            this.bindingNavigatorNewButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorNewButton.Image")));
            this.bindingNavigatorNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorNewButton.Name = "bindingNavigatorNewButton";
            this.bindingNavigatorNewButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorNewButton.Text = "新增(&N)";
            this.bindingNavigatorNewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorNewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // bindingNavigatorEditButton
            // 
            this.bindingNavigatorEditButton.AutoSize = false;
            this.bindingNavigatorEditButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditButton.Image")));
            this.bindingNavigatorEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditButton.Name = "bindingNavigatorEditButton";
            this.bindingNavigatorEditButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorEditButton.Text = "修改(&E)";
            this.bindingNavigatorEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorEditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // bindingNavigatorDelButton
            // 
            this.bindingNavigatorDelButton.AutoSize = false;
            this.bindingNavigatorDelButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDelButton.Image")));
            this.bindingNavigatorDelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDelButton.Name = "bindingNavigatorDelButton";
            this.bindingNavigatorDelButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorDelButton.Text = "刪除(&D)";
            this.bindingNavigatorDelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // bindingNavigatorSaveButton
            // 
            this.bindingNavigatorSaveButton.AutoSize = false;
            this.bindingNavigatorSaveButton.Enabled = false;
            this.bindingNavigatorSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveButton.Image")));
            this.bindingNavigatorSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveButton.Name = "bindingNavigatorSaveButton";
            this.bindingNavigatorSaveButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorSaveButton.Text = "儲存(&S)";
            this.bindingNavigatorSaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // bindingNavigatorCanceButton
            // 
            this.bindingNavigatorCanceButton.AutoSize = false;
            this.bindingNavigatorCanceButton.Enabled = false;
            this.bindingNavigatorCanceButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCanceButton.Image")));
            this.bindingNavigatorCanceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCanceButton.Name = "bindingNavigatorCanceButton";
            this.bindingNavigatorCanceButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorCanceButton.Text = "取消(&C)";
            this.bindingNavigatorCanceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCanceButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // bindingNavigatorSearchButton
            // 
            this.bindingNavigatorSearchButton.AutoSize = false;
            this.bindingNavigatorSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSearchButton.Image")));
            this.bindingNavigatorSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearchButton.Name = "bindingNavigatorSearchButton";
            this.bindingNavigatorSearchButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorSearchButton.Text = "查詢(&F)";
            this.bindingNavigatorSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // bindingNavigatorAddItemButton
            // 
            this.bindingNavigatorAddItemButton.AutoSize = false;
            this.bindingNavigatorAddItemButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddItemButton.Image")));
            this.bindingNavigatorAddItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAddItemButton.Name = "bindingNavigatorAddItemButton";
            this.bindingNavigatorAddItemButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorAddItemButton.Text = "新增明細(F11)";
            this.bindingNavigatorAddItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // bindingNavigatorDelItemButton
            // 
            this.bindingNavigatorDelItemButton.AutoSize = false;
            this.bindingNavigatorDelItemButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDelItemButton.Image")));
            this.bindingNavigatorDelItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDelItemButton.Name = "bindingNavigatorDelItemButton";
            this.bindingNavigatorDelItemButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorDelItemButton.Text = "刪除明細(F12)";
            this.bindingNavigatorDelItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDelItemButton.Click += new System.EventHandler(this.DelItemButton_Click);
            // 
            // bindingNavigatorPreviousButton
            // 
            this.bindingNavigatorPreviousButton.AutoSize = false;
            this.bindingNavigatorPreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPreviousButton.Image")));
            this.bindingNavigatorPreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorPreviousButton.Name = "bindingNavigatorPreviousButton";
            this.bindingNavigatorPreviousButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorPreviousButton.Text = "上一步";
            this.bindingNavigatorPreviousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorPreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // bindingNavigatorRefreshButton
            // 
            this.bindingNavigatorRefreshButton.AutoSize = false;
            this.bindingNavigatorRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefreshButton.Image")));
            this.bindingNavigatorRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshButton.Name = "bindingNavigatorRefreshButton";
            this.bindingNavigatorRefreshButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorRefreshButton.Text = "更新";
            this.bindingNavigatorRefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSettingsButton
            // 
            this.bindingNavigatorSettingsButton.AutoSize = false;
            this.bindingNavigatorSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSettingsButton.Image")));
            this.bindingNavigatorSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSettingsButton.Name = "bindingNavigatorSettingsButton";
            this.bindingNavigatorSettingsButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorSettingsButton.Text = "設定";
            this.bindingNavigatorSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // bindingNavigatorOKButton
            // 
            this.bindingNavigatorOKButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorOKButton.AutoSize = false;
            this.bindingNavigatorOKButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorOKButton.Image")));
            this.bindingNavigatorOKButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorOKButton.Name = "bindingNavigatorOKButton";
            this.bindingNavigatorOKButton.Size = new System.Drawing.Size(160, 80);
            this.bindingNavigatorOKButton.Text = "確認";
            this.bindingNavigatorOKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorOKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CarSystem_Sample_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.CarSystem_FormBindingNavigator);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "CarSystem_Sample_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarSystem_Sample_Form";
            this.Load += new System.EventHandler(this.New_WSC_DLL_Form_Load);
            this.Resize += new System.EventHandler(this.CarSystem_Sample_Form_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WSC_Sample_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CarSystem_FormBindingNavigator)).EndInit();
            this.CarSystem_FormBindingNavigator.ResumeLayout(false);
            this.CarSystem_FormBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStripButton bindingNavigatorNewButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorEditButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorDelButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorLeaveButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorCanceButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorSaveButton;
        protected System.Windows.Forms.BindingNavigator CarSystem_FormBindingNavigator;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorSearchButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorAddItemButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorDelItemButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorPreviousButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorRefreshButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorSettingsButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorOKButton;
    }
}