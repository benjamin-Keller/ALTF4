using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Student : Form
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public Student()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.Show();
			this.Hide();
		}

		private void Student_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}
	}
}
