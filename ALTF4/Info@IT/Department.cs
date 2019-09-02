using System;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Department : Form
	{
		public Department()
		{
			InitializeComponent();
		}

		private void Department_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}

		private void BtnNavHome_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
