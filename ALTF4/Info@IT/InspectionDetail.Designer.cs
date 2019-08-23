namespace Info_IT
{
    partial class InspectionDetail
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
			this.dgvInspectionDetail = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbEquipmentCode = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFaultCom = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbStaffCode = new System.Windows.Forms.ComboBox();
			this.cmbInspectionCode = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addInspectionDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateInspectionDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listAllInspectionDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listInspectionDetailByVenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInspectionDetail)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvInspectionDetail);
			this.groupBox2.Location = new System.Drawing.Point(403, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(375, 411);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Displaying information";
			// 
			// dgvInspectionDetail
			// 
			this.dgvInspectionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInspectionDetail.Location = new System.Drawing.Point(6, 78);
			this.dgvInspectionDetail.Name = "dgvInspectionDetail";
			this.dgvInspectionDetail.Size = new System.Drawing.Size(363, 259);
			this.dgvInspectionDetail.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbStatus);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbEquipmentCode);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtFaultCom);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbStaffCode);
			this.groupBox1.Controls.Add(this.cmbInspectionCode);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(23, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(375, 411);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// cmbStatus
			// 
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(162, 255);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(187, 21);
			this.cmbStatus.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 258);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Status:";
			// 
			// cmbEquipmentCode
			// 
			this.cmbEquipmentCode.FormattingEnabled = true;
			this.cmbEquipmentCode.Location = new System.Drawing.Point(162, 154);
			this.cmbEquipmentCode.Name = "cmbEquipmentCode";
			this.cmbEquipmentCode.Size = new System.Drawing.Size(187, 21);
			this.cmbEquipmentCode.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(31, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Equipment Code:";
			// 
			// txtFaultCom
			// 
			this.txtFaultCom.Location = new System.Drawing.Point(162, 222);
			this.txtFaultCom.Name = "txtFaultCom";
			this.txtFaultCom.Size = new System.Drawing.Size(187, 20);
			this.txtFaultCom.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Fault Comment:";
			// 
			// cmbStaffCode
			// 
			this.cmbStaffCode.FormattingEnabled = true;
			this.cmbStaffCode.Location = new System.Drawing.Point(162, 188);
			this.cmbStaffCode.Name = "cmbStaffCode";
			this.cmbStaffCode.Size = new System.Drawing.Size(187, 21);
			this.cmbStaffCode.TabIndex = 5;
			// 
			// cmbInspectionCode
			// 
			this.cmbInspectionCode.FormattingEnabled = true;
			this.cmbInspectionCode.Location = new System.Drawing.Point(162, 120);
			this.cmbInspectionCode.Name = "cmbInspectionCode";
			this.cmbInspectionCode.Size = new System.Drawing.Size(187, 21);
			this.cmbInspectionCode.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Staff Code:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Inspection Code:";
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
			this.menuStrip1.TabIndex = 11;
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
            this.addInspectionDetailToolStripMenuItem,
            this.updateInspectionDetailToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.manageToolStripMenuItem.Text = "Manage";
			// 
			// addInspectionDetailToolStripMenuItem
			// 
			this.addInspectionDetailToolStripMenuItem.Name = "addInspectionDetailToolStripMenuItem";
			this.addInspectionDetailToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.addInspectionDetailToolStripMenuItem.Text = "Add Inspection Detail";
			// 
			// updateInspectionDetailToolStripMenuItem
			// 
			this.updateInspectionDetailToolStripMenuItem.Name = "updateInspectionDetailToolStripMenuItem";
			this.updateInspectionDetailToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.updateInspectionDetailToolStripMenuItem.Text = "Update Selected Inspection Detail";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllInspectionDetailToolStripMenuItem,
            this.listInspectionDetailByVenueToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// listAllInspectionDetailToolStripMenuItem
			// 
			this.listAllInspectionDetailToolStripMenuItem.Name = "listAllInspectionDetailToolStripMenuItem";
			this.listAllInspectionDetailToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
			this.listAllInspectionDetailToolStripMenuItem.Text = "List All Inspection Detail";
			// 
			// listInspectionDetailByVenueToolStripMenuItem
			// 
			this.listInspectionDetailByVenueToolStripMenuItem.Name = "listInspectionDetailByVenueToolStripMenuItem";
			this.listInspectionDetailByVenueToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
			this.listInspectionDetailByVenueToolStripMenuItem.Text = "List Inspection Detail by Venue";
			// 
			// InspectionDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "InspectionDetail";
			this.Text = "InspectionDetail";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InspectionDetail_FormClosing);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvInspectionDetail)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvInspectionDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFaultCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStaffCode;
        private System.Windows.Forms.ComboBox cmbInspectionCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbEquipmentCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem addInspectionDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInspectionDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllInspectionDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listInspectionDetailByVenueToolStripMenuItem;
    }
}