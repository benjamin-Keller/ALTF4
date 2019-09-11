using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucLogin : UserControl
	{

		public bool IsLoggedIn { get; set; }
		public string Role { get; set; }

		public ucLogin()
		{
			InitializeComponent();
		}

		public ucLogin(bool isLoggedIn, string role)
		{
			IsLoggedIn = isLoggedIn;
			Role = role;

		}

		private void UcLogin_Load(object sender, EventArgs e)
		{
			IsLoggedIn = false;
		}

		private void BtnLogIn_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.isLoggedIn = true;
			h.role = "";
			
			h.isLoggedIn = this.IsLoggedIn;
			h.role = this.Role;
			h.LoginPanel();
			
			this.Hide();
		}
		private void TxtUsername_Click(object sender, EventArgs e)
		{
			bool first = false;

			if (!first)
			{
				txtUsername.Text = "";
				first = true;

			}
		}

		private void TxtPassword_Click(object sender, EventArgs e)
		{
			bool first = false;

			if (!first)
			{
				txtPassword.Text = "";
				first = true;

			}
		}


	}
}
