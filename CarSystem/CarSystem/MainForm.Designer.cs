namespace CarSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_3_1 = new Car_Fun.myButton();
            this.btn_6_1 = new Car_Fun.myButton();
            this.btn_Leave = new System.Windows.Forms.Button();
            this.btn_6_2 = new Car_Fun.myButton();
            this.btn_9_1 = new Car_Fun.myButton();
            this.btn_4_2 = new Car_Fun.myButton();
            this.btn_4_3 = new Car_Fun.myButton();
            this.btn_9_2 = new Car_Fun.myButton();
            this.lbl_OperationLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_3_1
            // 
            this.btn_3_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3_1.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_3_1.Location = new System.Drawing.Point(75, 61);
            this.btn_3_1.Name = "btn_3_1";
            this.btn_3_1.Size = new System.Drawing.Size(435, 144);
            this.btn_3_1.TabIndex = 0;
            this.btn_3_1.Text = "3-1 上架作業";
            this.btn_3_1.UseVisualStyleBackColor = true;
            this.btn_3_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_6_1
            // 
            this.btn_6_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6_1.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_6_1.Location = new System.Drawing.Point(75, 235);
            this.btn_6_1.Name = "btn_6_1";
            this.btn_6_1.Size = new System.Drawing.Size(435, 144);
            this.btn_6_1.TabIndex = 2;
            this.btn_6_1.Text = "6-1 調儲作業";
            this.btn_6_1.UseVisualStyleBackColor = true;
            this.btn_6_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Leave
            // 
            this.btn_Leave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Leave.BackColor = System.Drawing.Color.Transparent;
            this.btn_Leave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Leave.BackgroundImage")));
            this.btn_Leave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Leave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Leave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Leave.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Leave.Location = new System.Drawing.Point(0, 627);
            this.btn_Leave.Name = "btn_Leave";
            this.btn_Leave.Size = new System.Drawing.Size(62, 63);
            this.btn_Leave.TabIndex = 7;
            this.btn_Leave.UseVisualStyleBackColor = false;
            // 
            // btn_6_2
            // 
            this.btn_6_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6_2.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_6_2.Location = new System.Drawing.Point(537, 235);
            this.btn_6_2.Name = "btn_6_2";
            this.btn_6_2.Size = new System.Drawing.Size(435, 144);
            this.btn_6_2.TabIndex = 3;
            this.btn_6_2.Text = "6-2 補貨作業";
            this.btn_6_2.UseVisualStyleBackColor = true;
            this.btn_6_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_9_1
            // 
            this.btn_9_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9_1.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_9_1.Location = new System.Drawing.Point(537, 410);
            this.btn_9_1.Name = "btn_9_1";
            this.btn_9_1.Size = new System.Drawing.Size(435, 144);
            this.btn_9_1.TabIndex = 5;
            this.btn_9_1.Text = "9-1 商品查詢";
            this.btn_9_1.UseVisualStyleBackColor = true;
            this.btn_9_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_4_2
            // 
            this.btn_4_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4_2.Enabled = false;
            this.btn_4_2.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_4_2.Location = new System.Drawing.Point(75, 410);
            this.btn_4_2.Name = "btn_4_2";
            this.btn_4_2.Size = new System.Drawing.Size(435, 144);
            this.btn_4_2.TabIndex = 4;
            this.btn_4_2.Text = "4-2 拆零揀貨";
            this.btn_4_2.UseVisualStyleBackColor = true;
            this.btn_4_2.Visible = false;
            this.btn_4_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_4_3
            // 
            this.btn_4_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4_3.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_4_3.Location = new System.Drawing.Point(537, 61);
            this.btn_4_3.Name = "btn_4_3";
            this.btn_4_3.Size = new System.Drawing.Size(435, 144);
            this.btn_4_3.TabIndex = 1;
            this.btn_4_3.Text = "4-3 彙總揀貨";
            this.btn_4_3.UseVisualStyleBackColor = false;
            this.btn_4_3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_9_2
            // 
            this.btn_9_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9_2.Font = new System.Drawing.Font("新細明體", 48F);
            this.btn_9_2.Location = new System.Drawing.Point(537, 586);
            this.btn_9_2.Name = "btn_9_2";
            this.btn_9_2.Size = new System.Drawing.Size(435, 144);
            this.btn_9_2.TabIndex = 6;
            this.btn_9_2.Text = "9-2 操作紀錄";
            this.btn_9_2.UseVisualStyleBackColor = true;
            this.btn_9_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // lbl_OperationLog
            // 
            this.lbl_OperationLog.AutoSize = true;
            this.lbl_OperationLog.ForeColor = System.Drawing.Color.White;
            this.lbl_OperationLog.Location = new System.Drawing.Point(13, 13);
            this.lbl_OperationLog.Name = "lbl_OperationLog";
            this.lbl_OperationLog.Size = new System.Drawing.Size(33, 12);
            this.lbl_OperationLog.TabIndex = 8;
            this.lbl_OperationLog.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1036, 690);
            this.Controls.Add(this.lbl_OperationLog);
            this.Controls.Add(this.btn_9_2);
            this.Controls.Add(this.btn_4_3);
            this.Controls.Add(this.btn_4_2);
            this.Controls.Add(this.btn_9_1);
            this.Controls.Add(this.btn_6_2);
            this.Controls.Add(this.btn_Leave);
            this.Controls.Add(this.btn_6_1);
            this.Controls.Add(this.btn_3_1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.btn_3_1, 0);
            this.Controls.SetChildIndex(this.btn_6_1, 0);
            this.Controls.SetChildIndex(this.btn_Leave, 0);
            this.Controls.SetChildIndex(this.btn_6_2, 0);
            this.Controls.SetChildIndex(this.btn_9_1, 0);
            this.Controls.SetChildIndex(this.btn_4_2, 0);
            this.Controls.SetChildIndex(this.btn_4_3, 0);
            this.Controls.SetChildIndex(this.btn_9_2, 0);
            this.Controls.SetChildIndex(this.lbl_OperationLog, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Leave;
        private Car_Fun.myButton btn_3_1;
        private Car_Fun.myButton btn_6_1;
        private Car_Fun.myButton btn_6_2;
        private Car_Fun.myButton btn_9_1;
        private Car_Fun.myButton btn_4_2;
        private Car_Fun.myButton btn_4_3;
        private Car_Fun.myButton btn_9_2;
        private System.Windows.Forms.Label lbl_OperationLog;

    }
}
