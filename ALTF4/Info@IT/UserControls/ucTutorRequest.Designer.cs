namespace Info_IT.UserControls
{
	partial class ucTutorRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTutorRequest = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tmrView = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlManage = new System.Windows.Forms.Panel();
            this.btnManageUpdate = new System.Windows.Forms.Button();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.tmrManage = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorRequest)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlManage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTutorRequest);
            this.panel3.Location = new System.Drawing.Point(234, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 429);
            this.panel3.TabIndex = 18;
            // 
            // dgvTutorRequest
            // 
            this.dgvTutorRequest.AllowUserToAddRows = false;
            this.dgvTutorRequest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTutorRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutorRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTutorRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTutorRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutorRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutorRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTutorRequest.ColumnHeadersHeight = 50;
            this.dgvTutorRequest.DoubleBuffered = true;
            this.dgvTutorRequest.EnableHeadersVisualStyles = false;
            this.dgvTutorRequest.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.dgvTutorRequest.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTutorRequest.Location = new System.Drawing.Point(0, 0);
            this.dgvTutorRequest.Name = "dgvTutorRequest";
            this.dgvTutorRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTutorRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutorRequest.Size = new System.Drawing.Size(782, 429);
            this.dgvTutorRequest.TabIndex = 0;
            this.dgvTutorRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutorRequest_CellClick);
            // 
            // tmrView
            // 
            this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pnlManage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 562);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlManage
            // 
            this.pnlManage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlManage.Controls.Add(this.btnManageUpdate);
            this.pnlManage.Controls.Add(this.btnManageAdd);
            this.pnlManage.Controls.Add(this.btnManage);
            this.pnlManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManage.Location = new System.Drawing.Point(0, 0);
            this.pnlManage.MaximumSize = new System.Drawing.Size(200, 114);
            this.pnlManage.MinimumSize = new System.Drawing.Size(200, 53);
            this.pnlManage.Name = "pnlManage";
            this.pnlManage.Size = new System.Drawing.Size(200, 53);
            this.pnlManage.TabIndex = 12;
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
            this.btnManageUpdate.Text = "Update Selected Tutor Request";
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
            this.btnManageAdd.Text = "Add Tutor Request";
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
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // tmrManage
            // 
            this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label2);
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
            this.groupBox1.Location = new System.Drawing.Point(234, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 71);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(686, 33);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(70, 23);
            this.cmbStatus.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(686, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Status:";
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.FormattingEnabled = true;
            this.cmbEndTime.Items.AddRange(new object[] {
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
            "16:30:00",
            "17:00:00"});
            this.cmbEndTime.Location = new System.Drawing.Point(610, 33);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(70, 23);
            this.cmbEndTime.TabIndex = 25;
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.FormattingEnabled = true;
            this.cmbStartTime.Items.AddRange(new object[] {
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
            this.cmbStartTime.Location = new System.Drawing.Point(531, 33);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(73, 23);
            this.cmbStartTime.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(528, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start Time:";
            // 
            // cmbRequestCode
            // 
            this.cmbRequestCode.FormattingEnabled = true;
            this.cmbRequestCode.Location = new System.Drawing.Point(15, 33);
            this.cmbRequestCode.Name = "cmbRequestCode";
            this.cmbRequestCode.Size = new System.Drawing.Size(116, 23);
            this.cmbRequestCode.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(610, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "End Time:";
            // 
            // dateRequest
            // 
            this.dateRequest.CustomFormat = "dd MMMM yyyy";
            this.dateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRequest.Location = new System.Drawing.Point(137, 33);
            this.dateRequest.Name = "dateRequest";
            this.dateRequest.Size = new System.Drawing.Size(144, 23);
            this.dateRequest.TabIndex = 16;
            // 
            // cmbVenueCode
            // 
            this.cmbVenueCode.FormattingEnabled = true;
            this.cmbVenueCode.Location = new System.Drawing.Point(409, 33);
            this.cmbVenueCode.Name = "cmbVenueCode";
            this.cmbVenueCode.Size = new System.Drawing.Size(116, 23);
            this.cmbVenueCode.TabIndex = 14;
            // 
            // cmbModuleCode
            // 
            this.cmbModuleCode.FormattingEnabled = true;
            this.cmbModuleCode.Location = new System.Drawing.Point(287, 33);
            this.cmbModuleCode.Name = "cmbModuleCode";
            this.cmbModuleCode.Size = new System.Drawing.Size(116, 23);
            this.cmbModuleCode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(137, 16);
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
            this.label5.Location = new System.Drawing.Point(406, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Venue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(284, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Code:";
            // 
            // ucTutorRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ucTutorRequest";
            this.Size = new System.Drawing.Size(1056, 562);
            this.Load += new System.EventHandler(this.UcTutorRequest_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorRequest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlManage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTutorRequest;
		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ComboBox cmbEndTime;
        private System.Windows.Forms.ComboBox cmbStartTime;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label2;
	}
}
