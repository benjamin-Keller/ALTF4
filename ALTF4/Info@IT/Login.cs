using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			//lock input fields when page loads
			txtUsername.Enabled = false;
			txtPassword.Enabled = false;

			cmbRole.Items.Add("Student");
			cmbRole.Items.Add("Student Assistant");
			cmbRole.Items.Add("Info@IT Staff");
			cmbRole.Items.Add("ICT Helpdesk Staff");
		}

		//enable input fields when a role is selected
		private void cmbRole_TextChanged(object sender, EventArgs e)
		{
			if (cmbRole.Text != "")
			{
				txtUsername.Enabled = true;
				txtPassword.Enabled = true;
			}
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.isLoggedIn = true;
			h.Show();
			this.Hide();
		}

		private void BtnSignUp_MouseEnter(object sender, EventArgs e)
		{
			btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnSignUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnSignUp_MouseLeave(object sender, EventArgs e)
		{
			btnSignUp.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnSignUp.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnLogin_MouseEnter(object sender, EventArgs e)
		{
			btnLogin.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnLogin_MouseLeave(object sender, EventArgs e)
		{
			btnLogin.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnLogin.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}
	}
}
