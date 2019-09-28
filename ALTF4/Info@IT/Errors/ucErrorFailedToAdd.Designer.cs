namespace Info_IT.Errors
{
	partial class ucErrorFailedToAdd
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
			this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDataSub = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnClose.BorderRadius = 0;
			this.btnClose.ButtonText = "X";
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.DisabledColor = System.Drawing.Color.Gray;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
			this.btnClose.Iconimage = null;
			this.btnClose.Iconimage_right = null;
			this.btnClose.Iconimage_right_Selected = null;
			this.btnClose.Iconimage_Selected = null;
			this.btnClose.IconMarginLeft = 0;
			this.btnClose.IconMarginRight = 0;
			this.btnClose.IconRightVisible = true;
			this.btnClose.IconRightZoom = 0D;
			this.btnClose.IconVisible = true;
			this.btnClose.IconZoom = 90D;
			this.btnClose.IsTab = false;
			this.btnClose.Location = new System.Drawing.Point(1023, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
			this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
			this.btnClose.selected = false;
			this.btnClose.Size = new System.Drawing.Size(32, 32);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "X";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnClose.Textcolor = System.Drawing.Color.White;
			this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.btnClose);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1056, 52);
			this.panel2.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(471, -2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "ERROR";
			// 
			// lblDataSub
			// 
			this.lblDataSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDataSub.AutoSize = true;
			this.lblDataSub.Font = new System.Drawing.Font("Segoe UI", 24F);
			this.lblDataSub.Location = new System.Drawing.Point(280, 247);
			this.lblDataSub.Name = "lblDataSub";
			this.lblDataSub.Size = new System.Drawing.Size(507, 45);
			this.lblDataSub.TabIndex = 17;
			this.lblDataSub.Text = "Failed to add data to the database";
			this.lblDataSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(339, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(308, 59);
			this.label2.TabIndex = 16;
			this.label2.Text = "Failed to Add: ";
			// 
			// lblData
			// 
			this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblData.AutoSize = true;
			this.lblData.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblData.Location = new System.Drawing.Point(621, 188);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(116, 59);
			this.lblData.TabIndex = 18;
			this.lblData.Text = "Data";
			// 
			// ucErrorFailedToAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.lblDataSub);
			this.Controls.Add(this.label2);
			this.Name = "ucErrorFailedToAdd";
			this.Size = new System.Drawing.Size(1056, 562);
			this.Load += new System.EventHandler(this.UcErrorFailedToAdd_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuFlatButton btnClose;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDataSub;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblData;
	}
}
