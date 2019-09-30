namespace Info_IT.UserControls.Reports
{
	partial class ucReportVenue
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
			this.dgvVenueReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRemoveFilter = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbBuildingBlock = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbBuilding = new System.Windows.Forms.ComboBox();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVenueReport)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvVenueReport);
			this.panel3.Location = new System.Drawing.Point(32, 105);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 429);
			this.panel3.TabIndex = 20;
			// 
			// dgvVenueReport
			// 
			this.dgvVenueReport.AllowUserToAddRows = false;
			this.dgvVenueReport.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvVenueReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvVenueReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVenueReport.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvVenueReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVenueReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvVenueReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvVenueReport.ColumnHeadersHeight = 50;
			this.dgvVenueReport.DoubleBuffered = true;
			this.dgvVenueReport.EnableHeadersVisualStyles = false;
			this.dgvVenueReport.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvVenueReport.HeaderForeColor = System.Drawing.Color.White;
			this.dgvVenueReport.Location = new System.Drawing.Point(0, 0);
			this.dgvVenueReport.Name = "dgvVenueReport";
			this.dgvVenueReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvVenueReport.Size = new System.Drawing.Size(782, 429);
			this.dgvVenueReport.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnRemoveFilter);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cmbBuildingBlock);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbBuilding);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(32, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(782, 71);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter By";
			// 
			// btnRemoveFilter
			// 
			this.btnRemoveFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnRemoveFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveFilter.ForeColor = System.Drawing.Color.White;
			this.btnRemoveFilter.Location = new System.Drawing.Point(685, 35);
			this.btnRemoveFilter.Name = "btnRemoveFilter";
			this.btnRemoveFilter.Size = new System.Drawing.Size(91, 23);
			this.btnRemoveFilter.TabIndex = 12;
			this.btnRemoveFilter.Text = "Remove Filter";
			this.btnRemoveFilter.UseVisualStyleBackColor = false;
			this.btnRemoveFilter.Click += new System.EventHandler(this.BtnRemoveFilter_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label6.Location = new System.Drawing.Point(161, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Building:";
			// 
			// cmbBuildingBlock
			// 
			this.cmbBuildingBlock.FormattingEnabled = true;
			this.cmbBuildingBlock.Location = new System.Drawing.Point(14, 35);
			this.cmbBuildingBlock.Name = "cmbBuildingBlock";
			this.cmbBuildingBlock.Size = new System.Drawing.Size(144, 23);
			this.cmbBuildingBlock.TabIndex = 10;
			this.cmbBuildingBlock.SelectionChangeCommitted += new System.EventHandler(this.cmbBuildingBlock_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label4.Location = new System.Drawing.Point(11, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Building Block:";
			// 
			// cmbBuilding
			// 
			this.cmbBuilding.FormattingEnabled = true;
			this.cmbBuilding.Location = new System.Drawing.Point(164, 35);
			this.cmbBuilding.Name = "cmbBuilding";
			this.cmbBuilding.Size = new System.Drawing.Size(144, 23);
			this.cmbBuilding.TabIndex = 4;
			this.cmbBuilding.SelectionChangeCommitted += new System.EventHandler(this.cmbBuildingBlock_SelectedIndexChanged);
			// 
			// ucReportVenue
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel3);
			this.Name = "ucReportVenue";
			this.Size = new System.Drawing.Size(856, 562);
			this.Load += new System.EventHandler(this.UcReportVenue_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVenueReport)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvVenueReport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbBuildingBlock;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbBuilding;
		private System.Windows.Forms.Button btnRemoveFilter;
	}
}
