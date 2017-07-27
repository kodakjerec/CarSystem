namespace CarSystem
{
    partial class Form9_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Seltype_Cute = new System.Windows.Forms.Button();
            this.btn_Seltype_Normal = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_OperateSUM = new System.Windows.Forms.TabPage();
            this.dgv_LogSUM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbp_OperateLog = new System.Windows.Forms.TabPage();
            this.dgv_Log = new System.Windows.Forms.DataGridView();
            this.colComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSysno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSB_SelectWorkArea_Out = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Bdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Edate = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new Car_Fun.myButton();
            this.myButton1 = new Car_Fun.myButton();
            this.myButton2 = new Car_Fun.myButton();
            this.tabControl1.SuspendLayout();
            this.tbp_OperateSUM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogSUM)).BeginInit();
            this.tbp_OperateLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tbp_OperateSUM);
            this.tabControl1.Controls.Add(this.tbp_OperateLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 60);
            this.tabControl1.Location = new System.Drawing.Point(0, 192);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 459);
            this.tabControl1.TabIndex = 67;
            // 
            // tbp_OperateSUM
            // 
            this.tbp_OperateSUM.Controls.Add(this.dgv_LogSUM);
            this.tbp_OperateSUM.Location = new System.Drawing.Point(4, 64);
            this.tbp_OperateSUM.Name = "tbp_OperateSUM";
            this.tbp_OperateSUM.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_OperateSUM.Size = new System.Drawing.Size(1008, 495);
            this.tbp_OperateSUM.TabIndex = 0;
            this.tbp_OperateSUM.Text = "總和";
            this.tbp_OperateSUM.UseVisualStyleBackColor = true;
            // 
            // dgv_LogSUM
            // 
            this.dgv_LogSUM.AllowUserToAddRows = false;
            this.dgv_LogSUM.AllowUserToDeleteRows = false;
            this.dgv_LogSUM.AllowUserToResizeRows = false;
            this.dgv_LogSUM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LogSUM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_LogSUM.ColumnHeadersHeight = 41;
            this.dgv_LogSUM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_LogSUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LogSUM.Location = new System.Drawing.Point(3, 3);
            this.dgv_LogSUM.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_LogSUM.MultiSelect = false;
            this.dgv_LogSUM.Name = "dgv_LogSUM";
            this.dgv_LogSUM.ReadOnly = true;
            this.dgv_LogSUM.RowHeadersVisible = false;
            this.dgv_LogSUM.RowHeadersWidth = 60;
            this.dgv_LogSUM.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("細明體", 24F);
            this.dgv_LogSUM.RowTemplate.Height = 24;
            this.dgv_LogSUM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_LogSUM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LogSUM.Size = new System.Drawing.Size(1002, 489);
            this.dgv_LogSUM.TabIndex = 68;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Project";
            this.dataGridViewTextBoxColumn2.HeaderText = "作業類別";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn4.HeaderText = "名稱";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tcount";
            this.dataGridViewTextBoxColumn5.HeaderText = "操作次數";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tbp_OperateLog
            // 
            this.tbp_OperateLog.Controls.Add(this.dgv_Log);
            this.tbp_OperateLog.Controls.Add(this.vSB_SelectWorkArea_Out);
            this.tbp_OperateLog.Location = new System.Drawing.Point(4, 64);
            this.tbp_OperateLog.Name = "tbp_OperateLog";
            this.tbp_OperateLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_OperateLog.Size = new System.Drawing.Size(1008, 391);
            this.tbp_OperateLog.TabIndex = 1;
            this.tbp_OperateLog.Text = "操作紀錄";
            this.tbp_OperateLog.UseVisualStyleBackColor = true;
            // 
            // dgv_Log
            // 
            this.dgv_Log.AllowUserToAddRows = false;
            this.dgv_Log.AllowUserToDeleteRows = false;
            this.dgv_Log.AllowUserToResizeRows = false;
            this.dgv_Log.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Log.ColumnHeadersHeight = 41;
            this.dgv_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colComputerName,
            this.colProject,
            this.colStartTime,
            this.colActionName,
            this.colSysno});
            this.dgv_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Log.Location = new System.Drawing.Point(3, 3);
            this.dgv_Log.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_Log.MultiSelect = false;
            this.dgv_Log.Name = "dgv_Log";
            this.dgv_Log.ReadOnly = true;
            this.dgv_Log.RowHeadersVisible = false;
            this.dgv_Log.RowHeadersWidth = 60;
            this.dgv_Log.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("細明體", 16F);
            this.dgv_Log.RowTemplate.Height = 24;
            this.dgv_Log.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Log.Size = new System.Drawing.Size(932, 385);
            this.dgv_Log.TabIndex = 67;
            // 
            // colComputerName
            // 
            this.colComputerName.DataPropertyName = "ComputerName";
            this.colComputerName.HeaderText = "使用主機";
            this.colComputerName.Name = "colComputerName";
            this.colComputerName.ReadOnly = true;
            this.colComputerName.Width = 188;
            // 
            // colProject
            // 
            this.colProject.DataPropertyName = "Project";
            this.colProject.HeaderText = "作業類別";
            this.colProject.Name = "colProject";
            this.colProject.ReadOnly = true;
            this.colProject.Width = 188;
            // 
            // colStartTime
            // 
            this.colStartTime.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Format = "yyyy/MM/dd HH:mm:ss.fff";
            dataGridViewCellStyle2.NullValue = null;
            this.colStartTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.colStartTime.HeaderText = "時間";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            this.colStartTime.Width = 270;
            // 
            // colActionName
            // 
            this.colActionName.DataPropertyName = "ActionName";
            this.colActionName.HeaderText = "行為";
            this.colActionName.Name = "colActionName";
            this.colActionName.ReadOnly = true;
            this.colActionName.Width = 188;
            // 
            // colSysno
            // 
            this.colSysno.DataPropertyName = "Sysno";
            this.colSysno.HeaderText = "相關資料";
            this.colSysno.Name = "colSysno";
            this.colSysno.ReadOnly = true;
            this.colSysno.Width = 188;
            // 
            // vSB_SelectWorkArea_Out
            // 
            this.vSB_SelectWorkArea_Out.Dock = System.Windows.Forms.DockStyle.Right;
            this.vSB_SelectWorkArea_Out.Location = new System.Drawing.Point(935, 3);
            this.vSB_SelectWorkArea_Out.Name = "vSB_SelectWorkArea_Out";
            this.vSB_SelectWorkArea_Out.Size = new System.Drawing.Size(70, 385);
            this.vSB_SelectWorkArea_Out.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 68;
            this.label1.Text = "日期";
            // 
            // dtp_Bdate
            // 
            this.dtp_Bdate.CustomFormat = "yyyy-MM-dd";
            this.dtp_Bdate.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_Bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Bdate.Location = new System.Drawing.Point(134, 9);
            this.dtp_Bdate.Name = "dtp_Bdate";
            this.dtp_Bdate.Size = new System.Drawing.Size(257, 65);
            this.dtp_Bdate.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(404, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 48);
            this.label2.TabIndex = 70;
            this.label2.Text = "至";
            // 
            // dtp_Edate
            // 
            this.dtp_Edate.CustomFormat = "yyyy-MM-dd";
            this.dtp_Edate.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_Edate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Edate.Location = new System.Drawing.Point(484, 9);
            this.dtp_Edate.Name = "dtp_Edate";
            this.dtp_Edate.Size = new System.Drawing.Size(257, 65);
            this.dtp_Edate.TabIndex = 71;
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search.Location = new System.Drawing.Point(747, 8);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(133, 70);
            this.btn_Search.TabIndex = 72;
            this.btn_Search.Text = "查詢";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // myButton1
            // 
            this.myButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton1.Location = new System.Drawing.Point(7, 91);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 73;
            this.myButton1.Text = "總和";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton2
            // 
            this.myButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton2.Location = new System.Drawing.Point(88, 91);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(75, 23);
            this.myButton2.TabIndex = 74;
            this.myButton2.Text = "操作紀錄";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // Form9_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_Edate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_Bdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form9_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtp_Bdate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtp_Edate, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.Controls.SetChildIndex(this.myButton1, 0);
            this.Controls.SetChildIndex(this.myButton2, 0);
            this.tabControl1.ResumeLayout(false);
            this.tbp_OperateSUM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogSUM)).EndInit();
            this.tbp_OperateLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Seltype_Cute;
        private System.Windows.Forms.Button btn_Seltype_Normal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_OperateLog;
        private System.Windows.Forms.DataGridView dgv_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSysno;
        private System.Windows.Forms.VScrollBar vSB_SelectWorkArea_Out;
        private System.Windows.Forms.TabPage tbp_OperateSUM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Bdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Edate;
        private System.Windows.Forms.DataGridView dgv_LogSUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Car_Fun.myButton btn_Search;
        private Car_Fun.myButton myButton1;
        private Car_Fun.myButton myButton2;
    }
}
