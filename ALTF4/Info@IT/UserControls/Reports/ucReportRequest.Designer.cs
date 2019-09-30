namespace Info_IT.UserControls.Reports
{
	partial class ucReportRequest
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvRequestReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRemoveFilter = new System.Windows.Forms.Button();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbTime = new System.Windows.Forms.ComboBox();
			this.cmbAssignedStaffCode = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dateRequest = new System.Windows.Forms.DateTimePicker();
			this.cmbTaskTypeCode = new System.Windows.Forms.ComboBox();
			this.cmbStudentCode = new System.Windows.Forms.ComboBox();
			this.cmbStaffCode = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRequestReport)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvRequestReport);
			this.panel3.Location = new System.Drawing.Point(32, 145);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 389);
			this.panel3.TabIndex = 23;
			// 
			// dgvRequestReport
			// 
			this.dgvRequestReport.AllowUserToAddRows = false;
			this.dgvRequestReport.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvRequestReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvRequestReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRequestReport.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvRequestReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvRequestReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRequestReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRequestReport.ColumnHeadersHeight = 50;
			this.dgvRequestReport.DoubleBuffered = true;
			this.dgvRequestReport.EnableHeadersVisualStyles = false;
			this.dgvRequestReport.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvRequestReport.HeaderForeColor = System.Drawing.Color.White;
			this.dgvRequestReport.Location = new System.Drawing.Point(0, 0);
			this.dgvRequestReport.Name = "dgvRequestReport";
			this.dgvRequestReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvRequestReport.Size = new System.Drawing.Size(782, 389);
			this.dgvRequestReport.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnRemoveFilter);
			this.groupBox1.Controls.Add(this.cmbStatus);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbTime);
			this.groupBox1.Controls.Add(this.cmbAssignedStaffCode);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.dateRequest);
			this.groupBox1.Controls.Add(this.cmbTaskTypeCode);
			this.groupBox1.Controls.Add(this.cmbStudentCode);
			this.groupBox1.Controls.Add(this.cmbStaffCode);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(32, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(782, 111);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter By";
			// 
			// btnRemoveFilter
			// 
			this.btnRemoveFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveFilter.ForeColor = System.Drawing.Color.White;
			this.btnRemoveFilter.Location = new System.Drawing.Point(685, 73);
			this.btnRemoveFilter.Name = "btnRemoveFilter";
			this.btnRemoveFilter.Size = new System.Drawing.Size(91, 23);
			this.btnRemoveFilter.TabIndex = 28;
			this.btnRemoveFilter.Text = "Remove Filter";
			this.btnRemoveFilter.UseVisualStyleBackColor = false;
			this.btnRemoveFilter.Click += new System.EventHandler(this.BtnRemoveFilter_Click);
			// 
			// cmbStatus
			// 
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed",
            "Cancelled"});
			this.cmbStatus.Location = new System.Drawing.Point(15, 73);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(116, 23);
			this.cmbStatus.TabIndex = 27;
			this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(12, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Status:";
			// 
			// cmbTime
			// 
			this.cmbTime.FormattingEnabled = true;
			this.cmbTime.Items.AddRange(new object[] {
            "08:00:00",
            "08:30:00",
            "09:00:00",
            "09:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00"});
			this.cmbTime.Location = new System.Drawing.Point(531, 32);
			this.cmbTime.Name = "cmbTime";
			this.cmbTime.Size = new System.Drawing.Size(90, 23);
			this.cmbTime.TabIndex = 25;
			this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
			// 
			// cmbAssignedStaffCode
			// 
			this.cmbAssignedStaffCode.FormattingEnabled = true;
			this.cmbAssignedStaffCode.Location = new System.Drawing.Point(627, 32);
			this.cmbAssignedStaffCode.Name = "cmbAssignedStaffCode";
			this.cmbAssignedStaffCode.Size = new System.Drawing.Size(149, 23);
			this.cmbAssignedStaffCode.TabIndex = 21;
			this.cmbAssignedStaffCode.SelectedIndexChanged += new System.EventHandler(this.cmbAssignedStaffCode_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label8.Location = new System.Drawing.Point(624, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 17);
			this.label8.TabIndex = 20;
			this.label8.Text = "Assigned Staff:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label7.Location = new System.Drawing.Point(528, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Time:";
			// 
			// dateRequest
			// 
			this.dateRequest.CustomFormat = "dd MMMM yyyy";
			this.dateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateRequest.Location = new System.Drawing.Point(381, 32);
			this.dateRequest.Name = "dateRequest";
			this.dateRequest.Size = new System.Drawing.Size(144, 23);
			this.dateRequest.TabIndex = 16;
			this.dateRequest.ValueChanged += new System.EventHandler(this.dateRequest_ValueChanged);
			// 
			// cmbTaskTypeCode
			// 
			this.cmbTaskTypeCode.FormattingEnabled = true;
			this.cmbTaskTypeCode.Location = new System.Drawing.Point(259, 31);
			this.cmbTaskTypeCode.Name = "cmbTaskTypeCode";
			this.cmbTaskTypeCode.Size = new System.Drawing.Size(116, 23);
			this.cmbTaskTypeCode.TabIndex = 15;
			this.cmbTaskTypeCode.SelectedIndexChanged += new System.EventHandler(this.cmbTaskTypeCode_SelectedIndexChanged);
			// 
			// cmbStudentCode
			// 
			this.cmbStudentCode.FormattingEnabled = true;
			this.cmbStudentCode.Location = new System.Drawing.Point(137, 31);
			this.cmbStudentCode.Name = "cmbStudentCode";
			this.cmbStudentCode.Size = new System.Drawing.Size(116, 23);
			this.cmbStudentCode.TabIndex = 14;
			this.cmbStudentCode.SelectedIndexChanged += new System.EventHandler(this.cmbStudentCode_SelectedIndexChanged);
			// 
			// cmbStaffCode
			// 
			this.cmbStaffCode.FormattingEnabled = true;
			this.cmbStaffCode.Location = new System.Drawing.Point(15, 31);
			this.cmbStaffCode.Name = "cmbStaffCode";
			this.cmbStaffCode.Size = new System.Drawing.Size(116, 23);
			this.cmbStaffCode.TabIndex = 7;
			this.cmbStaffCode.SelectedIndexChanged += new System.EventHandler(this.cmbStaffCode_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label6.Location = new System.Drawing.Point(381, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Date:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label5.Location = new System.Drawing.Point(134, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Student:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label4.Location = new System.Drawing.Point(256, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Task Type:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label3.Location = new System.Drawing.Point(12, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Staff:";
			// 
			// ucReportRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel3);
			this.Name = "ucReportRequest";
			this.Size = new System.Drawing.Size(856, 562);
			this.Load += new System.EventHandler(this.UcReportRequest_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvRequestReport)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRequestReport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbTime;
		private System.Windows.Forms.ComboBox cmbAssignedStaffCode;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateRequest;
		private System.Windows.Forms.ComboBox cmbTaskTypeCode;
		private System.Windows.Forms.ComboBox cmbStudentCode;
		private System.Windows.Forms.ComboBox cmbStaffCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRemoveFilter;
	}
}
