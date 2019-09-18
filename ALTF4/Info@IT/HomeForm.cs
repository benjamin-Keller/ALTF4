using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using System.Data;

namespace Info_IT
{
	public partial class Home : Form
	{
		public bool isLoggedIn;
		public string role = "Admin";
		public bool firstUser;
		public bool firstPass;

        BusinessLogicLayer bll = new BusinessLogicLayer();

        public Home()
		{
			InitializeComponent();
		}
		private void Template_Load(object sender, EventArgs e)
		{
			HideAll();
			LoginPanel();

			//Hidden when first launching
			pnlNavigation.Hide();
			pnlLogin.Hide();
			btnNavHelp.Hide();
		}

		public void LoginPanel()
		{
			pnlLoginFields.Visible = true;
            pnlLoginFields.Focus();

			this.Text = "Login";
			lblLocation.Text = "Login";

			//This is like an If Else statement for isLoggedIn
			switch (isLoggedIn) {
				case true:
					lblLoginText.Text = "Log out";
					isLoggedIn = false;
					pnlLogin.Show();
					break;

				case false:
					lblLoginText.Text = "Log In";
					pnlLogin.Show();
					break;
			}

			//This is like an If Else statement for getting the Role
			switch (role)
			{
				case "Admin":
					lblLoginText.Text = "Log out";
					////What can Admin see

					//btnNavHome.Hide();
					//btnNavEquipment.Hide();
					//btnNavVenue.Hide();
					//btnNavDepartment.Hide();
					//btnNavDepartment.Hide();
					//btnNavRequest.Hide();
					//btnNavTutorRequest.Hide();
					//btnNavInspection.Hide();
					//btnNavTaskType.Hide();
					//btnNavStudent.Hide();
					//btnNavStaff.Hide();
					//btnNavUser.Hide();
					break;

				case "Staff":
					lblLoginText.Text = "Log In";
					////What can Staff see

					//btnNavHome.Hide();
					//btnNavEquipment.Hide();
					//btnNavVenue.Hide();
					//btnNavDepartment.Hide();
					//btnNavDepartment.Hide();
					//btnNavRequest.Hide();
					//btnNavTutorRequest.Hide();
					//btnNavInspection.Hide();
					//btnNavTaskType.Hide();
					//btnNavStudent.Hide();
					//btnNavStaff.Hide();
					//btnNavUser.Hide();
					break;
				case "ICT":
					////What can Info@It Staff see

					//btnNavHome.Hide();
					//btnNavEquipment.Hide();
					//btnNavVenue.Hide();
					//btnNavDepartment.Hide();
					//btnNavDepartment.Hide();
					//btnNavRequest.Hide();
					//btnNavTutorRequest.Hide();
					//btnNavInspection.Hide();
					//btnNavTaskType.Hide();
					//btnNavStudent.Hide();
					//btnNavStaff.Hide();
					//btnNavUser.Hide();
					break;

				case "SI":
					////What can SI see

					//btnNavHome.Hide();
					//btnNavEquipment.Hide();
					//btnNavVenue.Hide();
					//btnNavDepartment.Hide();
					//btnNavDepartment.Hide();
					//btnNavRequest.Hide();
					//btnNavTutorRequest.Hide();
					//btnNavInspection.Hide();
					//btnNavTaskType.Hide();
					//btnNavStudent.Hide();
					//btnNavStaff.Hide();
					//btnNavUser.Hide();
					break;
				default:
					////What can everyone else see

					btnNavHome.Hide();
					btnNavEquipment.Hide();
					btnNavVenue.Hide();
					btnNavDepartment.Hide();
					btnNavDepartment.Hide();
					btnNavRequest.Hide();
					btnNavTutorRequest.Hide();
					btnNavInspection.Hide();
					btnNavTaskType.Hide();
					btnNavStudent.Hide();
					btnNavStaff.Hide();
					btnNavUser.Hide();
					break;

			}

		}

		private void txtUsername_Enter(object sender, EventArgs e)
		{
			if (txtUsername.Text == "Username")
			{
				txtUsername.Text = "";
			}
		}
		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if (txtUsername.Text == "" || txtUsername.Text == null)
			{
				txtUsername.Text = "Username";
			}
		}
		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (txtPassword.Text == "Password")
			{
				txtPassword.Text = "";
			}
		}
		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text == "" || txtPassword.Text == null)
			{
				txtPassword.Text = "Password";
			}
		}


		private void BtnLogIn_Click(object sender, EventArgs e)
		{
            //DAL.LoginClass login = new DAL.LoginClass(txtUsername.Text, txtPassword.Text);
            //DataTable x = new DataTable();

            //x = bll.GetLogin(login);

            //if (x.Rows[0] == null)
            //{
            //    MessageBox.Show("Incorrect Username and Password");
            //}
            //else
            //{
            //    isLoggedIn = true;
            //    LoginPanel();
            //    HideAll();
            //    ucHome1.Show();

            //    this.Text = "Info@IT";
            //    lblLocation.Text = "Home";

            //    pnlNavigation.Show();
            //}

            isLoggedIn = true;
            LoginPanel();
            HideAll();
            ucHome1.Show();

            this.Text = "Info@IT";
            lblLocation.Text = "Home";

            pnlNavigation.Show();
			btnNavHelp.Show();

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
			btnNavStudent.BackColor = Color.FromArgb(0,100,200);
			btnNavStaff.BackColor = Color.FromArgb(0,100,200);
			btnNavUser.BackColor = Color.FromArgb(0,100,200);
			btnNavHelp.BackColor = Color.FromArgb(0, 100, 200);
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
			ucTaskType1.Hide();
			ucHelp1.Hide();
			ucStudent1.Hide();
			ucStaff1.Hide();
			ucUser1.Hide();

			pnlLoginFields.Hide();	
		}
		//Login bar
		private void Login_Click(object sender, EventArgs e)
		{
			LoginPanel();

			//Hidden when first launching
			btnNavHelp.Hide();
			pnlNavigation.Hide();
			pnlLogin.Hide();
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

			ucTaskType1.Show();
			this.Text = "Task Type";
			lblLocation.Text = "Task Type";
		}

		private void BtnHelp_Click(object sender, EventArgs e)
		{
            //Making sure you cannot click it during log on
            if (pnlLoginFields.Visible == false)
            {
                HideAll();
                InactiveButtons();
                btnNavHelp.BackColor = Color.FromArgb(0, 150, 250);

                ucHelp1.Show();
                this.Text = "Help";
                lblLocation.Text = "Help";
            }
		}

		private void BtnStudent_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavStudent.BackColor = Color.FromArgb(0, 150, 250);

			ucStudent1.Show();
			this.Text = "Student";
			lblLocation.Text = "Student";
		}

		private void BtnStaff_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavStaff.BackColor = Color.FromArgb(0, 150, 250);

			ucStaff1.Show();
			this.Text = "Staff";
			lblLocation.Text = "Staff";
		}
		private void BtnNavUser_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavUser.BackColor = Color.FromArgb(0, 150, 250);

			ucUser1.Show();
			this.Text = "User";
			lblLocation.Text = "User";
		}

		private void Logo_Click(object sender, EventArgs e)
		{
			//Making sure you cannot click it during log on
			if(pnlLoginFields.Visible == false)
			{
				HideAll();
				InactiveButtons();
				btnNavHome.BackColor = Color.FromArgb(0, 150, 250);

				ucHome1.Show();
				this.Text = "Info@IT";
				lblLocation.Text = "Home";
			}
		}


	}
}