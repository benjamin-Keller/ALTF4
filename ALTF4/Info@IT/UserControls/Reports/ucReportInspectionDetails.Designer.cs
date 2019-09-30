namespace Info_IT.UserControls.Reports
{
	partial class ucReportInspectionDetails
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
            this.dgvInspectionReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVenue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEquipmentCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInspectionCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStaffCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectionReport)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvInspectionReport);
            this.panel3.Location = new System.Drawing.Point(32, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 429);
            this.panel3.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveFilter);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbVenue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEquipmentCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbInspectionCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbStaffCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 71);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By";
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFilter.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFilter.Location = new System.Drawing.Point(687, 36);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveFilter.TabIndex = 40;
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
            this.cmbStatus.Location = new System.Drawing.Point(503, 36);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(116, 23);
            this.cmbStatus.TabIndex = 39;
            this.cmbStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(503, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Status:";
            // 
            // cmbVenue
            // 
            this.cmbVenue.FormattingEnabled = true;
            this.cmbVenue.Items.AddRange(new object[] {
            "Pending",
            "In-Progress",
            "Completed",
            "Cancelled"});
            this.cmbVenue.Location = new System.Drawing.Point(381, 36);
            this.cmbVenue.Name = "cmbVenue";
            this.cmbVenue.Size = new System.Drawing.Size(116, 23);
            this.cmbVenue.TabIndex = 37;
            this.cmbVenue.SelectionChangeCommitted += new System.EventHandler(this.cmbVenue_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(381, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Venue:";
            // 
            // cmbEquipmentCode
            // 
            this.cmbEquipmentCode.FormattingEnabled = true;
            this.cmbEquipmentCode.Location = new System.Drawing.Point(137, 36);
            this.cmbEquipmentCode.Name = "cmbEquipmentCode";
            this.cmbEquipmentCode.Size = new System.Drawing.Size(116, 23);
            this.cmbEquipmentCode.TabIndex = 35;
            this.cmbEquipmentCode.SelectionChangeCommitted += new System.EventHandler(this.cmbEquipmentCode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(134, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Equipment:";
            // 
            // cmbInspectionCode
            // 
            this.cmbInspectionCode.FormattingEnabled = true;
            this.cmbInspectionCode.Location = new System.Drawing.Point(15, 36);
            this.cmbInspectionCode.Name = "cmbInspectionCode";
            this.cmbInspectionCode.Size = new System.Drawing.Size(116, 23);
            this.cmbInspectionCode.TabIndex = 33;
            this.cmbInspectionCode.SelectionChangeCommitted += new System.EventHandler(this.cmbInspectionCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Inspection Code:";
            // 
            // cmbStaffCode
            // 
            this.cmbStaffCode.FormattingEnabled = true;
            this.cmbStaffCode.Location = new System.Drawing.Point(259, 36);
            this.cmbStaffCode.Name = "cmbStaffCode";
            this.cmbStaffCode.Size = new System.Drawing.Size(116, 23);
            this.cmbStaffCode.TabIndex = 29;
            this.cmbStaffCode.SelectionChangeCommitted += new System.EventHandler(this.cmbStaffCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(259, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Staff Member:";
            // 
            // ucReportInspectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "ucReportInspectionDetails";
            this.Size = new System.Drawing.Size(856, 562);
            this.Load += new System.EventHandler(this.UcReportInspectionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectionReport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInspectionReport;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbVenue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbEquipmentCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbInspectionCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbStaffCode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnRemoveFilter;
	}
}
