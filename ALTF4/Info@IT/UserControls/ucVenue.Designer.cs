namespace Info_IT.UserControls
{
	partial class ucVenue
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tmrView = new System.Windows.Forms.Timer(this.components);
			this.btnManageUpdate = new System.Windows.Forms.Button();
			this.btnManageAdd = new System.Windows.Forms.Button();
			this.btnManage = new System.Windows.Forms.Button();
			this.pnlManage = new System.Windows.Forms.Panel();
			this.tmrManage = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvVenue = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbBuildingBlock = new System.Windows.Forms.ComboBox();
			this.txtDoorNo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCapacity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbBuilding = new System.Windows.Forms.ComboBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnManageDelete = new System.Windows.Forms.Button();
			this.pnlManage.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVenue)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrView
			// 
			this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
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
			this.btnManageUpdate.Text = "Update Selected Venue";
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
			this.btnManageAdd.Text = "Add Venue";
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
			this.pnlManage.Controls.Add(this.btnManageDelete);
			this.pnlManage.Controls.Add(this.btnManageUpdate);
			this.pnlManage.Controls.Add(this.btnManageAdd);
			this.pnlManage.Controls.Add(this.btnManage);
			this.pnlManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlManage.Location = new System.Drawing.Point(0, 0);
			this.pnlManage.MaximumSize = new System.Drawing.Size(200, 148);
			this.pnlManage.MinimumSize = new System.Drawing.Size(200, 53);
			this.pnlManage.Name = "pnlManage";
			this.pnlManage.Size = new System.Drawing.Size(200, 53);
			this.pnlManage.TabIndex = 12;
			// 
			// tmrManage
			// 
			this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.pnlManage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 562);
			this.panel1.TabIndex = 12;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvVenue);
			this.panel3.Location = new System.Drawing.Point(234, 100);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 426);
			this.panel3.TabIndex = 11;
			// 
			// dgvVenue
			// 
			this.dgvVenue.AllowUserToAddRows = false;
			this.dgvVenue.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvVenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvVenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVenue.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvVenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvVenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvVenue.ColumnHeadersHeight = 50;
			this.dgvVenue.DoubleBuffered = true;
			this.dgvVenue.EnableHeadersVisualStyles = false;
			this.dgvVenue.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvVenue.HeaderForeColor = System.Drawing.Color.White;
			this.dgvVenue.Location = new System.Drawing.Point(0, -1);
			this.dgvVenue.Name = "dgvVenue";
			this.dgvVenue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvVenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvVenue.Size = new System.Drawing.Size(782, 429);
			this.dgvVenue.TabIndex = 1;
			this.dgvVenue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenue_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cmbBuildingBlock);
			this.groupBox1.Controls.Add(this.txtDoorNo);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCapacity);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbBuilding);
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(234, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(782, 71);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label6.Location = new System.Drawing.Point(594, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Building:";
			// 
			// cmbBuildingBlock
			// 
			this.cmbBuildingBlock.FormattingEnabled = true;
			this.cmbBuildingBlock.Location = new System.Drawing.Point(473, 35);
			this.cmbBuildingBlock.Name = "cmbBuildingBlock";
			this.cmbBuildingBlock.Size = new System.Drawing.Size(118, 23);
			this.cmbBuildingBlock.TabIndex = 10;
			// 
			// txtDoorNo
			// 
			this.txtDoorNo.Location = new System.Drawing.Point(342, 35);
			this.txtDoorNo.Name = "txtDoorNo";
			this.txtDoorNo.Size = new System.Drawing.Size(125, 23);
			this.txtDoorNo.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label5.Location = new System.Drawing.Point(339, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Door Number:";
			// 
			// txtCapacity
			// 
			this.txtCapacity.Location = new System.Drawing.Point(208, 35);
			this.txtCapacity.Name = "txtCapacity";
			this.txtCapacity.Size = new System.Drawing.Size(128, 23);
			this.txtCapacity.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label4.Location = new System.Drawing.Point(473, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Building Block:";
			// 
			// cmbBuilding
			// 
			this.cmbBuilding.FormattingEnabled = true;
			this.cmbBuilding.Location = new System.Drawing.Point(597, 35);
			this.cmbBuilding.Name = "cmbBuilding";
			this.cmbBuilding.Size = new System.Drawing.Size(144, 23);
			this.cmbBuilding.TabIndex = 4;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(15, 35);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(187, 23);
			this.txtDescription.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label3.Location = new System.Drawing.Point(205, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Capacity:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description:";
			// 
			// btnManageDelete
			// 
			this.btnManageDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnManageDelete.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageDelete.FlatAppearance.BorderSize = 0;
			this.btnManageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageDelete.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnManageDelete.Location = new System.Drawing.Point(0, 115);
			this.btnManageDelete.Name = "btnManageDelete";
			this.btnManageDelete.Size = new System.Drawing.Size(200, 31);
			this.btnManageDelete.TabIndex = 8;
			this.btnManageDelete.Text = "Delete Selected Venue";
			this.btnManageDelete.UseVisualStyleBackColor = false;
			this.btnManageDelete.Click += new System.EventHandler(this.BtnManageDelete_Click);
			// 
			// ucVenue
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "ucVenue";
			this.Size = new System.Drawing.Size(1056, 562);
			this.Load += new System.EventHandler(this.UcVenue_Load);
			this.pnlManage.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVenue)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbBuildingBlock;
		private System.Windows.Forms.TextBox txtDoorNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCapacity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbBuilding;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvVenue;
		private System.Windows.Forms.Button btnManageDelete;
	}
}
