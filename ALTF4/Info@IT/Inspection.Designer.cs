namespace Info_IT
{
    partial class Inspection
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scheduleOfInspectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvInspection = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbStaffCode = new System.Windows.Forms.ComboBox();
			this.cmbVenueCode = new System.Windows.Forms.ComboBox();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInspection)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
			this.menuStrip1.TabIndex = 8;
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
            this.addInspectionToolStripMenuItem,
            this.updateInspectionToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.manageToolStripMenuItem.Text = "Manage";
			// 
			// addInspectionToolStripMenuItem
			// 
			this.addInspectionToolStripMenuItem.Name = "addInspectionToolStripMenuItem";
			this.addInspectionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.addInspectionToolStripMenuItem.Text = "Add Inspection";
			// 
			// updateInspectionToolStripMenuItem
			// 
			this.updateInspectionToolStripMenuItem.Name = "updateInspectionToolStripMenuItem";
			this.updateInspectionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.updateInspectionToolStripMenuItem.Text = "Update Selected Inspection";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleOfInspectionsToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// scheduleOfInspectionsToolStripMenuItem
			// 
			this.scheduleOfInspectionsToolStripMenuItem.Name = "scheduleOfInspectionsToolStripMenuItem";
			this.scheduleOfInspectionsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.scheduleOfInspectionsToolStripMenuItem.Text = "Schedule of Inspections";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvInspection);
			this.groupBox2.Location = new System.Drawing.Point(403, 20);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(375, 411);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Displaying information";
			// 
			// dgvInspection
			// 
			this.dgvInspection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInspection.Location = new System.Drawing.Point(6, 78);
			this.dgvInspection.Name = "dgvInspection";
			this.dgvInspection.Size = new System.Drawing.Size(363, 259);
			this.dgvInspection.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtTime);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbStaffCode);
			this.groupBox1.Controls.Add(this.cmbVenueCode);
			this.groupBox1.Controls.Add(this.txtComment);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(23, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(375, 411);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(150, 116);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(187, 20);
			this.txtDate.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Date:";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(150, 149);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(187, 20);
			this.txtTime.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Time:";
			// 
			// cmbStaffCode
			// 
			this.cmbStaffCode.FormattingEnabled = true;
			this.cmbStaffCode.Location = new System.Drawing.Point(150, 249);
			this.cmbStaffCode.Name = "cmbStaffCode";
			this.cmbStaffCode.Size = new System.Drawing.Size(187, 21);
			this.cmbStaffCode.TabIndex = 5;
			// 
			// cmbVenueCode
			// 
			this.cmbVenueCode.FormattingEnabled = true;
			this.cmbVenueCode.Location = new System.Drawing.Point(150, 215);
			this.cmbVenueCode.Name = "cmbVenueCode";
			this.cmbVenueCode.Size = new System.Drawing.Size(187, 21);
			this.cmbVenueCode.TabIndex = 4;
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(150, 182);
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(187, 20);
			this.txtComment.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 253);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Staff Code:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Venue Code:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Comment:";
			// 
			// Inspection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Inspection";
			this.Text = "Inspection";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inspection_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvInspection)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvInspection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStaffCode;
        private System.Windows.Forms.ComboBox cmbVenueCode;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem addInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleOfInspectionsToolStripMenuItem;
    }
}