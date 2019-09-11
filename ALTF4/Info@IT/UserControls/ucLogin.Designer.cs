namespace Info_IT.UserControls
{
	partial class ucLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLogin));
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserrname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.btnLogIn = new Bunifu.Framework.UI.BunifuThinButton2();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(446, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "Log In";
			// 
			// txtUserrname
			// 
			this.txtUserrname.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUserrname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtUserrname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtUserrname.HintForeColor = System.Drawing.Color.Empty;
			this.txtUserrname.HintText = "";
			this.txtUserrname.isPassword = false;
			this.txtUserrname.LineFocusedColor = System.Drawing.Color.Blue;
			this.txtUserrname.LineIdleColor = System.Drawing.Color.Gray;
			this.txtUserrname.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.txtUserrname.LineThickness = 3;
			this.txtUserrname.Location = new System.Drawing.Point(324, 204);
			this.txtUserrname.Margin = new System.Windows.Forms.Padding(4);
			this.txtUserrname.Name = "txtUserrname";
			this.txtUserrname.Size = new System.Drawing.Size(370, 44);
			this.txtUserrname.TabIndex = 1;
			this.txtUserrname.Text = "Username";
			this.txtUserrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txtPassword
			// 
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
			this.txtPassword.HintText = "";
			this.txtPassword.isPassword = false;
			this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
			this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
			this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.txtPassword.LineThickness = 3;
			this.txtPassword.Location = new System.Drawing.Point(324, 256);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(370, 44);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "Password";
			this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btnLogIn
			// 
			this.btnLogIn.ActiveBorderThickness = 1;
			this.btnLogIn.ActiveCornerRadius = 20;
			this.btnLogIn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnLogIn.ActiveForecolor = System.Drawing.Color.White;
			this.btnLogIn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnLogIn.BackColor = System.Drawing.SystemColors.Control;
			this.btnLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogIn.BackgroundImage")));
			this.btnLogIn.ButtonText = "Log In";
			this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnLogIn.IdleBorderThickness = 1;
			this.btnLogIn.IdleCornerRadius = 20;
			this.btnLogIn.IdleFillColor = System.Drawing.Color.White;
			this.btnLogIn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnLogIn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnLogIn.Location = new System.Drawing.Point(418, 337);
			this.btnLogIn.Margin = new System.Windows.Forms.Padding(5);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(181, 41);
			this.btnLogIn.TabIndex = 3;
			this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
			// 
			// ucLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnLogIn);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserrname);
			this.Controls.Add(this.label1);
			this.Name = "ucLogin";
			this.Size = new System.Drawing.Size(1056, 562);
			this.Load += new System.EventHandler(this.UcLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserrname;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
		private Bunifu.Framework.UI.BunifuThinButton2 btnLogIn;
	}
}
