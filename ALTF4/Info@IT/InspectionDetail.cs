using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class InspectionDetail : Form
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public InspectionDetail()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.Show();
			this.Hide();
		}

		private void InspectionDetail_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}
	}
}
