using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Equipment : Form
	{

		public Equipment()
		{
			InitializeComponent();
		}

		private void Equipment_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}
		//Menu button (Navigation)
		private void BtnNavigation_Click(object sender, EventArgs e)
		{
			tmrNavigation.Start();
			if (!(pnlNavigation.Height == pnlNavigation.MinimumSize.Height))
			{
				pnlNavigation.Height = pnlNavigation.MinimumSize.Height;
				tmrNavigation.Enabled = false;
			}
		}
		private void Timer1_Tick(object sender, EventArgs e)
		{
			pnlNavigation.Height = pnlNavigation.MaximumSize.Height;
			pnlView.Height = pnlView.MinimumSize.Height;
			pnlManage.Height = pnlManage.MinimumSize.Height;
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
			pnlNavigation.Height = pnlNavigation.MinimumSize.Height;
			pnlView.Height = pnlView.MinimumSize.Height;
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
			pnlNavigation.Height = pnlNavigation.MinimumSize.Height;
			pnlManage.Height = pnlManage.MinimumSize.Height;
			tmrView.Stop();
		}

		private void Equipment_Load(object sender, EventArgs e)
		{
		}

		private void BtnNavigation_MouseEnter(object sender, EventArgs e)
		{
			btnNavigation.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnNavigation.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnNavigation_MouseLeave(object sender, EventArgs e)
		{
			btnNavigation.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnNavigation.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnManage_MouseEnter(object sender, EventArgs e)
		{
			btnManage.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnManage.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnManage_MouseLeave(object sender, EventArgs e)
		{
			btnManage.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnManage.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnView_MouseEnter(object sender, EventArgs e)
		{
			btnView.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnView.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnView_MouseLeave(object sender, EventArgs e)
		{
			btnView.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnView.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}
		private void BtnNavHome_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnManageAdd_Click(object sender, EventArgs e)
		{

		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{

		}

		private void BtnManageDelete_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewListType_Click(object sender, EventArgs e)
		{

		}
	}
}
