namespace Info_IT.UserControls
{
	partial class ucTaskType
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvTaskType = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlView = new System.Windows.Forms.Panel();
			this.btnViewList = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.pnlManage = new System.Windows.Forms.Panel();
			this.btnManageUpdate = new System.Windows.Forms.Button();
			this.btnManageAdd = new System.Windows.Forms.Button();
			this.btnManage = new System.Windows.Forms.Button();
			this.tmrManage = new System.Windows.Forms.Timer(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.tmrView = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTaskType)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnlView.SuspendLayout();
			this.pnlManage.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(15, 35);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(187, 23);
			this.txtName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(234, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(782, 71);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// dgvTaskType
			// 
			this.dgvTaskType.AllowUserToAddRows = false;
			this.dgvTaskType.AllowUserToDeleteRows = false;
			dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvTaskType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
			this.dgvTaskType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTaskType.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvTaskType.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTaskType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTaskType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
			this.dgvTaskType.ColumnHeadersHeight = 50;
			this.dgvTaskType.DoubleBuffered = true;
			this.dgvTaskType.EnableHeadersVisualStyles = false;
			this.dgvTaskType.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvTaskType.HeaderForeColor = System.Drawing.Color.White;
			this.dgvTaskType.Location = new System.Drawing.Point(0, -1);
			this.dgvTaskType.Name = "dgvTaskType";
			this.dgvTaskType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvTaskType.Size = new System.Drawing.Size(782, 429);
			this.dgvTaskType.TabIndex = 1;
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
			this.panel1.TabIndex = 15;
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
			this.btnViewList.Text = "List All Task Types";
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
			this.btnManageUpdate.Text = "Update Selected Task Type";
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
			this.btnManageAdd.Text = "Add Task Type";
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
			// tmrManage
			// 
			this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvTaskType);
			this.panel3.Location = new System.Drawing.Point(234, 100);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 426);
			this.panel3.TabIndex = 14;
			// 
			// tmrView
			// 
			this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
			// 
			// ucTaskType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "ucTaskType";
			this.Size = new System.Drawing.Size(1056, 562);
			this.Load += new System.EventHandler(this.UcTaskType_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTaskType)).EndInit();
			this.panel1.ResumeLayout(false);
			this.pnlView.ResumeLayout(false);
			this.pnlManage.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTaskType;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlView;
		private System.Windows.Forms.Button btnViewList;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Timer tmrView;
	}
}
