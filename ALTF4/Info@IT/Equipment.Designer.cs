namespace Info_IT
{
    partial class Equipment
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
			this.dgvEquipment = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbVenue = new System.Windows.Forms.ComboBox();
			this.cmbEquipTypeCode = new System.Windows.Forms.ComboBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listAllEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listEquipmentByTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvEquipment);
			this.groupBox2.Location = new System.Drawing.Point(403, 20);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(375, 411);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Displaying information";
			// 
			// dgvEquipment
			// 
			this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEquipment.Location = new System.Drawing.Point(6, 78);
			this.dgvEquipment.Name = "dgvEquipment";
			this.dgvEquipment.Size = new System.Drawing.Size(363, 259);
			this.dgvEquipment.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbVenue);
			this.groupBox1.Controls.Add(this.cmbEquipTypeCode);
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(23, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(375, 411);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 226);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Equipment Type Code:";
			// 
			// cmbVenue
			// 
			this.cmbVenue.FormattingEnabled = true;
			this.cmbVenue.Location = new System.Drawing.Point(169, 188);
			this.cmbVenue.Name = "cmbVenue";
			this.cmbVenue.Size = new System.Drawing.Size(187, 21);
			this.cmbVenue.TabIndex = 5;
			// 
			// cmbEquipTypeCode
			// 
			this.cmbEquipTypeCode.FormattingEnabled = true;
			this.cmbEquipTypeCode.Location = new System.Drawing.Point(169, 222);
			this.cmbEquipTypeCode.Name = "cmbEquipTypeCode";
			this.cmbEquipTypeCode.Size = new System.Drawing.Size(187, 21);
			this.cmbEquipTypeCode.TabIndex = 4;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(169, 155);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(187, 20);
			this.txtDescription.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Venue Code:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 158);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description:";
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
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllEquipmentToolStripMenuItem,
            this.listEquipmentByTypeToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// listAllEquipmentToolStripMenuItem
			// 
			this.listAllEquipmentToolStripMenuItem.Name = "listAllEquipmentToolStripMenuItem";
			this.listAllEquipmentToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.listAllEquipmentToolStripMenuItem.Text = "List All Equipment";
			// 
			// listEquipmentByTypeToolStripMenuItem
			// 
			this.listEquipmentByTypeToolStripMenuItem.Name = "listEquipmentByTypeToolStripMenuItem";
			this.listEquipmentByTypeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.listEquipmentByTypeToolStripMenuItem.Text = "List Equipment by Type";
			// 
			// manageToolStripMenuItem
			// 
			this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEquipmentToolStripMenuItem,
            this.updateEquipmentToolStripMenuItem,
            this.deleteEquipmentToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.manageToolStripMenuItem.Text = "Manage";
			// 
			// addEquipmentToolStripMenuItem
			// 
			this.addEquipmentToolStripMenuItem.Name = "addEquipmentToolStripMenuItem";
			this.addEquipmentToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.addEquipmentToolStripMenuItem.Text = "Add Equipment";
			// 
			// updateEquipmentToolStripMenuItem
			// 
			this.updateEquipmentToolStripMenuItem.Name = "updateEquipmentToolStripMenuItem";
			this.updateEquipmentToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.updateEquipmentToolStripMenuItem.Text = "Update Selected Equipment";
			// 
			// deleteEquipmentToolStripMenuItem
			// 
			this.deleteEquipmentToolStripMenuItem.Name = "deleteEquipmentToolStripMenuItem";
			this.deleteEquipmentToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.deleteEquipmentToolStripMenuItem.Text = "Delete Selected Equipment";
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
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Equipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Equipment";
			this.Text = "Equipment";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Equipment_FormClosing);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVenue;
        private System.Windows.Forms.ComboBox cmbEquipTypeCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listAllEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEquipmentByTypeToolStripMenuItem;
    }
}