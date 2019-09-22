namespace Info_IT.UserControls
{
	partial class ucInspection
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
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.tmrView = new System.Windows.Forms.Timer(this.components);
            this.tmrManage = new System.Windows.Forms.Timer(this.components);
            this.btnManageUpdate = new System.Windows.Forms.Button();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.pnlManage = new System.Windows.Forms.Panel();
            this.btnViewList = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.btnViewInspectiondetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInspection = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStaffCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVenueCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateInspection = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucInspectionDetails1 = new Info_IT.UserControls.ucInspectionDetails();
            this.pnlManage.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspection)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // tmrView
            // 
            this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
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
            this.btnManageUpdate.Text = "Update Selected Inspection";
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
            this.btnManageAdd.Text = "Add Inspection";
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
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewList.FlatAppearance.BorderSize = 0;
            this.btnViewList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewList.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnViewList.Location = new System.Drawing.Point(0, 53);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(200, 31);
            this.btnViewList.TabIndex = 6;
            this.btnViewList.Text = "List All Inspections";
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
            this.btnView.MinimumSize = new System.Drawing.Size(180, 53);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(200, 53);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlView.Controls.Add(this.btnViewInspectiondetails);
            this.pnlView.Controls.Add(this.btnViewList);
            this.pnlView.Controls.Add(this.btnView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 53);
            this.pnlView.MaximumSize = new System.Drawing.Size(200, 115);
            this.pnlView.MinimumSize = new System.Drawing.Size(200, 53);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(200, 53);
            this.pnlView.TabIndex = 13;
            // 
            // btnViewInspectiondetails
            // 
            this.btnViewInspectiondetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewInspectiondetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewInspectiondetails.FlatAppearance.BorderSize = 0;
            this.btnViewInspectiondetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInspectiondetails.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnViewInspectiondetails.Location = new System.Drawing.Point(0, 84);
            this.btnViewInspectiondetails.Name = "btnViewInspectiondetails";
            this.btnViewInspectiondetails.Size = new System.Drawing.Size(200, 31);
            this.btnViewInspectiondetails.TabIndex = 7;
            this.btnViewInspectiondetails.Text = "View Inspection Details";
            this.btnViewInspectiondetails.UseVisualStyleBackColor = false;
            this.btnViewInspectiondetails.Click += new System.EventHandler(this.BtnViewInspectiondetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pnlView);
            this.panel1.Controls.Add(this.pnlManage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 562);
            this.panel1.TabIndex = 12;
            // 
            // dgvInspection
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInspection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInspection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInspection.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInspection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInspection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInspection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInspection.ColumnHeadersHeight = 50;
            this.dgvInspection.DoubleBuffered = true;
            this.dgvInspection.EnableHeadersVisualStyles = false;
            this.dgvInspection.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.dgvInspection.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInspection.Location = new System.Drawing.Point(0, 0);
            this.dgvInspection.Name = "dgvInspection";
            this.dgvInspection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInspection.Size = new System.Drawing.Size(782, 390);
            this.dgvInspection.TabIndex = 0;
            this.dgvInspection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInspection_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvInspection);
            this.panel3.Location = new System.Drawing.Point(234, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 390);
            this.panel3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbStaffCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbVenueCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateInspection);
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
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(165, 35);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(113, 23);
            this.txtTime.TabIndex = 32;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(15, 77);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(761, 23);
            this.txtComment.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Comment:";
            // 
            // cmbStaffCode
            // 
            this.cmbStaffCode.FormattingEnabled = true;
            this.cmbStaffCode.Location = new System.Drawing.Point(409, 35);
            this.cmbStaffCode.Name = "cmbStaffCode";
            this.cmbStaffCode.Size = new System.Drawing.Size(116, 23);
            this.cmbStaffCode.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(409, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Staff Code:";
            // 
            // cmbVenueCode
            // 
            this.cmbVenueCode.FormattingEnabled = true;
            this.cmbVenueCode.Location = new System.Drawing.Point(287, 35);
            this.cmbVenueCode.Name = "cmbVenueCode";
            this.cmbVenueCode.Size = new System.Drawing.Size(116, 23);
            this.cmbVenueCode.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(284, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Venue Code:";
            // 
            // dateInspection
            // 
            this.dateInspection.CustomFormat = "dd MMMM yyyy";
            this.dateInspection.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInspection.Location = new System.Drawing.Point(15, 36);
            this.dateInspection.Name = "dateInspection";
            this.dateInspection.Size = new System.Drawing.Size(144, 23);
            this.dateInspection.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(162, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // ucInspectionDetails1
            // 
            this.ucInspectionDetails1.Location = new System.Drawing.Point(0, 0);
            this.ucInspectionDetails1.Name = "ucInspectionDetails1";
            this.ucInspectionDetails1.Size = new System.Drawing.Size(1056, 562);
            this.ucInspectionDetails1.TabIndex = 14;
            // 
            // ucInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucInspectionDetails1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ucInspection";
            this.Size = new System.Drawing.Size(1056, 562);
            this.Load += new System.EventHandler(this.UcNavInspection_Load);
            this.pnlManage.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspection)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Button btnViewList;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Panel pnlView;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInspection;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtComment;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbStaffCode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbVenueCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateInspection;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnViewInspectiondetails;
		private ucInspectionDetails ucInspectionDetails1;
		private System.Windows.Forms.TextBox txtTime;
	}
}
