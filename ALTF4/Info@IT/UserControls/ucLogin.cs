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

		public bool isLoggedIn { get; set; }

		public ucLogin()
		{
			InitializeComponent();
		}

		public ucLogin(bool IsLoggedIn)
		{
			isLoggedIn = IsLoggedIn;
		}

		private void UcLogin_Load(object sender, EventArgs e)
		{
			isLoggedIn = false;
		}

		private void BtnLogIn_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
