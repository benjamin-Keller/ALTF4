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
	public partial class HomeForm : Form
	{
		public HomeForm()
		{
			InitializeComponent();
		}
		private void Template_Load(object sender, EventArgs e)
		{
			lblLoginText.Width = pnlLogin.Width;
			lblLoginText.TextAlign = ContentAlignment.MiddleCenter;
			lblLoginText.Text = "Please Login";
			
		}

		private void Template_Resize(object sender, EventArgs e)
		{
		}

		private void PnlLogin_Click(object sender, EventArgs e)
		{
			LoginPanel();
		}

		private void LoginPanel()
		{
			
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
		private void TmrNavigation_Tick(object sender, EventArgs e)
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

		private void LblLoginText_Click(object sender, EventArgs e)
		{
			LoginPanel();
		}

		private void BtnNavHome_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.TopLevel = false;
			h.AutoScroll = true;
			this.pnlContent.Controls.Add(h);
			h.Show();
		}

		private void BtnNavEquipment_Click(object sender, EventArgs e)
		{

		}

		private void BtnNavVenue_Click(object sender, EventArgs e)
		{

		}

		private void BtnNavDepartment_Click(object sender, EventArgs e)
		{

		}

		private void BtnNavRequest_Click(object sender, EventArgs e)
		{

		}

		private void BtnNavTutorRequest_Click(object sender, EventArgs e)
		{

		}

		private void BtnNavInspection_Click(object sender, EventArgs e)
		{

		}

		private void BtnNavInspectionDetail_Click(object sender, EventArgs e)
		{

		}

		private void BtnNavTaskType_Click(object sender, EventArgs e)
		{

		}
	}
}
