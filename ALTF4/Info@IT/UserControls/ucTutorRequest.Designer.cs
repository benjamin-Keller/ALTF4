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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTutorRequest = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tmrView = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.btnViewList = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlManage = new System.Windows.Forms.Panel();
            this.btnManageUpdate = new System.Windows.Forms.Button();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.tmrManage = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorRequest)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlManage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTutorRequest);
            this.panel3.Location = new System.Drawing.Point(312, 123);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 528);
            this.panel3.TabIndex = 18;
            // 
            // dgvTutorRequest
            // 
            this.dgvTutorRequest.AllowUserToAddRows = false;
            this.dgvTutorRequest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTutorRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutorRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTutorRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTutorRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutorRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutorRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutorRequest.ColumnHeadersHeight = 50;
            this.dgvTutorRequest.DoubleBuffered = true;
            this.dgvTutorRequest.EnableHeadersVisualStyles = false;
            this.dgvTutorRequest.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.dgvTutorRequest.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTutorRequest.Location = new System.Drawing.Point(0, 0);
            this.dgvTutorRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTutorRequest.Name = "dgvTutorRequest";
            this.dgvTutorRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTutorRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutorRequest.Size = new System.Drawing.Size(1043, 528);
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
            this.panel1.Controls.Add(this.pnlView);
            this.panel1.Controls.Add(this.pnlManage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 692);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlView.Controls.Add(this.btnViewList);
            this.pnlView.Controls.Add(this.btnView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 65);
            this.pnlView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlView.MaximumSize = new System.Drawing.Size(267, 142);
            this.pnlView.MinimumSize = new System.Drawing.Size(267, 65);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(267, 65);
            this.pnlView.TabIndex = 13;
            // 
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewList.FlatAppearance.BorderSize = 0;
            this.btnViewList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewList.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnViewList.Location = new System.Drawing.Point(0, 65);
            this.btnViewList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(267, 38);
            this.btnViewList.TabIndex = 6;
            this.btnViewList.Text = "List All Tutor Requests";
            this.btnViewList.UseVisualStyleBackColor = false;
            this.btnViewList.Click += new System.EventHandler(this.BtnViewList_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnView.Location = new System.Drawing.Point(0, 0);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnView.MinimumSize = new System.Drawing.Size(240, 65);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(267, 65);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // pnlManage
            // 
            this.pnlManage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlManage.Controls.Add(this.btnManageUpdate);
            this.pnlManage.Controls.Add(this.btnManageAdd);
            this.pnlManage.Controls.Add(this.btnManage);
            this.pnlManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManage.Location = new System.Drawing.Point(0, 0);
            this.pnlManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlManage.MaximumSize = new System.Drawing.Size(267, 140);
            this.pnlManage.MinimumSize = new System.Drawing.Size(267, 65);
            this.pnlManage.Name = "pnlManage";
            this.pnlManage.Size = new System.Drawing.Size(267, 65);
            this.pnlManage.TabIndex = 12;
            // 
            // btnManageUpdate
            // 
            this.btnManageUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUpdate.FlatAppearance.BorderSize = 0;
            this.btnManageUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUpdate.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnManageUpdate.Location = new System.Drawing.Point(0, 103);
            this.btnManageUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageUpdate.Name = "btnManageUpdate";
            this.btnManageUpdate.Size = new System.Drawing.Size(267, 38);
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
            this.btnManageAdd.Location = new System.Drawing.Point(0, 65);
            this.btnManageAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageAdd.Name = "btnManageAdd";
            this.btnManageAdd.Size = new System.Drawing.Size(267, 38);
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
            this.btnManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManage.MinimumSize = new System.Drawing.Size(240, 65);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(267, 65);
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
            this.groupBox1.Location = new System.Drawing.Point(312, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1045, 87);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
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
            this.cmbEndTime.Location = new System.Drawing.Point(871, 41);
            this.cmbEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(160, 28);
            this.cmbEndTime.TabIndex = 25;
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
            this.cmbStartTime.Location = new System.Drawing.Point(708, 41);
            this.cmbStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(153, 28);
            this.cmbStartTime.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(704, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start Time:";
            // 
            // cmbRequestCode
            // 
            this.cmbRequestCode.FormattingEnabled = true;
            this.cmbRequestCode.Location = new System.Drawing.Point(20, 41);
            this.cmbRequestCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRequestCode.Name = "cmbRequestCode";
            this.cmbRequestCode.Size = new System.Drawing.Size(153, 28);
            this.cmbRequestCode.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(871, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "End Time:";
            // 
            // dateRequest
            // 
            this.dateRequest.CustomFormat = "dd MMMM yyyy";
            this.dateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRequest.Location = new System.Drawing.Point(183, 41);
            this.dateRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateRequest.Name = "dateRequest";
            this.dateRequest.Size = new System.Drawing.Size(191, 27);
            this.dateRequest.TabIndex = 16;
            // 
            // cmbVenueCode
            // 
            this.cmbVenueCode.FormattingEnabled = true;
            this.cmbVenueCode.Location = new System.Drawing.Point(545, 41);
            this.cmbVenueCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbVenueCode.Name = "cmbVenueCode";
            this.cmbVenueCode.Size = new System.Drawing.Size(153, 28);
            this.cmbVenueCode.TabIndex = 14;
            // 
            // cmbModuleCode
            // 
            this.cmbModuleCode.FormattingEnabled = true;
            this.cmbModuleCode.Location = new System.Drawing.Point(383, 41);
            this.cmbModuleCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbModuleCode.Name = "cmbModuleCode";
            this.cmbModuleCode.Size = new System.Drawing.Size(153, 28);
            this.cmbModuleCode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(183, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(541, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Venue Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(379, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Code:";
            // 
            // ucTutorRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucTutorRequest";
            this.Size = new System.Drawing.Size(1408, 692);
            this.Load += new System.EventHandler(this.UcTutorRequest_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorRequest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
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
		private System.Windows.Forms.Panel pnlView;
		private System.Windows.Forms.Button btnViewList;
		private System.Windows.Forms.Button btnView;
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
    }
}
