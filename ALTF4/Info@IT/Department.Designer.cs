namespace Info_IT
{
    partial class Department
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvDepartment = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtContactNum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtContactPerson = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBuilding = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateSelectedDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listAllDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvDepartment);
			this.groupBox2.Location = new System.Drawing.Point(403, 37);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(375, 411);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Displaying information";
			// 
			// dgvDepartment
			// 
			this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDepartment.Location = new System.Drawing.Point(6, 78);
			this.dgvDepartment.Name = "dgvDepartment";
			this.dgvDepartment.Size = new System.Drawing.Size(363, 259);
			this.dgvDepartment.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtContactNum);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtContactPerson);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtBuilding);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(23, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(375, 411);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// txtContactNum
			// 
			this.txtContactNum.Location = new System.Drawing.Point(162, 219);
			this.txtContactNum.Name = "txtContactNum";
			this.txtContactNum.Size = new System.Drawing.Size(187, 20);
			this.txtContactNum.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Contact Number:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(162, 252);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(187, 20);
			this.txtEmail.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(33, 255);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "Email Address:";
			// 
			// txtContactPerson
			// 
			this.txtContactPerson.Location = new System.Drawing.Point(162, 186);
			this.txtContactPerson.Name = "txtContactPerson";
			this.txtContactPerson.Size = new System.Drawing.Size(187, 20);
			this.txtContactPerson.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "Contact Person:";
			// 
			// txtBuilding
			// 
			this.txtBuilding.Location = new System.Drawing.Point(162, 153);
			this.txtBuilding.Name = "txtBuilding";
			this.txtBuilding.Size = new System.Drawing.Size(187, 20);
			this.txtBuilding.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Building:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(162, 120);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(187, 20);
			this.txtName.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Name:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 17;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.testToolStripMenuItem.Text = "Navigation";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.exitToolStripMenuItem.Text = "Home";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// manageToolStripMenuItem
			// 
			this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem,
            this.updateSelectedDepartmentToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.manageToolStripMenuItem.Text = "Manage";
			// 
			// addDepartmentToolStripMenuItem
			// 
			this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
			this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
			this.addDepartmentToolStripMenuItem.Text = "Add Department";
			// 
			// updateSelectedDepartmentToolStripMenuItem
			// 
			this.updateSelectedDepartmentToolStripMenuItem.Name = "updateSelectedDepartmentToolStripMenuItem";
			this.updateSelectedDepartmentToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
			this.updateSelectedDepartmentToolStripMenuItem.Text = "Update Selected Department";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllDepartmentsToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// listAllDepartmentsToolStripMenuItem
			// 
			this.listAllDepartmentsToolStripMenuItem.Name = "listAllDepartmentsToolStripMenuItem";
			this.listAllDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.listAllDepartmentsToolStripMenuItem.Text = "List All Departments";
			// 
			// Department
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Department";
			this.Text = "Department";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Department_FormClosing);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSelectedDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllDepartmentsToolStripMenuItem;
    }
}