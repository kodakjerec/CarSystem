namespace Car_Fun
{
    partial class MsgYesNoBox
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
            this.lbl_timecount_memo = new System.Windows.Forms.Label();
            this.lbl_TimeCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_No = new myButton();
            this.btn_Yes = new myButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Font = new System.Drawing.Font("細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Msg.Location = new System.Drawing.Point(3, 53);
            this.lbl_Msg.MaximumSize = new System.Drawing.Size(580, 400);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(57, 27);
            this.lbl_Msg.TabIndex = 2;
            this.lbl_Msg.Text = "msg";
            // 
            // lbl_timecount_memo
            // 
            this.lbl_timecount_memo.AutoSize = true;
            this.lbl_timecount_memo.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_timecount_memo.Location = new System.Drawing.Point(43, 294);
            this.lbl_timecount_memo.Name = "lbl_timecount_memo";
            this.lbl_timecount_memo.Size = new System.Drawing.Size(120, 16);
            this.lbl_timecount_memo.TabIndex = 5;
            this.lbl_timecount_memo.Text = "秒後自動按\"否\"";
            // 
            // lbl_TimeCount
            // 
            this.lbl_TimeCount.AutoSize = true;
            this.lbl_TimeCount.Font = new System.Drawing.Font("細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_TimeCount.Location = new System.Drawing.Point(5, 279);
            this.lbl_TimeCount.Name = "lbl_TimeCount";
            this.lbl_TimeCount.Size = new System.Drawing.Size(47, 32);
            this.lbl_TimeCount.TabIndex = 4;
            this.lbl_TimeCount.Text = "10";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_title.Font = new System.Drawing.Font("細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(1, 1);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(638, 50);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "詢問";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_No
            // 
            this.btn_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_No.Font = new System.Drawing.Font("細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_No.Location = new System.Drawing.Point(348, 224);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(133, 47);
            this.btn_No.TabIndex = 1;
            this.btn_No.Text = "否";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yes.Font = new System.Drawing.Font("細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Yes.Location = new System.Drawing.Point(108, 224);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(133, 47);
            this.btn_Yes.TabIndex = 0;
            this.btn_Yes.Text = "是";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 320);
            this.panel1.TabIndex = 7;
            // 
            // MsgYesNoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_timecount_memo);
            this.Controls.Add(this.lbl_TimeCount);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgYesNoBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgYesNoBox";
            this.Load += new System.EventHandler(this.MsgYesNoBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myButton btn_Yes;
        private myButton btn_No;
        public System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.Label lbl_timecount_memo;
        private System.Windows.Forms.Label lbl_TimeCount;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
    }
}