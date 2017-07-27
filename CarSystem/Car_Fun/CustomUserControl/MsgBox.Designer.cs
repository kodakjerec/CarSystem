namespace Car_Fun
{
    partial class MsgBox
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
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_TimeCount = new System.Windows.Forms.Label();
            this.lbl_timecount_memo = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Submit = new myButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Font = new System.Drawing.Font("細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Msg.Location = new System.Drawing.Point(3, 53);
            this.lbl_Msg.MaximumSize = new System.Drawing.Size(640, 640);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(57, 27);
            this.lbl_Msg.TabIndex = 0;
            this.lbl_Msg.Text = "msg";
            this.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_TimeCount
            // 
            this.lbl_TimeCount.AutoSize = true;
            this.lbl_TimeCount.Font = new System.Drawing.Font("細明體", 24F);
            this.lbl_TimeCount.Location = new System.Drawing.Point(5, 279);
            this.lbl_TimeCount.Name = "lbl_TimeCount";
            this.lbl_TimeCount.Size = new System.Drawing.Size(47, 32);
            this.lbl_TimeCount.TabIndex = 2;
            this.lbl_TimeCount.Text = "10";
            // 
            // lbl_timecount_memo
            // 
            this.lbl_timecount_memo.AutoSize = true;
            this.lbl_timecount_memo.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_timecount_memo.Location = new System.Drawing.Point(43, 294);
            this.lbl_timecount_memo.Name = "lbl_timecount_memo";
            this.lbl_timecount_memo.Size = new System.Drawing.Size(104, 16);
            this.lbl_timecount_memo.TabIndex = 3;
            this.lbl_timecount_memo.Text = "秒後自動關閉";
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_title.Font = new System.Drawing.Font("細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(1, 1);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(638, 50);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "警告";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Msg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 320);
            this.panel1.TabIndex = 5;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.Location = new System.Drawing.Point(241, 224);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(133, 47);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "確定";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_timecount_memo);
            this.Controls.Add(this.lbl_TimeCount);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "警告";
            this.Load += new System.EventHandler(this.MsgBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Msg;
        private myButton btn_Submit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_TimeCount;
        private System.Windows.Forms.Label lbl_timecount_memo;
        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
    }
}