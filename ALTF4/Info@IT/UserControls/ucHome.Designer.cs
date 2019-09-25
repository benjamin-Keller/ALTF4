namespace Info_IT.UserControls
{
	partial class ucHome
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblRole = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(144, -3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(780, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to the Info@IT HelpDesk System!";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(903, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Made by ALT+4";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1056, 52);
			this.panel2.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 520);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1056, 42);
			this.panel1.TabIndex = 6;
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.ForeColor = System.Drawing.Color.Black;
			this.lblWelcome.Location = new System.Drawing.Point(0, 52);
			this.lblWelcome.MinimumSize = new System.Drawing.Size(1056, 55);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(1056, 55);
			this.lblWelcome.TabIndex = 1;
			this.lblWelcome.Text = "Welcome back text";
			this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(0, 465);
			this.label2.MinimumSize = new System.Drawing.Size(1056, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1056, 55);
			this.label2.TabIndex = 12;
			this.label2.Text = "If you get lost, visit our Help secion in the side menu!";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::Info_IT.Properties.Resources.icon;
			this.pictureBox1.Location = new System.Drawing.Point(1014, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(42, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// lblRole
			// 
			this.lblRole.AutoSize = true;
			this.lblRole.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblRole.Font = new System.Drawing.Font("Segoe UI", 24F);
			this.lblRole.ForeColor = System.Drawing.Color.Black;
			this.lblRole.Location = new System.Drawing.Point(0, 107);
			this.lblRole.MinimumSize = new System.Drawing.Size(1056, 55);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(1056, 55);
			this.lblRole.TabIndex = 13;
			this.lblRole.Text = "You are role text";
			this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "ucHome";
			this.Size = new System.Drawing.Size(1056, 562);
			this.Load += new System.EventHandler(this.UcHome_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label lblRole;
	}
}
