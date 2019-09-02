namespace Info_IT
{
	partial class sideMenu
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabNavigation = new System.Windows.Forms.TabPage();
			this.btnHome = new System.Windows.Forms.Button();
			this.tabManage = new System.Windows.Forms.TabPage();
			this.tabView = new System.Windows.Forms.TabPage();
			this.tabControl.SuspendLayout();
			this.tabNavigation.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabNavigation);
			this.tabControl.Controls.Add(this.tabManage);
			this.tabControl.Controls.Add(this.tabView);
			this.tabControl.Location = new System.Drawing.Point(-8, -24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(245, 526);
			this.tabControl.TabIndex = 0;
			// 
			// tabNavigation
			// 
			this.tabNavigation.Controls.Add(this.btnHome);
			this.tabNavigation.Location = new System.Drawing.Point(4, 22);
			this.tabNavigation.Name = "tabNavigation";
			this.tabNavigation.Padding = new System.Windows.Forms.Padding(3);
			this.tabNavigation.Size = new System.Drawing.Size(237, 500);
			this.tabNavigation.TabIndex = 0;
			this.tabNavigation.Text = "Navigation";
			this.tabNavigation.UseVisualStyleBackColor = true;
			// 
			// btnHome
			// 
			this.btnHome.AutoSize = true;
			this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.Location = new System.Drawing.Point(3, 3);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(231, 42);
			this.btnHome.TabIndex = 3;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
			// 
			// tabManage
			// 
			this.tabManage.Location = new System.Drawing.Point(4, 22);
			this.tabManage.Name = "tabManage";
			this.tabManage.Padding = new System.Windows.Forms.Padding(3);
			this.tabManage.Size = new System.Drawing.Size(237, 401);
			this.tabManage.TabIndex = 1;
			this.tabManage.Text = "Manage";
			this.tabManage.UseVisualStyleBackColor = true;
			// 
			// tabView
			// 
			this.tabView.Location = new System.Drawing.Point(4, 22);
			this.tabView.Name = "tabView";
			this.tabView.Padding = new System.Windows.Forms.Padding(3);
			this.tabView.Size = new System.Drawing.Size(237, 500);
			this.tabView.TabIndex = 2;
			this.tabView.Text = "View";
			this.tabView.UseVisualStyleBackColor = true;
			// 
			// sideMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl);
			this.Name = "sideMenu";
			this.Size = new System.Drawing.Size(227, 493);
			this.tabControl.ResumeLayout(false);
			this.tabNavigation.ResumeLayout(false);
			this.tabNavigation.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabNavigation;
		private System.Windows.Forms.TabPage tabManage;
		private System.Windows.Forms.TabPage tabView;
		private System.Windows.Forms.Button btnHome;
	}
}
