using System;
using System.Windows.Forms;
using BLL;

namespace Info_IT
{
	public partial class Inspection : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public Inspection()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.Show();
			this.Hide();
		}

		private void Inspection_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}
	}
}
