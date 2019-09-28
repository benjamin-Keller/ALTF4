namespace Info_IT.UserControls
{
	partial class ucStaff
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
            this.dgvStaff = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.btnViewList = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlManage = new System.Windows.Forms.Panel();
            this.btnManageUpdate = new System.Windows.Forms.Button();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.tmrManage = new System.Windows.Forms.Timer(this.components);
            this.tmrView = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDepartmentCode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlManage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.ColumnHeadersHeight = 50;
            this.dgvStaff.DoubleBuffered = true;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.dgvStaff.HeaderForeColor = System.Drawing.Color.White;
            this.dgvStaff.Location = new System.Drawing.Point(0, -1);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaff.Size = new System.Drawing.Size(1043, 478);
            this.dgvStaff.TabIndex = 1;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffExUser_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pnlView);
            this.panel1.Controls.Add(this.pnlManage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 692);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlView.Controls.Add(this.btnViewList);
            this.pnlView.Controls.Add(this.btnView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 65);
            this.pnlView.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnViewList.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(267, 38);
            this.btnViewList.TabIndex = 6;
            this.btnViewList.Text = "List All Staff Members";
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
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
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
            this.pnlManage.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnManageUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageUpdate.Name = "btnManageUpdate";
            this.btnManageUpdate.Size = new System.Drawing.Size(267, 38);
            this.btnManageUpdate.TabIndex = 7;
            this.btnManageUpdate.Text = "Update Selected Staff";
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
            this.btnManageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageAdd.Name = "btnManageAdd";
            this.btnManageAdd.Size = new System.Drawing.Size(267, 38);
            this.btnManageAdd.TabIndex = 6;
            this.btnManageAdd.Text = "Add Staff";
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
            this.btnManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnManage.MinimumSize = new System.Drawing.Size(240, 65);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(267, 65);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manage";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.BtnManage_Click);
            // 
            // tmrManage
            // 
            this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
            // 
            // tmrView
            // 
            this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvStaff);
            this.panel3.Location = new System.Drawing.Point(312, 171);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 476);
            this.panel3.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDepartmentCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbStaffType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtContactNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmailAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStaffNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(312, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1043, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cmbDepartmentCode
            // 
            this.cmbDepartmentCode.FormattingEnabled = true;
            this.cmbDepartmentCode.Location = new System.Drawing.Point(196, 95);
            this.cmbDepartmentCode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartmentCode.Name = "cmbDepartmentCode";
            this.cmbDepartmentCode.Size = new System.Drawing.Size(167, 28);
            this.cmbDepartmentCode.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(192, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Department Code:";
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Location = new System.Drawing.Point(20, 95);
            this.cmbStaffType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(167, 28);
            this.cmbStaffType.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(16, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Staff Type:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(724, 44);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(167, 27);
            this.txtContactNo.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(720, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Contact Number:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(548, 44);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(167, 27);
            this.txtEmailAddress.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(544, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Email Address;";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(372, 44);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(167, 27);
            this.txtSurname.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(368, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(196, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 27);
            this.txtName.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(192, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name:";
            // 
            // txtStaffNumber
            // 
            this.txtStaffNumber.Location = new System.Drawing.Point(20, 44);
            this.txtStaffNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffNumber.Name = "txtStaffNumber";
            this.txtStaffNumber.Size = new System.Drawing.Size(167, 27);
            this.txtStaffNumber.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Number:";
            // 
            // ucStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucStaff";
            this.Size = new System.Drawing.Size(1408, 692);
            this.Load += new System.EventHandler(this.UcStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.pnlManage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvStaff;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlView;
		private System.Windows.Forms.Button btnViewList;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtStaffNumber;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmailAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtContactNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbStaffType;
		private System.Windows.Forms.ComboBox cmbDepartmentCode;
		private System.Windows.Forms.Label label7;
	}
}
