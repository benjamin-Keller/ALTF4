namespace Info_IT.UserControls
{
	partial class ucRequest
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
			this.tmrManage = new System.Windows.Forms.Timer(this.components);
			this.btnManageUpdate = new System.Windows.Forms.Button();
			this.btnManageAdd = new System.Windows.Forms.Button();
			this.btnManage = new System.Windows.Forms.Button();
			this.pnlManage = new System.Windows.Forms.Panel();
			this.btnManageDelete = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tmrView = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvRequest = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.pnlManage.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuFormFadeTransition1
			// 
			this.bunifuFormFadeTransition1.Delay = 1;
			// 
			// tmrManage
			// 
			this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
			// 
			// btnManageUpdate
			// 
			this.btnManageUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnManageUpdate.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageUpdate.FlatAppearance.BorderSize = 0;
			this.btnManageUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageUpdate.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnManageUpdate.Location = new System.Drawing.Point(0, 84);
			this.btnManageUpdate.Name = "btnManageUpdate";
			this.btnManageUpdate.Size = new System.Drawing.Size(200, 31);
			this.btnManageUpdate.TabIndex = 7;
			this.btnManageUpdate.Text = "Update Selected Request";
			this.btnManageUpdate.UseVisualStyleBackColor = false;
			this.btnManageUpdate.Click += new System.EventHandler(this.BtnManageUpdate_Click);
			// 
			// btnManageAdd
			// 
			this.btnManageAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnManageAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageAdd.FlatAppearance.BorderSize = 0;
			this.btnManageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageAdd.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnManageAdd.Location = new System.Drawing.Point(0, 53);
			this.btnManageAdd.Name = "btnManageAdd";
			this.btnManageAdd.Size = new System.Drawing.Size(200, 31);
			this.btnManageAdd.TabIndex = 6;
			this.btnManageAdd.Text = "Add Request";
			this.btnManageAdd.UseVisualStyleBackColor = false;
			this.btnManageAdd.Click += new System.EventHandler(this.BtnManageAdd_Click);
			// 
			// btnManage
			// 
			this.btnManage.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManage.FlatAppearance.BorderSize = 0;
			this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnManage.Location = new System.Drawing.Point(0, 0);
			this.btnManage.MinimumSize = new System.Drawing.Size(180, 53);
			this.btnManage.Name = "btnManage";
			this.btnManage.Size = new System.Drawing.Size(200, 53);
			this.btnManage.TabIndex = 5;
			this.btnManage.Text = "Manage";
			this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnManage.UseVisualStyleBackColor = false;
			this.btnManage.Click += new System.EventHandler(this.BtnManage_Click);
			// 
			// pnlManage
			// 
			this.pnlManage.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlManage.Controls.Add(this.btnExportToExcel);
			this.pnlManage.Controls.Add(this.btnManageDelete);
			this.pnlManage.Controls.Add(this.btnManageUpdate);
			this.pnlManage.Controls.Add(this.btnManageAdd);
			this.pnlManage.Controls.Add(this.btnManage);
			this.pnlManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlManage.Location = new System.Drawing.Point(0, 0);
			this.pnlManage.MaximumSize = new System.Drawing.Size(200, 179);
			this.pnlManage.MinimumSize = new System.Drawing.Size(200, 53);
			this.pnlManage.Name = "pnlManage";
			this.pnlManage.Size = new System.Drawing.Size(200, 53);
			this.pnlManage.TabIndex = 12;
			// 
			// btnManageDelete
			// 
			this.btnManageDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnManageDelete.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageDelete.FlatAppearance.BorderSize = 0;
			this.btnManageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageDelete.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnManageDelete.Location = new System.Drawing.Point(0, 115);
			this.btnManageDelete.Name = "btnManageDelete";
			this.btnManageDelete.Size = new System.Drawing.Size(200, 31);
			this.btnManageDelete.TabIndex = 8;
			this.btnManageDelete.Text = "Delete Selected Request";
			this.btnManageDelete.UseVisualStyleBackColor = false;
			this.btnManageDelete.Click += new System.EventHandler(this.BtnManageDelete_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.pnlManage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 562);
			this.panel1.TabIndex = 12;
			// 
			// tmrView
			// 
			this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
			// 
			// groupBox1
			// 
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
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(234, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(782, 110);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// cmbTime
			// 
			this.cmbTime.FormattingEnabled = true;
			this.cmbTime.Items.AddRange(new object[] {
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
			this.cmbTime.Location = new System.Drawing.Point(15, 77);
			this.cmbTime.Name = "cmbTime";
			this.cmbTime.Size = new System.Drawing.Size(116, 23);
			this.cmbTime.TabIndex = 25;
			// 
			// cmbAssignedStaffCode
			// 
			this.cmbAssignedStaffCode.FormattingEnabled = true;
			this.cmbAssignedStaffCode.Location = new System.Drawing.Point(137, 77);
			this.cmbAssignedStaffCode.Name = "cmbAssignedStaffCode";
			this.cmbAssignedStaffCode.Size = new System.Drawing.Size(162, 23);
			this.cmbAssignedStaffCode.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label8.Location = new System.Drawing.Point(134, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 17);
			this.label8.TabIndex = 20;
			this.label8.Text = "Staff (Assigned Staff):";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label7.Location = new System.Drawing.Point(12, 57);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Time:";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// dateRequest
			// 
			this.dateRequest.CustomFormat = "dd MMMM yyyy";
			this.dateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateRequest.Location = new System.Drawing.Point(602, 34);
			this.dateRequest.Name = "dateRequest";
			this.dateRequest.Size = new System.Drawing.Size(144, 23);
			this.dateRequest.TabIndex = 16;
			// 
			// cmbTaskTypeCode
			// 
			this.cmbTaskTypeCode.FormattingEnabled = true;
			this.cmbTaskTypeCode.Location = new System.Drawing.Point(480, 33);
			this.cmbTaskTypeCode.Name = "cmbTaskTypeCode";
			this.cmbTaskTypeCode.Size = new System.Drawing.Size(116, 23);
			this.cmbTaskTypeCode.TabIndex = 15;
			// 
			// cmbStudentCode
			// 
			this.cmbStudentCode.FormattingEnabled = true;
			this.cmbStudentCode.Location = new System.Drawing.Point(358, 33);
			this.cmbStudentCode.Name = "cmbStudentCode";
			this.cmbStudentCode.Size = new System.Drawing.Size(116, 23);
			this.cmbStudentCode.TabIndex = 14;
			// 
			// cmbStaffCode
			// 
			this.cmbStaffCode.FormattingEnabled = true;
			this.cmbStaffCode.Location = new System.Drawing.Point(236, 33);
			this.cmbStaffCode.Name = "cmbStaffCode";
			this.cmbStaffCode.Size = new System.Drawing.Size(116, 23);
			this.cmbStaffCode.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label6.Location = new System.Drawing.Point(602, 16);
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
			this.label5.Location = new System.Drawing.Point(355, 16);
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
			this.label4.Location = new System.Drawing.Point(477, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Task Type:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(15, 34);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(215, 23);
			this.txtDescription.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label3.Location = new System.Drawing.Point(233, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Staff:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvRequest);
			this.panel3.Location = new System.Drawing.Point(234, 139);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 390);
			this.panel3.TabIndex = 15;
			// 
			// dgvRequest
			// 
			this.dgvRequest.AllowUserToAddRows = false;
			this.dgvRequest.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRequest.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvRequest.ColumnHeadersHeight = 50;
			this.dgvRequest.DoubleBuffered = true;
			this.dgvRequest.EnableHeadersVisualStyles = false;
			this.dgvRequest.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvRequest.HeaderForeColor = System.Drawing.Color.White;
			this.dgvRequest.Location = new System.Drawing.Point(0, 0);
			this.dgvRequest.Name = "dgvRequest";
			this.dgvRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRequest.Size = new System.Drawing.Size(782, 390);
			this.dgvRequest.TabIndex = 0;
			this.dgvRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellClick);
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExportToExcel.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExportToExcel.FlatAppearance.BorderSize = 0;
			this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnExportToExcel.Location = new System.Drawing.Point(0, 146);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(200, 31);
			this.btnExportToExcel.TabIndex = 9;
			this.btnExportToExcel.Text = "Export to Excel";
			this.btnExportToExcel.UseVisualStyleBackColor = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
			// 
			// ucRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Name = "ucRequest";
			this.Size = new System.Drawing.Size(1056, 562);
			this.Load += new System.EventHandler(this.UcRequest_Load);
			this.pnlManage.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbAssignedStaffCode;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbTaskTypeCode;
		private System.Windows.Forms.ComboBox cmbStudentCode;
		private System.Windows.Forms.ComboBox cmbStaffCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRequest;
		private System.Windows.Forms.DateTimePicker dateRequest;
        private System.Windows.Forms.ComboBox cmbTime;
		private System.Windows.Forms.Button btnManageDelete;
		private System.Windows.Forms.Button btnExportToExcel;
	}
}
