namespace Info_IT.UserControls
{
	partial class ucReportStudent
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
			this.dgvStudentReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentReport)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvStudentReport);
			this.panel3.Location = new System.Drawing.Point(32, 35);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 499);
			this.panel3.TabIndex = 30;
			// 
			// dgvStudentReport
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvStudentReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStudentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudentReport.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvStudentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvStudentReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStudentReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStudentReport.ColumnHeadersHeight = 50;
			this.dgvStudentReport.DoubleBuffered = true;
			this.dgvStudentReport.EnableHeadersVisualStyles = false;
			this.dgvStudentReport.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvStudentReport.HeaderForeColor = System.Drawing.Color.White;
			this.dgvStudentReport.Location = new System.Drawing.Point(0, 0);
			this.dgvStudentReport.Name = "dgvStudentReport";
			this.dgvStudentReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvStudentReport.Size = new System.Drawing.Size(782, 499);
			this.dgvStudentReport.TabIndex = 0;
			// 
			// ucReportStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Name = "ucReportStudent";
			this.Size = new System.Drawing.Size(856, 562);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentReport)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvStudentReport;
	}
}
