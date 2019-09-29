namespace Info_IT.UserControls.Reports
{
	partial class ucReportInspection
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
			this.dgvInspectionReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbStaffCode = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbVenueCode = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateInspection = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInspectionReport)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvInspectionReport);
			this.panel3.Location = new System.Drawing.Point(32, 105);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 429);
			this.panel3.TabIndex = 27;
			// 
			// dgvInspectionReport
			// 
			this.dgvInspectionReport.AllowUserToAddRows = false;
			this.dgvInspectionReport.AllowUserToDeleteRows = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvInspectionReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvInspectionReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvInspectionReport.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvInspectionReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvInspectionReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvInspectionReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvInspectionReport.ColumnHeadersHeight = 50;
			this.dgvInspectionReport.DoubleBuffered = true;
			this.dgvInspectionReport.EnableHeadersVisualStyles = false;
			this.dgvInspectionReport.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvInspectionReport.HeaderForeColor = System.Drawing.Color.White;
			this.dgvInspectionReport.Location = new System.Drawing.Point(0, 0);
			this.dgvInspectionReport.Name = "dgvInspectionReport";
			this.dgvInspectionReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvInspectionReport.Size = new System.Drawing.Size(782, 429);
			this.dgvInspectionReport.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbStaffCode);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbVenueCode);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dateInspection);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(32, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(782, 71);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter By";
			// 
			// cmbStaffCode
			// 
			this.cmbStaffCode.FormattingEnabled = true;
			this.cmbStaffCode.Location = new System.Drawing.Point(289, 33);
			this.cmbStaffCode.Name = "cmbStaffCode";
			this.cmbStaffCode.Size = new System.Drawing.Size(116, 23);
			this.cmbStaffCode.TabIndex = 35;
			this.cmbStaffCode.SelectedIndexChanged += new System.EventHandler(this.cmbStaffCode_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label4.Location = new System.Drawing.Point(289, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 17);
			this.label4.TabIndex = 34;
			this.label4.Text = "Staff:";
			// 
			// cmbVenueCode
			// 
			this.cmbVenueCode.FormattingEnabled = true;
			this.cmbVenueCode.Location = new System.Drawing.Point(167, 33);
			this.cmbVenueCode.Name = "cmbVenueCode";
			this.cmbVenueCode.Size = new System.Drawing.Size(116, 23);
			this.cmbVenueCode.TabIndex = 33;
			this.cmbVenueCode.SelectedIndexChanged += new System.EventHandler(this.cmbVenueCode_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label5.Location = new System.Drawing.Point(164, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 17);
			this.label5.TabIndex = 32;
			this.label5.Text = "Venue:";
			// 
			// dateInspection
			// 
			this.dateInspection.CustomFormat = "dd MMMM yyyy";
			this.dateInspection.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateInspection.Location = new System.Drawing.Point(17, 33);
			this.dateInspection.Name = "dateInspection";
			this.dateInspection.Size = new System.Drawing.Size(144, 23);
			this.dateInspection.TabIndex = 31;
			this.dateInspection.ValueChanged += new System.EventHandler(this.dateInspection_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(14, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 30;
			this.label1.Text = "Date:";
			// 
			// ucReportInspection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.Name = "ucReportInspection";
			this.Size = new System.Drawing.Size(856, 562);
			this.Load += new System.EventHandler(this.UcReportInspection_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvInspectionReport)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInspectionReport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbStaffCode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbVenueCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateInspection;
		private System.Windows.Forms.Label label1;
	}
}
