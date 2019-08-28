namespace Info_IT
{
    partial class Login
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlNavigation = new System.Windows.Forms.Panel();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.pnlNavigation.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Gill Sans MT Condensed", 50F, System.Drawing.FontStyle.Italic);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.label4.Location = new System.Drawing.Point(186, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 83);
			this.label4.TabIndex = 24;
			this.label4.Text = "Info@IT";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gill Sans MT Condensed", 35F, System.Drawing.FontStyle.Italic);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(186, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 59);
			this.label1.TabIndex = 25;
			this.label1.Text = "Login";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(287, 167);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(174, 20);
			this.txtUsername.TabIndex = 28;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(287, 206);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(174, 20);
			this.txtPassword.TabIndex = 29;
			// 
			// cmbRole
			// 
			this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Location = new System.Drawing.Point(287, 245);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(174, 21);
			this.cmbRole.TabIndex = 33;
			this.cmbRole.TextChanged += new System.EventHandler(this.cmbRole_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(555, 161);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(168, 125);
			this.label6.TabIndex = 34;
			this.label6.Text = "The submit button\r\ndoes not validate\r\nanything yet so\r\njust press it to go\r\nto ho" +
    "me page";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pnlNavigation);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(180, 450);
			this.panel1.TabIndex = 35;
			// 
			// pnlNavigation
			// 
			this.pnlNavigation.Controls.Add(this.btnLogin);
			this.pnlNavigation.Controls.Add(this.btnSignUp);
			this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNavigation.Location = new System.Drawing.Point(0, 69);
			this.pnlNavigation.MinimumSize = new System.Drawing.Size(180, 53);
			this.pnlNavigation.Name = "pnlNavigation";
			this.pnlNavigation.Size = new System.Drawing.Size(180, 106);
			this.pnlNavigation.TabIndex = 2;
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSignUp.FlatAppearance.BorderSize = 0;
			this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSignUp.Location = new System.Drawing.Point(0, 0);
			this.btnSignUp.MinimumSize = new System.Drawing.Size(180, 53);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(180, 53);
			this.btnSignUp.TabIndex = 5;
			this.btnSignUp.Text = "Sign Up";
			this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.MouseEnter += new System.EventHandler(this.BtnSignUp_MouseEnter);
			this.btnSignUp.MouseLeave += new System.EventHandler(this.BtnSignUp_MouseLeave);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.label7);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(180, 69);
			this.panel2.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Gill Sans MT Condensed", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(35, -11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 83);
			this.label7.TabIndex = 0;
			this.label7.Text = "@";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Location = new System.Drawing.Point(0, 53);
			this.btnLogin.MinimumSize = new System.Drawing.Size(180, 53);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(180, 53);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Log in";
			this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			this.btnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
			this.btnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label2.Location = new System.Drawing.Point(198, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "Username:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label3.Location = new System.Drawing.Point(197, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 37;
			this.label3.Text = "Password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label5.Location = new System.Drawing.Point(202, 248);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 38;
			this.label5.Text = "Role:";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cmbRole);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			this.pnlNavigation.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlNavigation;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
	}
}