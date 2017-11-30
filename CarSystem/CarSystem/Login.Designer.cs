namespace CarSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txb_UserId = new System.Windows.Forms.TextBox();
            this.txb_UserPsw = new System.Windows.Forms.TextBox();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.Lbl_FileVersion = new System.Windows.Forms.Label();
            this.btn_LogIn = new Car_Fun.myButton();
            this.btn_Power = new System.Windows.Forms.Button();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.rTB_ModifyLog = new System.Windows.Forms.RichTextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_hostname = new System.Windows.Forms.Label();
            this.pnl_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_UserId
            // 
            this.txb_UserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_UserId.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserId.Location = new System.Drawing.Point(265, 12);
            this.txb_UserId.MaxLength = 8;
            this.txb_UserId.Name = "txb_UserId";
            this.txb_UserId.Size = new System.Drawing.Size(259, 77);
            this.txb_UserId.TabIndex = 2;
            // 
            // txb_UserPsw
            // 
            this.txb_UserPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_UserPsw.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserPsw.Location = new System.Drawing.Point(265, 97);
            this.txb_UserPsw.MaxLength = 20;
            this.txb_UserPsw.Name = "txb_UserPsw";
            this.txb_UserPsw.PasswordChar = '*';
            this.txb_UserPsw.Size = new System.Drawing.Size(259, 77);
            this.txb_UserPsw.TabIndex = 3;
            this.txb_UserPsw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_UserPsw_KeyDown);
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_UserId.ForeColor = System.Drawing.Color.White;
            this.lbl_UserId.Location = new System.Drawing.Point(3, 25);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(260, 48);
            this.lbl_UserId.TabIndex = 4;
            this.lbl_UserId.Text = "員工編號：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "登入密碼：";
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.Lbl_FileVersion);
            this.pnl_1.Controls.Add(this.btn_LogIn);
            this.pnl_1.Controls.Add(this.txb_UserPsw);
            this.pnl_1.Controls.Add(this.label1);
            this.pnl_1.Controls.Add(this.txb_UserId);
            this.pnl_1.Controls.Add(this.lbl_UserId);
            this.pnl_1.Location = new System.Drawing.Point(230, 50);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(527, 282);
            this.pnl_1.TabIndex = 6;
            // 
            // Lbl_FileVersion
            // 
            this.Lbl_FileVersion.AutoSize = true;
            this.Lbl_FileVersion.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_FileVersion.ForeColor = System.Drawing.Color.White;
            this.Lbl_FileVersion.Location = new System.Drawing.Point(5, 253);
            this.Lbl_FileVersion.Name = "Lbl_FileVersion";
            this.Lbl_FileVersion.Size = new System.Drawing.Size(116, 24);
            this.Lbl_FileVersion.TabIndex = 7;
            this.Lbl_FileVersion.Text = "FileVersion";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogIn.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LogIn.Location = new System.Drawing.Point(265, 184);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(259, 97);
            this.btn_LogIn.TabIndex = 6;
            this.btn_LogIn.Text = "登入";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Power
            // 
            this.btn_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Power.BackColor = System.Drawing.Color.Transparent;
            this.btn_Power.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Power.BackgroundImage")));
            this.btn_Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Power.Location = new System.Drawing.Point(0, 576);
            this.btn_Power.Name = "btn_Power";
            this.btn_Power.Size = new System.Drawing.Size(62, 63);
            this.btn_Power.TabIndex = 8;
            this.btn_Power.UseVisualStyleBackColor = false;
            this.btn_Power.Click += new System.EventHandler(this.btn_Power_Click);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbl_Exit.Location = new System.Drawing.Point(68, 576);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(155, 63);
            this.lbl_Exit.TabIndex = 9;
            this.lbl_Exit.Text = "點我離開";
            this.lbl_Exit.Click += new System.EventHandler(this.LeaveThisForm);
            // 
            // rTB_ModifyLog
            // 
            this.rTB_ModifyLog.BackColor = System.Drawing.Color.Black;
            this.rTB_ModifyLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB_ModifyLog.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTB_ModifyLog.ForeColor = System.Drawing.Color.White;
            this.rTB_ModifyLog.Location = new System.Drawing.Point(74, 338);
            this.rTB_ModifyLog.Name = "rTB_ModifyLog";
            this.rTB_ModifyLog.Size = new System.Drawing.Size(867, 235);
            this.rTB_ModifyLog.TabIndex = 10;
            this.rTB_ModifyLog.Text = "";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Location.ForeColor = System.Drawing.Color.White;
            this.lbl_Location.Location = new System.Drawing.Point(775, 9);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(63, 16);
            this.lbl_Location.TabIndex = 8;
            this.lbl_Location.Text = "Location";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_IP.ForeColor = System.Drawing.Color.White;
            this.lbl_IP.Location = new System.Drawing.Point(775, 49);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(72, 16);
            this.lbl_IP.TabIndex = 8;
            this.lbl_IP.Text = "IPAddress";
            // 
            // lbl_hostname
            // 
            this.lbl_hostname.AutoSize = true;
            this.lbl_hostname.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_hostname.ForeColor = System.Drawing.Color.White;
            this.lbl_hostname.Location = new System.Drawing.Point(775, 29);
            this.lbl_hostname.Name = "lbl_hostname";
            this.lbl_hostname.Size = new System.Drawing.Size(71, 16);
            this.lbl_hostname.TabIndex = 9;
            this.lbl_hostname.Text = "Hostname";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.lbl_hostname);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.rTB_ModifyLog);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.btn_Power);
            this.Controls.Add(this.pnl_1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LogIn";
            this.Controls.SetChildIndex(this.pnl_1, 0);
            this.Controls.SetChildIndex(this.btn_Power, 0);
            this.Controls.SetChildIndex(this.lbl_Exit, 0);
            this.Controls.SetChildIndex(this.rTB_ModifyLog, 0);
            this.Controls.SetChildIndex(this.lbl_Location, 0);
            this.Controls.SetChildIndex(this.lbl_hostname, 0);
            this.Controls.SetChildIndex(this.lbl_IP, 0);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_UserId;
        private System.Windows.Forms.TextBox txb_UserPsw;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_1;
        private Car_Fun.myButton btn_LogIn;
        private System.Windows.Forms.Button btn_Power;
        private System.Windows.Forms.Label Lbl_FileVersion;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.RichTextBox rTB_ModifyLog;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_hostname;
    }
}

