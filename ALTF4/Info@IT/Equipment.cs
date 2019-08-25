using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Equipment : Form
	{
		private bool isCollapsed;

		public Equipment()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.Show();
			this.Hide();
		}

		private void Equipment_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}
		//Menu button (Navigation)
		private void Button1_Click_1(object sender, EventArgs e)
		{
			tmrNavigation.Start();
			if(!(pnlNavigation.Height == pnlNavigation.MinimumSize.Height))
			{
				pnlNavigation.Height = pnlNavigation.MinimumSize.Height;
				tmrNavigation.Enabled = false;
			}
		}
		private void Timer1_Tick(object sender, EventArgs e)
		{
			pnlNavigation.Height = pnlNavigation.MaximumSize.Height;
			tmrNavigation.Stop();
		}

		//Menu button (Manage)
		private void BtnManage_Click(object sender, EventArgs e)
		{
			tmrManage.Start();
			if (!(pnlManage.Height == pnlManage.MinimumSize.Height))
			{
				pnlManage.Height = pnlManage.MinimumSize.Height;
				tmrManage.Enabled = false;
			}
		}
		private void TmrManage_Tick(object sender, EventArgs e)
		{
			pnlManage.Height = pnlManage.MaximumSize.Height;
			tmrManage.Stop();
		}

		//Menu button (View)
		private void BtnView_Click(object sender, EventArgs e)
		{
			tmrView.Start();
			if (!(pnlView.Height == pnlView.MinimumSize.Height))
			{
				pnlView.Height = pnlView.MinimumSize.Height;
				tmrView.Enabled = false;
			}
		}
		private void TmrView_Tick(object sender, EventArgs e)
		{
			pnlView.Height = pnlView.MaximumSize.Height;
			tmrView.Stop();
		}

		private void Equipment_Load(object sender, EventArgs e)
		{
		}
	}
}
