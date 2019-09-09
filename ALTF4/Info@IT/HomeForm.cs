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
			//lblLoginText.Width = pnlLogin.Width;
			//lblLoginText.TextAlign = ContentAlignment.MiddleCenter;
			//lblLoginText.Text = "Please Login";

			HideAll();
			
		}

		private void Template_Resize(object sender, EventArgs e)
		{
		}
		private void LoginPanel()
		{

		}
		private void HideAll()
		{
			//ucEquipment1.Hide();
		}
		//Login bar
		private void PnlLogin_Click(object sender, EventArgs e)
		{
			LoginPanel();
		}
		private void LblLoginText_Click(object sender, EventArgs e)
		{
			LoginPanel();
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

			tmrNavigation.Stop();
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
