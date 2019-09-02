namespace Info_IT
{
    partial class Request
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvVenue = new System.Windows.Forms.DataGridView();
			this.tmrNavigation = new System.Windows.Forms.Timer(this.components);
			this.tmrView = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbAssignedStaffCode = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateRequest = new System.Windows.Forms.DateTimePicker();
			this.cmbTaskTypeCode = new System.Windows.Forms.ComboBox();
			this.cmbStudentCode = new System.Windows.Forms.ComboBox();
			this.cmbStaffCode = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tmrManage = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlView = new System.Windows.Forms.Panel();
			this.btnViewList = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.pnlManage = new System.Windows.Forms.Panel();
			this.btnManageUpdate = new System.Windows.Forms.Button();
			this.btnManageAdd = new System.Windows.Forms.Button();
			this.btnManage = new System.Windows.Forms.Button();
			this.pnlNavigation = new System.Windows.Forms.Panel();
			this.btnNavTaskType = new System.Windows.Forms.Button();
			this.btnNavInspectionDetail = new System.Windows.Forms.Button();
			this.btnNavInspection = new System.Windows.Forms.Button();
			this.btnNavTutorRequest = new System.Windows.Forms.Button();
			this.btnNavDepartment = new System.Windows.Forms.Button();
			this.btnNavEquipmentType = new System.Windows.Forms.Button();
			this.btnNavVenue = new System.Windows.Forms.Button();
			this.btnNavEquipment = new System.Windows.Forms.Button();
			this.btnNavHome = new System.Windows.Forms.Button();
			this.btnNavigation = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVenue)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlView.SuspendLayout();
			this.pnlManage.SuspendLayout();
			this.pnlNavigation.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvVenue);
			this.panel3.Location = new System.Drawing.Point(188, 128);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(609, 310);
			this.panel3.TabIndex = 15;
			// 
			// dgvVenue
			// 
			this.dgvVenue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.dgvVenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVenue.Location = new System.Drawing.Point(4, 3);
			this.dgvVenue.Name = "dgvVenue";
			this.dgvVenue.Size = new System.Drawing.Size(598, 304);
			this.dgvVenue.TabIndex = 6;
			// 
			// tmrNavigation
			// 
			this.tmrNavigation.Tick += new System.EventHandler(this.TmrNavigation_Tick);
			// 
			// tmrView
			// 
			this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label5.Location = new System.Drawing.Point(355, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Student Code:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label4.Location = new System.Drawing.Point(477, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Task Type Code:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(15, 34);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(215, 20);
			this.txtDescription.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label3.Location = new System.Drawing.Point(233, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Staff Code:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbAssignedStaffCode);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtTime);
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
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(186, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(602, 110);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// cmbAssignedStaffCode
			// 
			this.cmbAssignedStaffCode.FormattingEnabled = true;
			this.cmbAssignedStaffCode.Location = new System.Drawing.Point(261, 73);
			this.cmbAssignedStaffCode.Name = "cmbAssignedStaffCode";
			this.cmbAssignedStaffCode.Size = new System.Drawing.Size(162, 21);
			this.cmbAssignedStaffCode.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label8.Location = new System.Drawing.Point(258, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Staff Code (Assigned Staff):";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(165, 74);
			this.txtTime.Mask = "00:00";
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(90, 20);
			this.txtTime.TabIndex = 19;
			this.txtTime.ValidatingType = typeof(System.DateTime);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label7.Location = new System.Drawing.Point(162, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Time (24 hour):";
			// 
			// dateRequest
			// 
			this.dateRequest.CustomFormat = "dd MMMM yyyy";
			this.dateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateRequest.Location = new System.Drawing.Point(15, 74);
			this.dateRequest.Name = "dateRequest";
			this.dateRequest.Size = new System.Drawing.Size(144, 20);
			this.dateRequest.TabIndex = 16;
			// 
			// cmbTaskTypeCode
			// 
			this.cmbTaskTypeCode.FormattingEnabled = true;
			this.cmbTaskTypeCode.Location = new System.Drawing.Point(480, 33);
			this.cmbTaskTypeCode.Name = "cmbTaskTypeCode";
			this.cmbTaskTypeCode.Size = new System.Drawing.Size(116, 21);
			this.cmbTaskTypeCode.TabIndex = 15;
			// 
			// cmbStudentCode
			// 
			this.cmbStudentCode.FormattingEnabled = true;
			this.cmbStudentCode.Location = new System.Drawing.Point(358, 33);
			this.cmbStudentCode.Name = "cmbStudentCode";
			this.cmbStudentCode.Size = new System.Drawing.Size(116, 21);
			this.cmbStudentCode.TabIndex = 14;
			// 
			// cmbStaffCode
			// 
			this.cmbStaffCode.FormattingEnabled = true;
			this.cmbStaffCode.Location = new System.Drawing.Point(236, 33);
			this.cmbStaffCode.Name = "cmbStaffCode";
			this.cmbStaffCode.Size = new System.Drawing.Size(116, 21);
			this.cmbStaffCode.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label6.Location = new System.Drawing.Point(15, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Date:";
			// 
			// tmrManage
			// 
			this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pnlView);
			this.panel1.Controls.Add(this.pnlManage);
			this.panel1.Controls.Add(this.pnlNavigation);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(180, 450);
			this.panel1.TabIndex = 16;
			// 
			// pnlView
			// 
			this.pnlView.Controls.Add(this.btnViewList);
			this.pnlView.Controls.Add(this.btnView);
			this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlView.Location = new System.Drawing.Point(0, 175);
			this.pnlView.MaximumSize = new System.Drawing.Size(180, 115);
			this.pnlView.MinimumSize = new System.Drawing.Size(180, 53);
			this.pnlView.Name = "pnlView";
			this.pnlView.Size = new System.Drawing.Size(180, 53);
			this.pnlView.TabIndex = 8;
			// 
			// btnViewList
			// 
			this.btnViewList.BackColor = System.Drawing.Color.Teal;
			this.btnViewList.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnViewList.FlatAppearance.BorderSize = 0;
			this.btnViewList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnViewList.Location = new System.Drawing.Point(0, 53);
			this.btnViewList.Name = "btnViewList";
			this.btnViewList.Size = new System.Drawing.Size(180, 31);
			this.btnViewList.TabIndex = 6;
			this.btnViewList.Text = "List All Equipment";
			this.btnViewList.UseVisualStyleBackColor = false;
			this.btnViewList.Click += new System.EventHandler(this.BtnViewList_Click);
			// 
			// btnView
			// 
			this.btnView.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnView.FlatAppearance.BorderSize = 0;
			this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnView.Location = new System.Drawing.Point(0, 0);
			this.btnView.MinimumSize = new System.Drawing.Size(180, 53);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(180, 53);
			this.btnView.TabIndex = 5;
			this.btnView.Text = "View";
			this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnView.UseVisualStyleBackColor = false;
			this.btnView.Click += new System.EventHandler(this.BtnView_Click);
			// 
			// pnlManage
			// 
			this.pnlManage.Controls.Add(this.btnManageUpdate);
			this.pnlManage.Controls.Add(this.btnManageAdd);
			this.pnlManage.Controls.Add(this.btnManage);
			this.pnlManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlManage.Location = new System.Drawing.Point(0, 122);
			this.pnlManage.MaximumSize = new System.Drawing.Size(180, 114);
			this.pnlManage.MinimumSize = new System.Drawing.Size(180, 53);
			this.pnlManage.Name = "pnlManage";
			this.pnlManage.Size = new System.Drawing.Size(180, 53);
			this.pnlManage.TabIndex = 7;
			// 
			// btnManageUpdate
			// 
			this.btnManageUpdate.BackColor = System.Drawing.Color.Teal;
			this.btnManageUpdate.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageUpdate.FlatAppearance.BorderSize = 0;
			this.btnManageUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageUpdate.Location = new System.Drawing.Point(0, 84);
			this.btnManageUpdate.Name = "btnManageUpdate";
			this.btnManageUpdate.Size = new System.Drawing.Size(180, 31);
			this.btnManageUpdate.TabIndex = 7;
			this.btnManageUpdate.Text = "Update Selected Equipment";
			this.btnManageUpdate.UseVisualStyleBackColor = false;
			this.btnManageUpdate.Click += new System.EventHandler(this.BtnManageUpdate_Click);
			// 
			// btnManageAdd
			// 
			this.btnManageAdd.BackColor = System.Drawing.Color.Teal;
			this.btnManageAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageAdd.FlatAppearance.BorderSize = 0;
			this.btnManageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageAdd.Location = new System.Drawing.Point(0, 53);
			this.btnManageAdd.Name = "btnManageAdd";
			this.btnManageAdd.Size = new System.Drawing.Size(180, 31);
			this.btnManageAdd.TabIndex = 6;
			this.btnManageAdd.Text = "Add Equipment";
			this.btnManageAdd.UseVisualStyleBackColor = false;
			this.btnManageAdd.Click += new System.EventHandler(this.BtnManageAdd_Click);
			// 
			// btnManage
			// 
			this.btnManage.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManage.FlatAppearance.BorderSize = 0;
			this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManage.Location = new System.Drawing.Point(0, 0);
			this.btnManage.MinimumSize = new System.Drawing.Size(180, 53);
			this.btnManage.Name = "btnManage";
			this.btnManage.Size = new System.Drawing.Size(180, 53);
			this.btnManage.TabIndex = 5;
			this.btnManage.Text = "Manage";
			this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnManage.UseVisualStyleBackColor = false;
			this.btnManage.Click += new System.EventHandler(this.BtnManage_Click);
			// 
			// pnlNavigation
			// 
			this.pnlNavigation.Controls.Add(this.btnNavTaskType);
			this.pnlNavigation.Controls.Add(this.btnNavInspectionDetail);
			this.pnlNavigation.Controls.Add(this.btnNavInspection);
			this.pnlNavigation.Controls.Add(this.btnNavTutorRequest);
			this.pnlNavigation.Controls.Add(this.btnNavDepartment);
			this.pnlNavigation.Controls.Add(this.btnNavEquipmentType);
			this.pnlNavigation.Controls.Add(this.btnNavVenue);
			this.pnlNavigation.Controls.Add(this.btnNavEquipment);
			this.pnlNavigation.Controls.Add(this.btnNavHome);
			this.pnlNavigation.Controls.Add(this.btnNavigation);
			this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNavigation.Location = new System.Drawing.Point(0, 69);
			this.pnlNavigation.MaximumSize = new System.Drawing.Size(180, 332);
			this.pnlNavigation.MinimumSize = new System.Drawing.Size(180, 53);
			this.pnlNavigation.Name = "pnlNavigation";
			this.pnlNavigation.Size = new System.Drawing.Size(180, 53);
			this.pnlNavigation.TabIndex = 2;
			// 
			// btnNavTaskType
			// 
			this.btnNavTaskType.BackColor = System.Drawing.Color.Teal;
			this.btnNavTaskType.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavTaskType.FlatAppearance.BorderSize = 0;
			this.btnNavTaskType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavTaskType.Location = new System.Drawing.Point(0, 301);
			this.btnNavTaskType.Name = "btnNavTaskType";
			this.btnNavTaskType.Size = new System.Drawing.Size(180, 31);
			this.btnNavTaskType.TabIndex = 23;
			this.btnNavTaskType.Text = "Task Type";
			this.btnNavTaskType.UseVisualStyleBackColor = false;
			this.btnNavTaskType.Click += new System.EventHandler(this.BtnNavTaskType_Click);
			// 
			// btnNavInspectionDetail
			// 
			this.btnNavInspectionDetail.BackColor = System.Drawing.Color.Teal;
			this.btnNavInspectionDetail.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavInspectionDetail.FlatAppearance.BorderSize = 0;
			this.btnNavInspectionDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavInspectionDetail.Location = new System.Drawing.Point(0, 270);
			this.btnNavInspectionDetail.Name = "btnNavInspectionDetail";
			this.btnNavInspectionDetail.Size = new System.Drawing.Size(180, 31);
			this.btnNavInspectionDetail.TabIndex = 22;
			this.btnNavInspectionDetail.Text = "Inspection Details";
			this.btnNavInspectionDetail.UseVisualStyleBackColor = false;
			this.btnNavInspectionDetail.Click += new System.EventHandler(this.BtnNavInspectionDetail_Click);
			// 
			// btnNavInspection
			// 
			this.btnNavInspection.BackColor = System.Drawing.Color.Teal;
			this.btnNavInspection.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavInspection.FlatAppearance.BorderSize = 0;
			this.btnNavInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavInspection.Location = new System.Drawing.Point(0, 239);
			this.btnNavInspection.Name = "btnNavInspection";
			this.btnNavInspection.Size = new System.Drawing.Size(180, 31);
			this.btnNavInspection.TabIndex = 21;
			this.btnNavInspection.Text = "Inspection";
			this.btnNavInspection.UseVisualStyleBackColor = false;
			this.btnNavInspection.Click += new System.EventHandler(this.BtnNavInspection_Click);
			// 
			// btnNavTutorRequest
			// 
			this.btnNavTutorRequest.BackColor = System.Drawing.Color.Teal;
			this.btnNavTutorRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavTutorRequest.FlatAppearance.BorderSize = 0;
			this.btnNavTutorRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavTutorRequest.Location = new System.Drawing.Point(0, 208);
			this.btnNavTutorRequest.Name = "btnNavTutorRequest";
			this.btnNavTutorRequest.Size = new System.Drawing.Size(180, 31);
			this.btnNavTutorRequest.TabIndex = 20;
			this.btnNavTutorRequest.Text = "Tutor Request";
			this.btnNavTutorRequest.UseVisualStyleBackColor = false;
			this.btnNavTutorRequest.Click += new System.EventHandler(this.BtnNavTutorRequest_Click);
			// 
			// btnNavDepartment
			// 
			this.btnNavDepartment.BackColor = System.Drawing.Color.Teal;
			this.btnNavDepartment.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavDepartment.FlatAppearance.BorderSize = 0;
			this.btnNavDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavDepartment.Location = new System.Drawing.Point(0, 177);
			this.btnNavDepartment.Name = "btnNavDepartment";
			this.btnNavDepartment.Size = new System.Drawing.Size(180, 31);
			this.btnNavDepartment.TabIndex = 18;
			this.btnNavDepartment.Text = "Department";
			this.btnNavDepartment.UseVisualStyleBackColor = false;
			this.btnNavDepartment.Click += new System.EventHandler(this.BtnNavDepartment_Click);
			// 
			// btnNavEquipmentType
			// 
			this.btnNavEquipmentType.BackColor = System.Drawing.Color.Teal;
			this.btnNavEquipmentType.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavEquipmentType.FlatAppearance.BorderSize = 0;
			this.btnNavEquipmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavEquipmentType.Location = new System.Drawing.Point(0, 146);
			this.btnNavEquipmentType.Name = "btnNavEquipmentType";
			this.btnNavEquipmentType.Size = new System.Drawing.Size(180, 31);
			this.btnNavEquipmentType.TabIndex = 17;
			this.btnNavEquipmentType.Text = "Equipment Type";
			this.btnNavEquipmentType.UseVisualStyleBackColor = false;
			this.btnNavEquipmentType.Click += new System.EventHandler(this.BtnNavEquipmentType_Click);
			// 
			// btnNavVenue
			// 
			this.btnNavVenue.BackColor = System.Drawing.Color.Teal;
			this.btnNavVenue.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavVenue.FlatAppearance.BorderSize = 0;
			this.btnNavVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavVenue.Location = new System.Drawing.Point(0, 115);
			this.btnNavVenue.Name = "btnNavVenue";
			this.btnNavVenue.Size = new System.Drawing.Size(180, 31);
			this.btnNavVenue.TabIndex = 16;
			this.btnNavVenue.Text = "Venue";
			this.btnNavVenue.UseVisualStyleBackColor = false;
			this.btnNavVenue.Click += new System.EventHandler(this.BtnNavVenue_Click);
			// 
			// btnNavEquipment
			// 
			this.btnNavEquipment.BackColor = System.Drawing.Color.Teal;
			this.btnNavEquipment.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavEquipment.FlatAppearance.BorderSize = 0;
			this.btnNavEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavEquipment.Location = new System.Drawing.Point(0, 84);
			this.btnNavEquipment.Name = "btnNavEquipment";
			this.btnNavEquipment.Size = new System.Drawing.Size(180, 31);
			this.btnNavEquipment.TabIndex = 15;
			this.btnNavEquipment.Text = "Equipment";
			this.btnNavEquipment.UseVisualStyleBackColor = false;
			this.btnNavEquipment.Click += new System.EventHandler(this.BtnNavEquipment_Click);
			// 
			// btnNavHome
			// 
			this.btnNavHome.BackColor = System.Drawing.Color.Teal;
			this.btnNavHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavHome.FlatAppearance.BorderSize = 0;
			this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavHome.Location = new System.Drawing.Point(0, 53);
			this.btnNavHome.Name = "btnNavHome";
			this.btnNavHome.Size = new System.Drawing.Size(180, 31);
			this.btnNavHome.TabIndex = 6;
			this.btnNavHome.Text = "Home";
			this.btnNavHome.UseVisualStyleBackColor = false;
			this.btnNavHome.Click += new System.EventHandler(this.BtnNavHome_Click);
			// 
			// btnNavigation
			// 
			this.btnNavigation.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnNavigation.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavigation.FlatAppearance.BorderSize = 0;
			this.btnNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNavigation.Location = new System.Drawing.Point(0, 0);
			this.btnNavigation.MinimumSize = new System.Drawing.Size(180, 53);
			this.btnNavigation.Name = "btnNavigation";
			this.btnNavigation.Size = new System.Drawing.Size(180, 53);
			this.btnNavigation.TabIndex = 5;
			this.btnNavigation.Text = "Navigation";
			this.btnNavigation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnNavigation.UseVisualStyleBackColor = false;
			this.btnNavigation.Click += new System.EventHandler(this.BtnNavigation_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(180, 69);
			this.panel2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Gill Sans MT Condensed", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(35, -11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 83);
			this.label2.TabIndex = 0;
			this.label2.Text = "@";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Request
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Request";
			this.Text = "Request";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Request_FormClosing);
			this.Load += new System.EventHandler(this.Request_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVenue)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.pnlView.ResumeLayout(false);
			this.pnlManage.ResumeLayout(false);
			this.pnlNavigation.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dgvVenue;
		private System.Windows.Forms.Timer tmrNavigation;
		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.ComboBox cmbStaffCode;
		private System.Windows.Forms.ComboBox cmbStudentCode;
		private System.Windows.Forms.ComboBox cmbTaskTypeCode;
		private System.Windows.Forms.DateTimePicker dateRequest;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox txtTime;
		private System.Windows.Forms.ComboBox cmbAssignedStaffCode;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlView;
		private System.Windows.Forms.Button btnViewList;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Panel pnlNavigation;
		private System.Windows.Forms.Button btnNavTaskType;
		private System.Windows.Forms.Button btnNavInspectionDetail;
		private System.Windows.Forms.Button btnNavInspection;
		private System.Windows.Forms.Button btnNavTutorRequest;
		private System.Windows.Forms.Button btnNavDepartment;
		private System.Windows.Forms.Button btnNavEquipmentType;
		private System.Windows.Forms.Button btnNavVenue;
		private System.Windows.Forms.Button btnNavEquipment;
		private System.Windows.Forms.Button btnNavHome;
		private System.Windows.Forms.Button btnNavigation;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
	}
}