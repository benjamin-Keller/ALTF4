namespace Info_IT
{
    partial class EquipmentType
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrView = new System.Windows.Forms.Timer(this.components);
            this.tmrNavigation = new System.Windows.Forms.Timer(this.components);
            this.tmrManage = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvEquipType = new System.Windows.Forms.DataGridView();
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
            this.btnNavRequest = new System.Windows.Forms.Button();
            this.btnNavDepartment = new System.Windows.Forms.Button();
            this.btnNavVenue = new System.Windows.Forms.Button();
            this.btnNavEquipment = new System.Windows.Forms.Button();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.btnNavigation = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipType)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlManage.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(186, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 35);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(187, 20);
            this.txtDescription.TabIndex = 3;
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
            // tmrView
            // 
            this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
            // 
            // tmrNavigation
            // 
            this.tmrNavigation.Tick += new System.EventHandler(this.TmrNavigation_Tick);
            // 
            // tmrManage
            // 
            this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvEquipType);
            this.panel3.Location = new System.Drawing.Point(188, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 349);
            this.panel3.TabIndex = 12;
            // 
            // dgvEquipType
            // 
            this.dgvEquipType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dgvEquipType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipType.Location = new System.Drawing.Point(4, 3);
            this.dgvEquipType.Name = "dgvEquipType";
            this.dgvEquipType.Size = new System.Drawing.Size(598, 328);
            this.dgvEquipType.TabIndex = 6;
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
            this.panel1.TabIndex = 13;
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
            this.btnViewList.Text = "List All Equipment Type";
            this.btnViewList.UseVisualStyleBackColor = false;
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
            this.btnView.MouseEnter += new System.EventHandler(this.BtnView_MouseEnter);
            this.btnView.MouseLeave += new System.EventHandler(this.BtnView_MouseLeave);
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
            this.btnManageUpdate.Text = "Update Selected Equipment Type";
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
            this.btnManageAdd.Text = "Add Equipment Type";
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
            this.btnManage.MouseEnter += new System.EventHandler(this.BtnManage_MouseEnter);
            this.btnManage.MouseLeave += new System.EventHandler(this.BtnManage_MouseLeave);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnNavTaskType);
            this.pnlNavigation.Controls.Add(this.btnNavInspectionDetail);
            this.pnlNavigation.Controls.Add(this.btnNavInspection);
            this.pnlNavigation.Controls.Add(this.btnNavTutorRequest);
            this.pnlNavigation.Controls.Add(this.btnNavRequest);
            this.pnlNavigation.Controls.Add(this.btnNavDepartment);
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
            // btnNavRequest
            // 
            this.btnNavRequest.BackColor = System.Drawing.Color.Teal;
            this.btnNavRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavRequest.FlatAppearance.BorderSize = 0;
            this.btnNavRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRequest.Location = new System.Drawing.Point(0, 177);
            this.btnNavRequest.Name = "btnNavRequest";
            this.btnNavRequest.Size = new System.Drawing.Size(180, 31);
            this.btnNavRequest.TabIndex = 19;
            this.btnNavRequest.Text = "Request";
            this.btnNavRequest.UseVisualStyleBackColor = false;
            this.btnNavRequest.Click += new System.EventHandler(this.BtnNavRequest_Click);
            // 
            // btnNavDepartment
            // 
            this.btnNavDepartment.BackColor = System.Drawing.Color.Teal;
            this.btnNavDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDepartment.FlatAppearance.BorderSize = 0;
            this.btnNavDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDepartment.Location = new System.Drawing.Point(0, 146);
            this.btnNavDepartment.Name = "btnNavDepartment";
            this.btnNavDepartment.Size = new System.Drawing.Size(180, 31);
            this.btnNavDepartment.TabIndex = 18;
            this.btnNavDepartment.Text = "Department";
            this.btnNavDepartment.UseVisualStyleBackColor = false;
            this.btnNavDepartment.Click += new System.EventHandler(this.BtnNavDepartment_Click);
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
            this.btnNavigation.MouseEnter += new System.EventHandler(this.BtnNavigation_MouseEnter);
            this.btnNavigation.MouseLeave += new System.EventHandler(this.BtnNavigation_MouseLeave);
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
            // EquipmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EquipmentType";
            this.Text = "Equipment Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EquipmentType_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.pnlManage.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.Timer tmrNavigation;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dgvEquipType;
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
		private System.Windows.Forms.Button btnNavRequest;
		private System.Windows.Forms.Button btnNavDepartment;
		private System.Windows.Forms.Button btnNavVenue;
		private System.Windows.Forms.Button btnNavEquipment;
		private System.Windows.Forms.Button btnNavHome;
		private System.Windows.Forms.Button btnNavigation;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
	}
}