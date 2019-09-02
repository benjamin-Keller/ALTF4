using System;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class TutorRequest : Form
	{
		public TutorRequest()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.Show();
			this.Hide();
		}

		private void TutorRequest_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}
	}
}
