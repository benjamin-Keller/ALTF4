using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Home : Form
	{
		bool isLoggedIn = false;

		public Home()
		{
			InitializeComponent();
		}
		private void Template_Load(object sender, EventArgs e)
		{
			LoginPanel();
			HideAll();
			ucHome1.Show();
			this.Text = "Home";
			lblLocation.Text = "Home";

		}

		private void Template_Resize(object sender, EventArgs e)
		{
		}
		private void LoginPanel()
		{
			//This is like an If Else statement for isLoggedIn
			switch(isLoggedIn) {
				case true:
					lblLoginText.Text = "Log out";
					isLoggedIn = false;
					break;
				case false:
					lblLoginText.Text = "Log In";
					isLoggedIn = true;
					break;
			}
		}
		private void InactiveButtons()
		{
			btnNavDepartment.BackColor = Color.FromArgb(0,100,200);
			btnNavEquipment.BackColor = Color.FromArgb(0,100,200);
			btnNavHome.BackColor = Color.FromArgb(0,100,200);
			btnNavInspection.BackColor = Color.FromArgb(0,100,200);
			btnNavRequest.BackColor = Color.FromArgb(0,100,200);
			btnNavTaskType.BackColor = Color.FromArgb(0,100,200);
			btnNavTutorRequest.BackColor = Color.FromArgb(0,100,200);
			btnNavVenue.BackColor = Color.FromArgb(0,100,200);
		}

		private void HideAll()
		{
			ucEquipment1.Hide();
			ucHome1.Hide();
			ucVenue1.Hide();
			ucDepartment1.Hide();
			ucRequest1.Hide();
			ucTutorRequest1.Hide();
			ucNavInspection1.Hide();
			
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

		private void PnlLogin_MouseEnter(object sender, EventArgs e)
		{
			pnlLogin.BackColor = Color.FromArgb(0, 150, 250);
		}

		private void PnlLogin_MouseLeave(object sender, EventArgs e)
		{
			pnlLogin.BackColor = Color.FromArgb(0, 100, 200);

		}
		private void LblLoginText_MouseEnter(object sender, EventArgs e)
		{
			pnlLogin.BackColor = Color.FromArgb(0, 150, 250);

		}

		private void LblLoginText_MouseLeave(object sender, EventArgs e)
		{
			pnlLogin.BackColor = Color.FromArgb(0, 100, 200);

		}

		private void BtnNavHome_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavHome.BackColor = Color.FromArgb(0, 150, 250);

			ucHome1.Show();
			this.Text = "Info@IT";
			lblLocation.Text = "Home";
		}

		private void BtnNavEquipment_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavEquipment.BackColor = Color.FromArgb(0, 150, 250);

			ucEquipment1.Show();
			this.Text = "Equipment";
			lblLocation.Text = "Equipment";

		}

		private void BtnNavVenue_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavVenue.BackColor = Color.FromArgb(0, 150, 250);

			ucVenue1.Show();
			this.Text = "Venue";
			lblLocation.Text = "Venue";

		}

		private void BtnNavDepartment_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavDepartment.BackColor = Color.FromArgb(0, 150, 250);

			ucDepartment1.Show();
			this.Text = "Department";
			lblLocation.Text = "Department";

		}

		private void BtnNavRequest_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavRequest.BackColor = Color.FromArgb(0, 150, 250);

			ucRequest1.Show();
			this.Text = "Request";
			lblLocation.Text = "Request";
		}

		private void BtnNavTutorRequest_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavTutorRequest.BackColor = Color.FromArgb(0, 150, 250);

			ucTutorRequest1.Show();
			this.Text = "Tutor Requests";
			lblLocation.Text = "Tutor Request";
		}

		private void BtnNavInspection_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavInspection.BackColor = Color.FromArgb(0, 150, 250);

			ucNavInspection1.Show();
			this.Text = "Inspections";
			lblLocation.Text = "Inspections";
		}

		private void BtnNavTaskType_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavTaskType.BackColor = Color.FromArgb(0, 150, 250);

		}


	}
}
