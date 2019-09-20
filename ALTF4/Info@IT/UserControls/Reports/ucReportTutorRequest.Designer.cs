﻿namespace Info_IT.UserControls.Reports
{
	partial class ucReportTutorRequest
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvTutorRequestReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbEndTime = new System.Windows.Forms.ComboBox();
			this.cmbStartTime = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbRequestCode = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateRequest = new System.Windows.Forms.DateTimePicker();
			this.cmbVenueCode = new System.Windows.Forms.ComboBox();
			this.cmbModuleCode = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTutorRequestReport)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvTutorRequestReport);
			this.panel3.Location = new System.Drawing.Point(32, 105);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 429);
			this.panel3.TabIndex = 25;
			// 
			// dgvTutorRequestReport
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvTutorRequestReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTutorRequestReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTutorRequestReport.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvTutorRequestReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTutorRequestReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTutorRequestReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvTutorRequestReport.ColumnHeadersHeight = 50;
			this.dgvTutorRequestReport.DoubleBuffered = true;
			this.dgvTutorRequestReport.EnableHeadersVisualStyles = false;
			this.dgvTutorRequestReport.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvTutorRequestReport.HeaderForeColor = System.Drawing.Color.White;
			this.dgvTutorRequestReport.Location = new System.Drawing.Point(0, 0);
			this.dgvTutorRequestReport.Name = "dgvTutorRequestReport";
			this.dgvTutorRequestReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvTutorRequestReport.Size = new System.Drawing.Size(782, 429);
			this.dgvTutorRequestReport.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbEndTime);
			this.groupBox1.Controls.Add(this.cmbStartTime);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbRequestCode);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.dateRequest);
			this.groupBox1.Controls.Add(this.cmbVenueCode);
			this.groupBox1.Controls.Add(this.cmbModuleCode);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(32, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(782, 71);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter By";
			// 
			// cmbEndTime
			// 
			this.cmbEndTime.FormattingEnabled = true;
			this.cmbEndTime.Items.AddRange(new object[] {
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00"});
			this.cmbEndTime.Location = new System.Drawing.Point(651, 32);
			this.cmbEndTime.Name = "cmbEndTime";
			this.cmbEndTime.Size = new System.Drawing.Size(121, 23);
			this.cmbEndTime.TabIndex = 37;
			// 
			// cmbStartTime
			// 
			this.cmbStartTime.FormattingEnabled = true;
			this.cmbStartTime.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
			this.cmbStartTime.Location = new System.Drawing.Point(529, 32);
			this.cmbStartTime.Name = "cmbStartTime";
			this.cmbStartTime.Size = new System.Drawing.Size(116, 23);
			this.cmbStartTime.TabIndex = 36;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label4.Location = new System.Drawing.Point(526, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 35;
			this.label4.Text = "Start Time:";
			// 
			// cmbRequestCode
			// 
			this.cmbRequestCode.FormattingEnabled = true;
			this.cmbRequestCode.Location = new System.Drawing.Point(13, 32);
			this.cmbRequestCode.Name = "cmbRequestCode";
			this.cmbRequestCode.Size = new System.Drawing.Size(116, 23);
			this.cmbRequestCode.TabIndex = 34;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label7.Location = new System.Drawing.Point(651, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 17);
			this.label7.TabIndex = 33;
			this.label7.Text = "End Time:";
			// 
			// dateRequest
			// 
			this.dateRequest.CustomFormat = "dd MMMM yyyy";
			this.dateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateRequest.Location = new System.Drawing.Point(135, 32);
			this.dateRequest.Name = "dateRequest";
			this.dateRequest.Size = new System.Drawing.Size(144, 23);
			this.dateRequest.TabIndex = 32;
			// 
			// cmbVenueCode
			// 
			this.cmbVenueCode.FormattingEnabled = true;
			this.cmbVenueCode.Location = new System.Drawing.Point(407, 32);
			this.cmbVenueCode.Name = "cmbVenueCode";
			this.cmbVenueCode.Size = new System.Drawing.Size(116, 23);
			this.cmbVenueCode.TabIndex = 31;
			// 
			// cmbModuleCode
			// 
			this.cmbModuleCode.FormattingEnabled = true;
			this.cmbModuleCode.Location = new System.Drawing.Point(285, 32);
			this.cmbModuleCode.Name = "cmbModuleCode";
			this.cmbModuleCode.Size = new System.Drawing.Size(116, 23);
			this.cmbModuleCode.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label6.Location = new System.Drawing.Point(135, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 17);
			this.label6.TabIndex = 30;
			this.label6.Text = "Date:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label5.Location = new System.Drawing.Point(404, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 17);
			this.label5.TabIndex = 29;
			this.label5.Text = "Venue Code:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label3.Location = new System.Drawing.Point(282, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 27;
			this.label3.Text = "Module Code:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Request Code:";
			// 
			// ucReportTutorRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.Name = "ucReportTutorRequest";
			this.Size = new System.Drawing.Size(856, 562);
			this.Load += new System.EventHandler(this.UcReportTutorRequest_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTutorRequestReport)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTutorRequestReport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbEndTime;
		private System.Windows.Forms.ComboBox cmbStartTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbRequestCode;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateRequest;
		private System.Windows.Forms.ComboBox cmbVenueCode;
		private System.Windows.Forms.ComboBox cmbModuleCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}
