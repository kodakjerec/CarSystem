namespace CarSystem
{
    partial class Form6_1_MultiMerdid
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_CrePage = new System.Windows.Forms.DataGridView();
            this.S_slom_merdid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_merl_expdate_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_merl_sbuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L_slom_1qty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_merp_1qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_ResultMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CrePage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CrePage
            // 
            this.dataGridView_CrePage.AllowUserToAddRows = false;
            this.dataGridView_CrePage.AllowUserToDeleteRows = false;
            this.dataGridView_CrePage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CrePage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_CrePage.ColumnHeadersHeight = 41;
            this.dataGridView_CrePage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_slom_merdid2,
            this.D_merl_expdate_Out,
            this.S_merl_sbuid,
            this.L_slom_1qty2,
            this.I_merp_1qty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_CrePage.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_CrePage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_CrePage.Location = new System.Drawing.Point(0, 104);
            this.dataGridView_CrePage.Name = "dataGridView_CrePage";
            this.dataGridView_CrePage.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CrePage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_CrePage.RowHeadersVisible = false;
            this.dataGridView_CrePage.RowHeadersWidth = 60;
            this.dataGridView_CrePage.RowTemplate.Height = 80;
            this.dataGridView_CrePage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CrePage.Size = new System.Drawing.Size(1036, 537);
            this.dataGridView_CrePage.TabIndex = 9;
            this.dataGridView_CrePage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CrePage_CellClick);
            // 
            // S_slom_merdid2
            // 
            this.S_slom_merdid2.DataPropertyName = "S_meti_merdid";
            this.S_slom_merdid2.HeaderText = "貨號";
            this.S_slom_merdid2.Name = "S_slom_merdid2";
            this.S_slom_merdid2.ReadOnly = true;
            // 
            // D_merl_expdate_Out
            // 
            this.D_merl_expdate_Out.DataPropertyName = "D_meti_newexpdate";
            this.D_merl_expdate_Out.HeaderText = "效期";
            this.D_merl_expdate_Out.Name = "D_merl_expdate_Out";
            this.D_merl_expdate_Out.ReadOnly = true;
            // 
            // S_merl_sbuid
            // 
            this.S_merl_sbuid.DataPropertyName = "S_merl_sbuid";
            this.S_merl_sbuid.HeaderText = "事業單位";
            this.S_merl_sbuid.Name = "S_merl_sbuid";
            this.S_merl_sbuid.ReadOnly = true;
            // 
            // L_slom_1qty2
            // 
            this.L_slom_1qty2.DataPropertyName = "L_meti_adjqty";
            this.L_slom_1qty2.HeaderText = "庫存量";
            this.L_slom_1qty2.Name = "L_slom_1qty2";
            this.L_slom_1qty2.ReadOnly = true;
            // 
            // I_merp_1qty
            // 
            this.I_merp_1qty.DataPropertyName = "L_meti_adjqty_box";
            this.I_merp_1qty.HeaderText = "箱數";
            this.I_merp_1qty.Name = "I_merp_1qty";
            this.I_merp_1qty.ReadOnly = true;
            // 
            // lb_ResultMsg
            // 
            this.lb_ResultMsg.AutoSize = true;
            this.lb_ResultMsg.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_ResultMsg.ForeColor = System.Drawing.Color.Red;
            this.lb_ResultMsg.Location = new System.Drawing.Point(392, 23);
            this.lb_ResultMsg.MaximumSize = new System.Drawing.Size(800, 0);
            this.lb_ResultMsg.Name = "lb_ResultMsg";
            this.lb_ResultMsg.Size = new System.Drawing.Size(596, 48);
            this.lb_ResultMsg.TabIndex = 18;
            this.lb_ResultMsg.Text = "請選擇正確效期與事業單位";
            // 
            // Form6_1_MultiMerdid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1036, 724);
            this.Controls.Add(this.lb_ResultMsg);
            this.Controls.Add(this.dataGridView_CrePage);
            this.Name = "Form6_1_MultiMerdid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form6_1_MultiMerdid_Load);
            this.Controls.SetChildIndex(this.dataGridView_CrePage, 0);
            this.Controls.SetChildIndex(this.lb_ResultMsg, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CrePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_CrePage;
        private System.Windows.Forms.Label lb_ResultMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_slom_merdid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_merl_expdate_Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_merl_sbuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_slom_1qty2;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_merp_1qty;
    }
}
