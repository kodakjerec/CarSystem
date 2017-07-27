namespace CarSystem
{
    partial class FormSelect
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
            this.btn_Confirm = new Car_Fun.myButton();
            this.lbl_Selected = new System.Windows.Forms.Label();
            this.dgv_SelectList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Confirm.Location = new System.Drawing.Point(189, 418);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(250, 50);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "決定";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_Selected
            // 
            this.lbl_Selected.AutoSize = true;
            this.lbl_Selected.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Selected.ForeColor = System.Drawing.Color.Red;
            this.lbl_Selected.Location = new System.Drawing.Point(246, 367);
            this.lbl_Selected.Name = "lbl_Selected";
            this.lbl_Selected.Size = new System.Drawing.Size(132, 48);
            this.lbl_Selected.TabIndex = 1;
            this.lbl_Selected.Text = "label1";
            // 
            // dgv_SelectList
            // 
            this.dgv_SelectList.AllowUserToAddRows = false;
            this.dgv_SelectList.AllowUserToDeleteRows = false;
            this.dgv_SelectList.AllowUserToResizeColumns = false;
            this.dgv_SelectList.AllowUserToResizeRows = false;
            this.dgv_SelectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SelectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_SelectList.Location = new System.Drawing.Point(13, 13);
            this.dgv_SelectList.Name = "dgv_SelectList";
            this.dgv_SelectList.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SelectList.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SelectList.RowHeadersVisible = false;
            this.dgv_SelectList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgv_SelectList.RowTemplate.Height = 36;
            this.dgv_SelectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SelectList.Size = new System.Drawing.Size(615, 351);
            this.dgv_SelectList.TabIndex = 2;
            this.dgv_SelectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectList_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "名稱";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FormSelect
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.dgv_SelectList);
            this.Controls.Add(this.lbl_Selected);
            this.Controls.Add(this.btn_Confirm);
            this.Name = "FormSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "選擇";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Car_Fun.myButton btn_Confirm;
        private System.Windows.Forms.Label lbl_Selected;
        private System.Windows.Forms.DataGridView dgv_SelectList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
