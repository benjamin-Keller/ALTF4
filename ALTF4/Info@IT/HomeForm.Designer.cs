namespace Info_IT
{
	partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnNavUser = new System.Windows.Forms.Button();
            this.btnNavStaff = new System.Windows.Forms.Button();
            this.btnNavStudent = new System.Windows.Forms.Button();
            this.btnNavTaskType = new System.Windows.Forms.Button();
            this.btnNavInspection = new System.Windows.Forms.Button();
            this.btnNavTutorRequest = new System.Windows.Forms.Button();
            this.btnNavRequest = new System.Windows.Forms.Button();
            this.btnNavDepartment = new System.Windows.Forms.Button();
            this.btnNavVenue = new System.Windows.Forms.Button();
            this.btnNavEquipment = new System.Windows.Forms.Button();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.btnNavigation = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNavHelp = new System.Windows.Forms.Button();
            this.tmrNavigation = new System.Windows.Forms.Timer(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlLoginFields = new System.Windows.Forms.Panel();
            this.btnLogIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLoginText = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.ucErrorFailedToAdd1 = new Info_IT.Errors.ucErrorFailedToAdd();
            this.ucErrorUserNotFound1 = new Info_IT.Errors.ucErrorUserNotFound();
            this.ucErrorStaffNotFound1 = new Info_IT.Errors.ucErrorStaffNotFound();
            this.ucErrorVenueNotFound1 = new Info_IT.Errors.ucErrorVenueNotFound();
            this.ucErrorStudentNotFound1 = new Info_IT.Errors.ucErrorStudentNotFound();
            this.ucUser1 = new Info_IT.UserControls.ucUser();
            this.ucStudent1 = new Info_IT.UserControls.ucStudent();
            this.ucStaff1 = new Info_IT.UserControls.ucStaff();
            this.ucHelp1 = new Info_IT.UserControls.ucHelp();
            this.ucTaskType1 = new Info_IT.UserControls.ucTaskType();
            this.ucNavInspection1 = new Info_IT.UserControls.ucInspection();
            this.ucTutorRequest1 = new Info_IT.UserControls.ucTutorRequest();
            this.ucRequest1 = new Info_IT.UserControls.ucRequest();
            this.ucVenue1 = new Info_IT.UserControls.ucVenue();
            this.ucHome1 = new Info_IT.UserControls.ucHome();
            this.ucEquipment1 = new Info_IT.UserControls.UcEquipment();
            this.ucDepartment1 = new Info_IT.UserControls.ucDepartment();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLoginFields.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnNavHelp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 620);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlNavigation);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 578);
            this.panel3.TabIndex = 6;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnNavUser);
            this.pnlNavigation.Controls.Add(this.btnNavStaff);
            this.pnlNavigation.Controls.Add(this.btnNavStudent);
            this.pnlNavigation.Controls.Add(this.btnNavTaskType);
            this.pnlNavigation.Controls.Add(this.btnNavInspection);
            this.pnlNavigation.Controls.Add(this.btnNavTutorRequest);
            this.pnlNavigation.Controls.Add(this.btnNavRequest);
            this.pnlNavigation.Controls.Add(this.btnNavDepartment);
            this.pnlNavigation.Controls.Add(this.btnNavVenue);
            this.pnlNavigation.Controls.Add(this.btnNavEquipment);
            this.pnlNavigation.Controls.Add(this.btnNavHome);
            this.pnlNavigation.Controls.Add(this.btnNavigation);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.ForeColor = System.Drawing.Color.White;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 109);
            this.pnlNavigation.MaximumSize = new System.Drawing.Size(200, 450);
            this.pnlNavigation.MinimumSize = new System.Drawing.Size(200, 53);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 450);
            this.pnlNavigation.TabIndex = 9;
            // 
            // btnNavUser
            // 
            this.btnNavUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavUser.FlatAppearance.BorderSize = 0;
            this.btnNavUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavUser.Location = new System.Drawing.Point(0, 363);
            this.btnNavUser.Name = "btnNavUser";
            this.btnNavUser.Size = new System.Drawing.Size(200, 31);
            this.btnNavUser.TabIndex = 26;
            this.btnNavUser.Text = "User";
            this.btnNavUser.UseVisualStyleBackColor = false;
            this.btnNavUser.Click += new System.EventHandler(this.BtnNavUser_Click);
            // 
            // btnNavStaff
            // 
            this.btnNavStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavStaff.FlatAppearance.BorderSize = 0;
            this.btnNavStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavStaff.Location = new System.Drawing.Point(0, 332);
            this.btnNavStaff.Name = "btnNavStaff";
            this.btnNavStaff.Size = new System.Drawing.Size(200, 31);
            this.btnNavStaff.TabIndex = 25;
            this.btnNavStaff.Text = "Staff";
            this.btnNavStaff.UseVisualStyleBackColor = false;
            this.btnNavStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // btnNavStudent
            // 
            this.btnNavStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavStudent.FlatAppearance.BorderSize = 0;
            this.btnNavStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavStudent.Location = new System.Drawing.Point(0, 301);
            this.btnNavStudent.Name = "btnNavStudent";
            this.btnNavStudent.Size = new System.Drawing.Size(200, 31);
            this.btnNavStudent.TabIndex = 24;
            this.btnNavStudent.Text = "Student";
            this.btnNavStudent.UseVisualStyleBackColor = false;
            this.btnNavStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // btnNavTaskType
            // 
            this.btnNavTaskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavTaskType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTaskType.FlatAppearance.BorderSize = 0;
            this.btnNavTaskType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTaskType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavTaskType.Location = new System.Drawing.Point(0, 270);
            this.btnNavTaskType.Name = "btnNavTaskType";
            this.btnNavTaskType.Size = new System.Drawing.Size(200, 31);
            this.btnNavTaskType.TabIndex = 23;
            this.btnNavTaskType.Text = "Task Type";
            this.btnNavTaskType.UseVisualStyleBackColor = false;
            this.btnNavTaskType.Click += new System.EventHandler(this.BtnNavTaskType_Click);
            // 
            // btnNavInspection
            // 
            this.btnNavInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavInspection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavInspection.FlatAppearance.BorderSize = 0;
            this.btnNavInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavInspection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavInspection.Location = new System.Drawing.Point(0, 239);
            this.btnNavInspection.Name = "btnNavInspection";
            this.btnNavInspection.Size = new System.Drawing.Size(200, 31);
            this.btnNavInspection.TabIndex = 21;
            this.btnNavInspection.Text = "Inspection";
            this.btnNavInspection.UseVisualStyleBackColor = false;
            this.btnNavInspection.Click += new System.EventHandler(this.BtnNavInspection_Click);
            // 
            // btnNavTutorRequest
            // 
            this.btnNavTutorRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavTutorRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTutorRequest.FlatAppearance.BorderSize = 0;
            this.btnNavTutorRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTutorRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavTutorRequest.Location = new System.Drawing.Point(0, 208);
            this.btnNavTutorRequest.Name = "btnNavTutorRequest";
            this.btnNavTutorRequest.Size = new System.Drawing.Size(200, 31);
            this.btnNavTutorRequest.TabIndex = 20;
            this.btnNavTutorRequest.Text = "Tutor Request";
            this.btnNavTutorRequest.UseVisualStyleBackColor = false;
            this.btnNavTutorRequest.Click += new System.EventHandler(this.BtnNavTutorRequest_Click);
            // 
            // btnNavRequest
            // 
            this.btnNavRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavRequest.FlatAppearance.BorderSize = 0;
            this.btnNavRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavRequest.Location = new System.Drawing.Point(0, 177);
            this.btnNavRequest.Name = "btnNavRequest";
            this.btnNavRequest.Size = new System.Drawing.Size(200, 31);
            this.btnNavRequest.TabIndex = 19;
            this.btnNavRequest.Text = "Request";
            this.btnNavRequest.UseVisualStyleBackColor = false;
            this.btnNavRequest.Click += new System.EventHandler(this.BtnNavRequest_Click);
            // 
            // btnNavDepartment
            // 
            this.btnNavDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDepartment.FlatAppearance.BorderSize = 0;
            this.btnNavDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDepartment.Location = new System.Drawing.Point(0, 146);
            this.btnNavDepartment.Name = "btnNavDepartment";
            this.btnNavDepartment.Size = new System.Drawing.Size(200, 31);
            this.btnNavDepartment.TabIndex = 18;
            this.btnNavDepartment.Text = "Department";
            this.btnNavDepartment.UseVisualStyleBackColor = false;
            this.btnNavDepartment.Click += new System.EventHandler(this.BtnNavDepartment_Click);
            // 
            // btnNavVenue
            // 
            this.btnNavVenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavVenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavVenue.FlatAppearance.BorderSize = 0;
            this.btnNavVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavVenue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavVenue.Location = new System.Drawing.Point(0, 115);
            this.btnNavVenue.Name = "btnNavVenue";
            this.btnNavVenue.Size = new System.Drawing.Size(200, 31);
            this.btnNavVenue.TabIndex = 16;
            this.btnNavVenue.Text = "Venue";
            this.btnNavVenue.UseVisualStyleBackColor = false;
            this.btnNavVenue.Click += new System.EventHandler(this.BtnNavVenue_Click);
            // 
            // btnNavEquipment
            // 
            this.btnNavEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavEquipment.FlatAppearance.BorderSize = 0;
            this.btnNavEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEquipment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavEquipment.Location = new System.Drawing.Point(0, 84);
            this.btnNavEquipment.Name = "btnNavEquipment";
            this.btnNavEquipment.Size = new System.Drawing.Size(200, 31);
            this.btnNavEquipment.TabIndex = 15;
            this.btnNavEquipment.Text = "Equipment";
            this.btnNavEquipment.UseVisualStyleBackColor = false;
            this.btnNavEquipment.Click += new System.EventHandler(this.BtnNavEquipment_Click);
            // 
            // btnNavHome
            // 
            this.btnNavHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNavHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavHome.FlatAppearance.BorderSize = 0;
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHome.Location = new System.Drawing.Point(0, 53);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(200, 31);
            this.btnNavHome.TabIndex = 6;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = false;
            this.btnNavHome.Click += new System.EventHandler(this.BtnNavHome_Click);
            // 
            // btnNavigation
            // 
            this.btnNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.btnNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavigation.FlatAppearance.BorderSize = 0;
            this.btnNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavigation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavigation.Location = new System.Drawing.Point(0, 0);
            this.btnNavigation.MinimumSize = new System.Drawing.Size(180, 53);
            this.btnNavigation.Name = "btnNavigation";
            this.btnNavigation.Size = new System.Drawing.Size(200, 53);
            this.btnNavigation.TabIndex = 5;
            this.btnNavigation.Text = "Navigation";
            this.btnNavigation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNavigation.UseVisualStyleBackColor = false;
            this.btnNavigation.Click += new System.EventHandler(this.BtnNavigation_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 109);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.Logo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "@";
            this.label1.Click += new System.EventHandler(this.Logo_Click);
            // 
            // btnNavHelp
            // 
            this.btnNavHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.btnNavHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNavHelp.FlatAppearance.BorderSize = 0;
            this.btnNavHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHelp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHelp.ForeColor = System.Drawing.Color.White;
            this.btnNavHelp.Location = new System.Drawing.Point(0, 578);
            this.btnNavHelp.Name = "btnNavHelp";
            this.btnNavHelp.Size = new System.Drawing.Size(200, 42);
            this.btnNavHelp.TabIndex = 5;
            this.btnNavHelp.Text = "Help";
            this.btnNavHelp.UseVisualStyleBackColor = false;
            this.btnNavHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // tmrNavigation
            // 
            this.tmrNavigation.Tick += new System.EventHandler(this.TmrNavigation_Tick);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlLoginFields);
            this.pnlContent.Controls.Add(this.ucErrorFailedToAdd1);
            this.pnlContent.Controls.Add(this.ucErrorUserNotFound1);
            this.pnlContent.Controls.Add(this.ucErrorStaffNotFound1);
            this.pnlContent.Controls.Add(this.ucErrorVenueNotFound1);
            this.pnlContent.Controls.Add(this.ucErrorStudentNotFound1);
            this.pnlContent.Controls.Add(this.ucUser1);
            this.pnlContent.Controls.Add(this.ucStudent1);
            this.pnlContent.Controls.Add(this.ucStaff1);
            this.pnlContent.Controls.Add(this.ucHelp1);
            this.pnlContent.Controls.Add(this.ucTaskType1);
            this.pnlContent.Controls.Add(this.ucNavInspection1);
            this.pnlContent.Controls.Add(this.ucTutorRequest1);
            this.pnlContent.Controls.Add(this.ucRequest1);
            this.pnlContent.Controls.Add(this.doubleBitmapControl1);
            this.pnlContent.Controls.Add(this.ucVenue1);
            this.pnlContent.Controls.Add(this.ucHome1);
            this.pnlContent.Controls.Add(this.ucEquipment1);
            this.pnlContent.Controls.Add(this.ucDepartment1);
            this.pnlContent.Controls.Add(this.panel6);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1056, 620);
            this.pnlContent.TabIndex = 3;
            // 
            // pnlLoginFields
            // 
            this.pnlLoginFields.Controls.Add(this.label3);
            this.pnlLoginFields.Controls.Add(this.btnLogIn);
            this.pnlLoginFields.Controls.Add(this.txtPassword);
            this.pnlLoginFields.Controls.Add(this.txtUsername);
            this.pnlLoginFields.Controls.Add(this.label2);
            this.pnlLoginFields.Location = new System.Drawing.Point(0, 58);
            this.pnlLoginFields.Name = "pnlLoginFields";
            this.pnlLoginFields.Size = new System.Drawing.Size(1056, 562);
            this.pnlLoginFields.TabIndex = 18;
            // 
            // btnLogIn
            // 
            this.btnLogIn.ActiveBorderThickness = 1;
            this.btnLogIn.ActiveCornerRadius = 20;
            this.btnLogIn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLogIn.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogIn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogIn.BackgroundImage")));
            this.btnLogIn.ButtonText = "Log In";
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLogIn.IdleBorderThickness = 1;
            this.btnLogIn.IdleCornerRadius = 20;
            this.btnLogIn.IdleFillColor = System.Drawing.Color.White;
            this.btnLogIn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLogIn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLogIn.Location = new System.Drawing.Point(427, 333);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(181, 41);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(333, 252);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(370, 44);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "Username";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(333, 200);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(370, 44);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log In";
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(252, 192);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 5;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panel6.Controls.Add(this.lblDisplayName);
            this.panel6.Controls.Add(this.pnlLogin);
            this.panel6.Controls.Add(this.lblLocation);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1056, 63);
            this.panel6.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.pnlLogin.Controls.Add(this.lblLoginText);
            this.pnlLogin.Location = new System.Drawing.Point(861, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(195, 29);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.Click += new System.EventHandler(this.Login_Click);
            this.pnlLogin.MouseEnter += new System.EventHandler(this.PnlLogin_MouseEnter);
            this.pnlLogin.MouseLeave += new System.EventHandler(this.PnlLogin_MouseLeave);
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginText.ForeColor = System.Drawing.Color.White;
            this.lblLoginText.Location = new System.Drawing.Point(50, -2);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(114, 30);
            this.lblLoginText.TabIndex = 0;
            this.lblLoginText.Text = "Log In Text";
            this.lblLoginText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginText.Click += new System.EventHandler(this.Login_Click);
            this.lblLoginText.MouseEnter += new System.EventHandler(this.LblLoginText_MouseEnter);
            this.lblLoginText.MouseLeave += new System.EventHandler(this.LblLoginText_MouseLeave);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(6, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(144, 45);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1056, 30);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(761, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 139);
            this.label3.TabIndex = 8;
            this.label3.Text = "FOR TESTING: Username: admin Password: admin";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.White;
            this.lblDisplayName.Location = new System.Drawing.Point(677, 0);
            this.lblDisplayName.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(151, 30);
            this.lblDisplayName.TabIndex = 2;
            this.lblDisplayName.Text = "Last, First(Role)";
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucErrorFailedToAdd1
            // 
            this.ucErrorFailedToAdd1._Data = null;
            this.ucErrorFailedToAdd1.Location = new System.Drawing.Point(0, 58);
            this.ucErrorFailedToAdd1.Name = "ucErrorFailedToAdd1";
            this.ucErrorFailedToAdd1.Size = new System.Drawing.Size(1056, 562);
            this.ucErrorFailedToAdd1.TabIndex = 17;
            // 
            // ucErrorUserNotFound1
            // 
            this.ucErrorUserNotFound1.Location = new System.Drawing.Point(0, 58);
            this.ucErrorUserNotFound1.Name = "ucErrorUserNotFound1";
            this.ucErrorUserNotFound1.Size = new System.Drawing.Size(1056, 562);
            this.ucErrorUserNotFound1.TabIndex = 16;
            // 
            // ucErrorStaffNotFound1
            // 
            this.ucErrorStaffNotFound1.Location = new System.Drawing.Point(0, 58);
            this.ucErrorStaffNotFound1.Name = "ucErrorStaffNotFound1";
            this.ucErrorStaffNotFound1.Size = new System.Drawing.Size(1056, 562);
            this.ucErrorStaffNotFound1.TabIndex = 15;
            // 
            // ucErrorVenueNotFound1
            // 
            this.ucErrorVenueNotFound1.Location = new System.Drawing.Point(0, 57);
            this.ucErrorVenueNotFound1.Name = "ucErrorVenueNotFound1";
            this.ucErrorVenueNotFound1.Size = new System.Drawing.Size(1056, 562);
            this.ucErrorVenueNotFound1.TabIndex = 14;
            // 
            // ucErrorStudentNotFound1
            // 
            this.ucErrorStudentNotFound1.Location = new System.Drawing.Point(0, 57);
            this.ucErrorStudentNotFound1.Name = "ucErrorStudentNotFound1";
            this.ucErrorStudentNotFound1.Size = new System.Drawing.Size(1056, 562);
            this.ucErrorStudentNotFound1.TabIndex = 13;
            // 
            // ucUser1
            // 
            this.ucUser1.Location = new System.Drawing.Point(0, 58);
            this.ucUser1.Name = "ucUser1";
            this.ucUser1.Size = new System.Drawing.Size(1056, 562);
            this.ucUser1.TabIndex = 0;
            // 
            // ucStudent1
            // 
            this.ucStudent1.Location = new System.Drawing.Point(0, 58);
            this.ucStudent1.Name = "ucStudent1";
            this.ucStudent1.Size = new System.Drawing.Size(1056, 562);
            this.ucStudent1.TabIndex = 12;
            // 
            // ucStaff1
            // 
            this.ucStaff1.Location = new System.Drawing.Point(0, 58);
            this.ucStaff1.Name = "ucStaff1";
            this.ucStaff1.Size = new System.Drawing.Size(1056, 562);
            this.ucStaff1.TabIndex = 11;
            // 
            // ucHelp1
            // 
            this.ucHelp1.Location = new System.Drawing.Point(0, 58);
            this.ucHelp1.Name = "ucHelp1";
            this.ucHelp1.Size = new System.Drawing.Size(1056, 562);
            this.ucHelp1.TabIndex = 10;
            // 
            // ucTaskType1
            // 
            this.ucTaskType1.Location = new System.Drawing.Point(0, 58);
            this.ucTaskType1.Name = "ucTaskType1";
            this.ucTaskType1.Size = new System.Drawing.Size(1056, 562);
            this.ucTaskType1.TabIndex = 9;
            // 
            // ucNavInspection1
            // 
            this.ucNavInspection1.Location = new System.Drawing.Point(0, 58);
            this.ucNavInspection1.Name = "ucNavInspection1";
            this.ucNavInspection1.Size = new System.Drawing.Size(1056, 562);
            this.ucNavInspection1.TabIndex = 8;
            // 
            // ucTutorRequest1
            // 
            this.ucTutorRequest1.Location = new System.Drawing.Point(0, 58);
            this.ucTutorRequest1.Name = "ucTutorRequest1";
            this.ucTutorRequest1.Size = new System.Drawing.Size(1056, 562);
            this.ucTutorRequest1.TabIndex = 7;
            // 
            // ucRequest1
            // 
            this.ucRequest1.Location = new System.Drawing.Point(0, 58);
            this.ucRequest1.Name = "ucRequest1";
            this.ucRequest1.Size = new System.Drawing.Size(1056, 562);
            this.ucRequest1.TabIndex = 6;
            // 
            // ucVenue1
            // 
            this.ucVenue1.Location = new System.Drawing.Point(0, 58);
            this.ucVenue1.Name = "ucVenue1";
            this.ucVenue1.Size = new System.Drawing.Size(1056, 562);
            this.ucVenue1.TabIndex = 4;
            // 
            // ucHome1
            // 
            this.ucHome1.Location = new System.Drawing.Point(0, 58);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1056, 562);
            this.ucHome1.TabIndex = 3;
            // 
            // ucEquipment1
            // 
            this.ucEquipment1.Location = new System.Drawing.Point(0, 58);
            this.ucEquipment1.Name = "ucEquipment1";
            this.ucEquipment1.Size = new System.Drawing.Size(1056, 562);
            this.ucEquipment1.TabIndex = 2;
            // 
            // ucDepartment1
            // 
            this.ucDepartment1.Location = new System.Drawing.Point(0, 58);
            this.ucDepartment1.Name = "ucDepartment1";
            this.ucDepartment1.Size = new System.Drawing.Size(1056, 562);
            this.ucDepartment1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 620);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1272, 659);
            this.MinimumSize = new System.Drawing.Size(1272, 659);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template";
            this.Load += new System.EventHandler(this.Template_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlLoginFields.ResumeLayout(false);
            this.pnlLoginFields.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnNavHelp;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel pnlNavigation;
		private System.Windows.Forms.Button btnNavTaskType;
		private System.Windows.Forms.Button btnNavInspection;
		private System.Windows.Forms.Button btnNavTutorRequest;
		private System.Windows.Forms.Button btnNavRequest;
		private System.Windows.Forms.Button btnNavDepartment;
		private System.Windows.Forms.Button btnNavVenue;
		private System.Windows.Forms.Button btnNavEquipment;
		private System.Windows.Forms.Button btnNavHome;
		private System.Windows.Forms.Button btnNavigation;
		private System.Windows.Forms.Timer tmrNavigation;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Panel pnlLogin;
		private System.Windows.Forms.Label lblLoginText;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lblLocation;
		private UserControls.ucDepartment ucDepartment1;
		private UserControls.ucVenue ucVenue1;
		private UserControls.ucHome ucHome1;
		private UserControls.UcEquipment ucEquipment1;
		private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
		private UserControls.ucRequest ucRequest1;
		private UserControls.ucTutorRequest ucTutorRequest1;
		private UserControls.ucInspection ucNavInspection1;
		private UserControls.ucTaskType ucTaskType1;
		private UserControls.ucHelp ucHelp1;
		private UserControls.ucStaff ucStaff1;
		private UserControls.ucStudent ucStudent1;
		private System.Windows.Forms.Button btnNavStudent;
		private System.Windows.Forms.Button btnNavStaff;
		private System.Windows.Forms.Button btnNavUser;
		private UserControls.ucUser ucUser1;
		private System.Windows.Forms.Panel pnlLoginFields;
		private Bunifu.Framework.UI.BunifuThinButton2 btnLogIn;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
		private System.Windows.Forms.Label label2;
		private Errors.ucErrorFailedToAdd ucErrorFailedToAdd1;
		private Errors.ucErrorUserNotFound ucErrorUserNotFound1;
		private Errors.ucErrorStaffNotFound ucErrorStaffNotFound1;
		private Errors.ucErrorVenueNotFound ucErrorVenueNotFound1;
		private Errors.ucErrorStudentNotFound ucErrorStudentNotFound1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisplayName;
    }
}