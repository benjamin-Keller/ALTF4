﻿namespace Info_IT.UserControls
{
	partial class ucInspectionDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEquipmentCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInspectionCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFaultComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStaffCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvInspectionDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnCloseDetails = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.btnViewList = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlManage = new System.Windows.Forms.Panel();
            this.btnManageUpdate = new System.Windows.Forms.Button();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.tmrView = new System.Windows.Forms.Timer(this.components);
            this.tmrManage = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectionDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEquipmentCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbInspectionCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFaultComment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbStaffCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(234, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 71);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "In-Progress",
            "Completed",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(625, 36);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(116, 23);
            this.cmbStatus.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(625, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Status:";
            // 
            // cmbEquipmentCode
            // 
            this.cmbEquipmentCode.FormattingEnabled = true;
            this.cmbEquipmentCode.Location = new System.Drawing.Point(137, 36);
            this.cmbEquipmentCode.Name = "cmbEquipmentCode";
            this.cmbEquipmentCode.Size = new System.Drawing.Size(116, 23);
            this.cmbEquipmentCode.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(134, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Equipment Code:";
            // 
            // cmbInspectionCode
            // 
            this.cmbInspectionCode.FormattingEnabled = true;
            this.cmbInspectionCode.Location = new System.Drawing.Point(15, 36);
            this.cmbInspectionCode.Name = "cmbInspectionCode";
            this.cmbInspectionCode.Size = new System.Drawing.Size(116, 23);
            this.cmbInspectionCode.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Inspection Code:";
            // 
            // txtFaultComment
            // 
            this.txtFaultComment.Location = new System.Drawing.Point(381, 36);
            this.txtFaultComment.Name = "txtFaultComment";
            this.txtFaultComment.Size = new System.Drawing.Size(238, 23);
            this.txtFaultComment.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(378, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fault Comment:";
            // 
            // cmbStaffCode
            // 
            this.cmbStaffCode.FormattingEnabled = true;
            this.cmbStaffCode.Location = new System.Drawing.Point(259, 36);
            this.cmbStaffCode.Name = "cmbStaffCode";
            this.cmbStaffCode.Size = new System.Drawing.Size(116, 23);
            this.cmbStaffCode.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(259, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Staff Code:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvInspectionDetails);
            this.panel3.Location = new System.Drawing.Point(234, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 429);
            this.panel3.TabIndex = 15;
            // 
            // dgvInspectionDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInspectionDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInspectionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInspectionDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInspectionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInspectionDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInspectionDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInspectionDetails.ColumnHeadersHeight = 50;
            this.dgvInspectionDetails.DoubleBuffered = true;
            this.dgvInspectionDetails.EnableHeadersVisualStyles = false;
            this.dgvInspectionDetails.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.dgvInspectionDetails.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInspectionDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvInspectionDetails.Name = "dgvInspectionDetails";
            this.dgvInspectionDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInspectionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInspectionDetails.Size = new System.Drawing.Size(782, 429);
            this.dgvInspectionDetails.TabIndex = 0;
            this.dgvInspectionDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinspectionDetails_CellClick);
            // 
            // btnCloseDetails
            // 
            this.btnCloseDetails.Activecolor = System.Drawing.Color.Brown;
            this.btnCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseDetails.BackColor = System.Drawing.Color.Brown;
            this.btnCloseDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseDetails.BorderRadius = 0;
            this.btnCloseDetails.ButtonText = "X";
            this.btnCloseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseDetails.DisabledColor = System.Drawing.Color.Gray;
            this.btnCloseDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDetails.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCloseDetails.Iconimage = null;
            this.btnCloseDetails.Iconimage_right = null;
            this.btnCloseDetails.Iconimage_right_Selected = null;
            this.btnCloseDetails.Iconimage_Selected = null;
            this.btnCloseDetails.IconMarginLeft = 0;
            this.btnCloseDetails.IconMarginRight = 0;
            this.btnCloseDetails.IconRightVisible = true;
            this.btnCloseDetails.IconRightZoom = 0D;
            this.btnCloseDetails.IconVisible = true;
            this.btnCloseDetails.IconZoom = 90D;
            this.btnCloseDetails.IsTab = false;
            this.btnCloseDetails.Location = new System.Drawing.Point(1025, 0);
            this.btnCloseDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseDetails.Name = "btnCloseDetails";
            this.btnCloseDetails.Normalcolor = System.Drawing.Color.Brown;
            this.btnCloseDetails.OnHovercolor = System.Drawing.Color.Red;
            this.btnCloseDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCloseDetails.selected = false;
            this.btnCloseDetails.Size = new System.Drawing.Size(32, 32);
            this.btnCloseDetails.TabIndex = 1;
            this.btnCloseDetails.Text = "X";
            this.btnCloseDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCloseDetails.Textcolor = System.Drawing.Color.White;
            this.btnCloseDetails.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDetails.Click += new System.EventHandler(this.BtnCloseDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pnlView);
            this.panel1.Controls.Add(this.pnlManage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 562);
            this.panel1.TabIndex = 17;
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlView.Controls.Add(this.btnViewList);
            this.pnlView.Controls.Add(this.btnView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 53);
            this.pnlView.MaximumSize = new System.Drawing.Size(200, 115);
            this.pnlView.MinimumSize = new System.Drawing.Size(200, 53);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(200, 53);
            this.pnlView.TabIndex = 13;
            // 
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewList.FlatAppearance.BorderSize = 0;
            this.btnViewList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewList.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnViewList.Location = new System.Drawing.Point(0, 53);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(200, 31);
            this.btnViewList.TabIndex = 6;
            this.btnViewList.Text = "List All Inspections Details";
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
            this.btnView.MinimumSize = new System.Drawing.Size(180, 53);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(200, 53);
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
            this.pnlManage.MaximumSize = new System.Drawing.Size(200, 114);
            this.pnlManage.MinimumSize = new System.Drawing.Size(200, 53);
            this.pnlManage.Name = "pnlManage";
            this.pnlManage.Size = new System.Drawing.Size(200, 53);
            this.pnlManage.TabIndex = 12;
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
            this.btnManageUpdate.Text = "Update Selected Details";
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
            this.btnManageAdd.Text = "Add Details";
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
            // tmrView
            // 
            this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
            // 
            // tmrManage
            // 
            this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
            // 
            // ucInspectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "ucInspectionDetails";
            this.Size = new System.Drawing.Size(1056, 562);
            this.Load += new System.EventHandler(this.UcInspectionDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectionDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.pnlManage.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtFaultComment;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbStaffCode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInspectionDetails;
		private Bunifu.Framework.UI.BunifuFlatButton btnCloseDetails;
		private System.Windows.Forms.ComboBox cmbInspectionCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbEquipmentCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlView;
		private System.Windows.Forms.Button btnViewList;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.Timer tmrManage;
	}
}
