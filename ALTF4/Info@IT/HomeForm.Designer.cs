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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pnlNavigation = new System.Windows.Forms.Panel();
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
			this.btnHelp = new System.Windows.Forms.Button();
			this.tmrNavigation = new System.Windows.Forms.Timer(this.components);
			this.pnlContent = new System.Windows.Forms.Panel();
			this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pnlLogin = new System.Windows.Forms.Panel();
			this.lblLoginText = new System.Windows.Forms.Label();
			this.lblLocation = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
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
			this.panel6.SuspendLayout();
			this.pnlLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.btnHelp);
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
			this.pnlNavigation.Location = new System.Drawing.Point(0, 100);
			this.pnlNavigation.MaximumSize = new System.Drawing.Size(200, 332);
			this.pnlNavigation.MinimumSize = new System.Drawing.Size(200, 53);
			this.pnlNavigation.Name = "pnlNavigation";
			this.pnlNavigation.Size = new System.Drawing.Size(200, 332);
			this.pnlNavigation.TabIndex = 9;
			// 
			// btnNavTaskType
			// 
			this.btnNavTaskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
			this.btnNavTaskType.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNavTaskType.FlatAppearance.BorderSize = 0;
			this.btnNavTaskType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
			this.panel4.Size = new System.Drawing.Size(200, 100);
			this.panel4.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 91);
			this.label1.TabIndex = 0;
			this.label1.Text = "@";
			// 
			// btnHelp
			// 
			this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
			this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnHelp.FlatAppearance.BorderSize = 0;
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHelp.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHelp.Location = new System.Drawing.Point(0, 578);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(200, 42);
			this.btnHelp.TabIndex = 5;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = false;
			// 
			// tmrNavigation
			// 
			this.tmrNavigation.Tick += new System.EventHandler(this.TmrNavigation_Tick);
			// 
			// pnlContent
			// 
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
			this.panel6.Controls.Add(this.pnlLogin);
			this.panel6.Controls.Add(this.lblLocation);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1056, 67);
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
			this.pnlLogin.Click += new System.EventHandler(this.PnlLogin_Click);
			this.pnlLogin.MouseEnter += new System.EventHandler(this.PnlLogin_MouseEnter);
			this.pnlLogin.MouseLeave += new System.EventHandler(this.PnlLogin_MouseLeave);
			// 
			// lblLoginText
			// 
			this.lblLoginText.AutoSize = true;
			this.lblLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoginText.Location = new System.Drawing.Point(70, 0);
			this.lblLoginText.Name = "lblLoginText";
			this.lblLoginText.Size = new System.Drawing.Size(70, 25);
			this.lblLoginText.TabIndex = 0;
			this.lblLoginText.Text = "label2";
			this.lblLoginText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblLoginText.Click += new System.EventHandler(this.LblLoginText_Click);
			this.lblLoginText.MouseEnter += new System.EventHandler(this.LblLoginText_MouseEnter);
			this.lblLoginText.MouseLeave += new System.EventHandler(this.LblLoginText_MouseLeave);
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocation.Location = new System.Drawing.Point(6, 9);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(146, 39);
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
			this.MinimumSize = new System.Drawing.Size(920, 532);
			this.Name = "Home";
			this.Text = "Template";
			this.Load += new System.EventHandler(this.Template_Load);
			this.Resize += new System.EventHandler(this.Template_Resize);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.pnlNavigation.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.pnlContent.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.pnlLogin.ResumeLayout(false);
			this.pnlLogin.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnHelp;
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
	}
}