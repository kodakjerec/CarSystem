namespace CarSystem
{
    partial class Form2_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Stock = new Car_Fun.myButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Aisle = new Car_Fun.myButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Location = new Car_Fun.myButton();
            this.pal_Edit = new System.Windows.Forms.Panel();
            this.cmb_SlotID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_X_pos = new System.Windows.Forms.TextBox();
            this.txb_Y_pos = new System.Windows.Forms.TextBox();
            this.txb_X_width = new System.Windows.Forms.TextBox();
            this.txb_Y_width = new System.Windows.Forms.TextBox();
            this.btn_Update = new Car_Fun.myButton();
            this.lbl_L_sdXY_sysno = new System.Windows.Forms.Label();
            this.lbl_StartXY = new System.Windows.Forms.Label();
            this.pal_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock";
            // 
            // btn_Stock
            // 
            this.btn_Stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stock.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Stock.Location = new System.Drawing.Point(70, 11);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(75, 28);
            this.btn_Stock.TabIndex = 3;
            this.btn_Stock.Text = "DC1F";
            this.btn_Stock.UseVisualStyleBackColor = true;
            this.btn_Stock.Click += new System.EventHandler(this.btn_Stock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aisle";
            // 
            // btn_Aisle
            // 
            this.btn_Aisle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aisle.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Aisle.Location = new System.Drawing.Point(210, 11);
            this.btn_Aisle.Name = "btn_Aisle";
            this.btn_Aisle.Size = new System.Drawing.Size(75, 28);
            this.btn_Aisle.TabIndex = 5;
            this.btn_Aisle.Text = "AA";
            this.btn_Aisle.UseVisualStyleBackColor = true;
            this.btn_Aisle.Click += new System.EventHandler(this.btn_Aisle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(290, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loca";
            // 
            // btn_Location
            // 
            this.btn_Location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Location.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Location.Location = new System.Drawing.Point(350, 11);
            this.btn_Location.Name = "btn_Location";
            this.btn_Location.Size = new System.Drawing.Size(75, 28);
            this.btn_Location.TabIndex = 7;
            this.btn_Location.Text = "01";
            this.btn_Location.UseVisualStyleBackColor = true;
            this.btn_Location.Click += new System.EventHandler(this.btn_Location_Click);
            // 
            // pal_Edit
            // 
            this.pal_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.pal_Edit.Controls.Add(this.lbl_L_sdXY_sysno);
            this.pal_Edit.Controls.Add(this.btn_Update);
            this.pal_Edit.Controls.Add(this.txb_Y_width);
            this.pal_Edit.Controls.Add(this.txb_X_width);
            this.pal_Edit.Controls.Add(this.txb_Y_pos);
            this.pal_Edit.Controls.Add(this.txb_X_pos);
            this.pal_Edit.Controls.Add(this.label7);
            this.pal_Edit.Controls.Add(this.label8);
            this.pal_Edit.Controls.Add(this.label6);
            this.pal_Edit.Controls.Add(this.label5);
            this.pal_Edit.Controls.Add(this.label4);
            this.pal_Edit.Controls.Add(this.cmb_SlotID);
            this.pal_Edit.Location = new System.Drawing.Point(820, 45);
            this.pal_Edit.Name = "pal_Edit";
            this.pal_Edit.Size = new System.Drawing.Size(200, 600);
            this.pal_Edit.TabIndex = 9;
            // 
            // cmb_SlotID
            // 
            this.cmb_SlotID.DisplayMember = "Name";
            this.cmb_SlotID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SlotID.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_SlotID.FormattingEnabled = true;
            this.cmb_SlotID.Location = new System.Drawing.Point(10, 40);
            this.cmb_SlotID.Name = "cmb_SlotID";
            this.cmb_SlotID.Size = new System.Drawing.Size(180, 40);
            this.cmb_SlotID.TabIndex = 0;
            this.cmb_SlotID.ValueMember = "Name";
            this.cmb_SlotID.SelectedIndexChanged += new System.EventHandler(this.cmb_SlotID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "儲位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(4, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "X軸";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(4, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Y軸";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(4, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Y高度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(4, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "X寬度";
            // 
            // txb_X_pos
            // 
            this.txb_X_pos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_X_pos.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_X_pos.Location = new System.Drawing.Point(10, 118);
            this.txb_X_pos.Name = "txb_X_pos";
            this.txb_X_pos.Size = new System.Drawing.Size(100, 39);
            this.txb_X_pos.TabIndex = 6;
            // 
            // txb_Y_pos
            // 
            this.txb_Y_pos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Y_pos.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_Y_pos.Location = new System.Drawing.Point(10, 205);
            this.txb_Y_pos.Name = "txb_Y_pos";
            this.txb_Y_pos.Size = new System.Drawing.Size(100, 39);
            this.txb_Y_pos.TabIndex = 7;
            // 
            // txb_X_width
            // 
            this.txb_X_width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_X_width.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_X_width.Location = new System.Drawing.Point(10, 301);
            this.txb_X_width.Name = "txb_X_width";
            this.txb_X_width.Size = new System.Drawing.Size(100, 39);
            this.txb_X_width.TabIndex = 8;
            // 
            // txb_Y_width
            // 
            this.txb_Y_width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Y_width.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_Y_width.Location = new System.Drawing.Point(10, 388);
            this.txb_Y_width.Name = "txb_Y_width";
            this.txb_Y_width.Size = new System.Drawing.Size(100, 39);
            this.txb_Y_width.TabIndex = 9;
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Update.Location = new System.Drawing.Point(10, 468);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 46);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "更新";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_L_sdXY_sysno
            // 
            this.lbl_L_sdXY_sysno.AutoSize = true;
            this.lbl_L_sdXY_sysno.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbl_L_sdXY_sysno.Location = new System.Drawing.Point(10, 434);
            this.lbl_L_sdXY_sysno.Name = "lbl_L_sdXY_sysno";
            this.lbl_L_sdXY_sysno.Size = new System.Drawing.Size(33, 12);
            this.lbl_L_sdXY_sysno.TabIndex = 11;
            this.lbl_L_sdXY_sysno.Text = "label9";
            // 
            // lbl_StartXY
            // 
            this.lbl_StartXY.AutoSize = true;
            this.lbl_StartXY.ForeColor = System.Drawing.Color.White;
            this.lbl_StartXY.Location = new System.Drawing.Point(12, 50);
            this.lbl_StartXY.Name = "lbl_StartXY";
            this.lbl_StartXY.Size = new System.Drawing.Size(11, 12);
            this.lbl_StartXY.TabIndex = 10;
            this.lbl_StartXY.Text = "+";
            // 
            // Form2_2
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lbl_StartXY);
            this.Controls.Add(this.pal_Edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Aisle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Stock);
            this.Name = "Form2_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form2_2_Load);
            this.Controls.SetChildIndex(this.btn_Stock, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_Aisle, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_Location, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pal_Edit, 0);
            this.Controls.SetChildIndex(this.lbl_StartXY, 0);
            this.pal_Edit.ResumeLayout(false);
            this.pal_Edit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Car_Fun.myButton btn_Stock;
        private System.Windows.Forms.Label label2;
        private Car_Fun.myButton btn_Aisle;
        private System.Windows.Forms.Label label3;
        private Car_Fun.myButton btn_Location;
        private System.Windows.Forms.Panel pal_Edit;
        private System.Windows.Forms.ComboBox cmb_SlotID;
        private System.Windows.Forms.TextBox txb_Y_width;
        private System.Windows.Forms.TextBox txb_X_width;
        private System.Windows.Forms.TextBox txb_Y_pos;
        private System.Windows.Forms.TextBox txb_X_pos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Car_Fun.myButton btn_Update;
        private System.Windows.Forms.Label lbl_L_sdXY_sysno;
        private System.Windows.Forms.Label lbl_StartXY;
    }
}
