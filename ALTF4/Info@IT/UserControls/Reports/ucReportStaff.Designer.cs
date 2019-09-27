namespace Info_IT.UserControls
{
	partial class ucReportStaff
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
			this.dgvStaffReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbDepartmentCode = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbStaffType = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStaffReport)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvStaffReport);
			this.panel3.Location = new System.Drawing.Point(32, 105);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 429);
			this.panel3.TabIndex = 29;
			// 
			// dgvStaffReport
			// 
			this.dgvStaffReport.AllowUserToAddRows = false;
			this.dgvStaffReport.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvStaffReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStaffReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStaffReport.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvStaffReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvStaffReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStaffReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStaffReport.ColumnHeadersHeight = 50;
			this.dgvStaffReport.DoubleBuffered = true;
			this.dgvStaffReport.EnableHeadersVisualStyles = false;
			this.dgvStaffReport.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvStaffReport.HeaderForeColor = System.Drawing.Color.White;
			this.dgvStaffReport.Location = new System.Drawing.Point(0, 0);
			this.dgvStaffReport.Name = "dgvStaffReport";
			this.dgvStaffReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvStaffReport.Size = new System.Drawing.Size(782, 429);
			this.dgvStaffReport.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbDepartmentCode);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cmbStaffType);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(32, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(782, 71);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter By";
			// 
			// cmbDepartmentCode
			// 
			this.cmbDepartmentCode.FormattingEnabled = true;
			this.cmbDepartmentCode.Location = new System.Drawing.Point(149, 35);
			this.cmbDepartmentCode.Name = "cmbDepartmentCode";
			this.cmbDepartmentCode.Size = new System.Drawing.Size(126, 23);
			this.cmbDepartmentCode.TabIndex = 49;
			this.cmbDepartmentCode.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmentCode_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label7.Location = new System.Drawing.Point(146, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 17);
			this.label7.TabIndex = 48;
			this.label7.Text = "Department Code:";
			// 
			// cmbStaffType
			// 
			this.cmbStaffType.FormattingEnabled = true;
			this.cmbStaffType.Items.AddRange(new object[] {
            "Info@IT",
            "Student Assistant",
            "ICT HelpDesk"});
			this.cmbStaffType.Location = new System.Drawing.Point(17, 35);
			this.cmbStaffType.Name = "cmbStaffType";
			this.cmbStaffType.Size = new System.Drawing.Size(126, 23);
			this.cmbStaffType.TabIndex = 47;
			this.cmbStaffType.SelectedIndexChanged += new System.EventHandler(this.cmbStaffType_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label6.Location = new System.Drawing.Point(14, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 17);
			this.label6.TabIndex = 46;
			this.label6.Text = "Staff Type:";
			// 
			// ucReportStaff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.Name = "ucReportStaff";
			this.Size = new System.Drawing.Size(856, 562);
			this.Load += new System.EventHandler(this.UcReportStaff_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStaffReport)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvStaffReport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbDepartmentCode;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbStaffType;
		private System.Windows.Forms.Label label6;
	}
}
