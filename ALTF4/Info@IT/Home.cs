using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Home : Form
	{
		public bool isLoggedIn;

		public Home()
		{
			InitializeComponent();
		}
		private void Home_Load(object sender, EventArgs e)
		{
			if (isLoggedIn)
			{
				btnLog.Text = "Log Out";

			}
			else
			{
				btnLog.Text = "Log In";
			}
		}

		private void btnVenue_Click(object sender, EventArgs e)
		{
			Venue ven = new Venue();
			ven.Show();
			this.Hide();
		}

		private void btnEquipment_Click(object sender, EventArgs e)
		{
			Equipment eq = new Equipment();
			eq.Show();
			this.Hide();
		}

		private void btnEquipmentType_Click(object sender, EventArgs e)
		{
			EquipmentType eqT = new EquipmentType();
			eqT.Show();
			this.Hide();
		}

		private void btnInspection_Click(object sender, EventArgs e)
		{
			Inspection ins = new Inspection();
			ins.Show();
			this.Hide();
		}

		private void btnInspecDetail_Click(object sender, EventArgs e)
		{
			InspectionDetail insD = new InspectionDetail();
			insD.Show();
			this.Hide();
		}

		private void btnStaff_Click(object sender, EventArgs e)
		{
			Staff st = new Staff();
			st.Show();
			this.Hide();
		}

		private void btnDepartment_Click(object sender, EventArgs e)
		{
			Department dep = new Department();
			dep.Show();
			this.Hide();
		}

		private void btnRequest_Click(object sender, EventArgs e)
		{
			Request req = new Request();
			req.Show();
			this.Hide();
		}

		private void btnTaskType_Click(object sender, EventArgs e)
		{
			TaskType taskT = new TaskType();
			taskT.Show();
			this.Hide();
		}

		private void btnTutorReq_Click(object sender, EventArgs e)
		{
			TutorRequest tutR = new TutorRequest();
			tutR.Show();
			this.Hide();
		}

		private void btnStudent_Click(object sender, EventArgs e)
		{
			Student stu = new Student();
			stu.Show();
			this.Hide();
		}


		// On hover color change events

		private void BtnEquipment_MouseEnter(object sender, EventArgs e)
		{
			btnEquipment.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnEquipment.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnEquipment_MouseLeave(object sender, EventArgs e)
		{
			btnEquipment.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnEquipment.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnVenue_MouseEnter(object sender, EventArgs e)
		{
			btnVenue.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnVenue.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnVenue_MouseLeave(object sender, EventArgs e)
		{
			btnVenue.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnVenue.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnEquipmentType_MouseEnter(object sender, EventArgs e)
		{
			btnEquipmentType.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnEquipmentType.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnEquipmentType_MouseLeave(object sender, EventArgs e)
		{
			btnEquipmentType.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnEquipmentType.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnDepartment_MouseEnter(object sender, EventArgs e)
		{
			btnDepartment.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnDepartment.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnDepartment_MouseLeave(object sender, EventArgs e)
		{
			btnDepartment.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnDepartment.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnRequest_MouseEnter(object sender, EventArgs e)
		{
			btnRequest.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnRequest_MouseLeave(object sender, EventArgs e)
		{
			btnRequest.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnRequest.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnTutorReq_MouseEnter(object sender, EventArgs e)
		{
			btnTutorReq.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnTutorReq.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnTutorReq_MouseLeave(object sender, EventArgs e)
		{
			btnTutorReq.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnTutorReq.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnInspection_MouseEnter(object sender, EventArgs e)
		{
			btnInspection.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnInspection.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnInspection_MouseLeave(object sender, EventArgs e)
		{
			btnInspection.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnInspection.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnInspecDetail_MouseEnter(object sender, EventArgs e)
		{
			btnInspecDetail.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnInspecDetail.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnInspecDetail_MouseLeave(object sender, EventArgs e)
		{
			btnInspecDetail.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnInspecDetail.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnTaskType_MouseEnter(object sender, EventArgs e)
		{
			btnTaskType.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnTaskType.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnTaskType_MouseLeave(object sender, EventArgs e)
		{
			btnTaskType.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnTaskType.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnStaff_MouseEnter(object sender, EventArgs e)
		{
			btnStaff.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnStaff.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnStaff_MouseLeave(object sender, EventArgs e)
		{
			btnStaff.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnStaff.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void BtnStudent_MouseEnter(object sender, EventArgs e)
		{
			btnStudent.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnStudent_MouseLeave(object sender, EventArgs e)
		{
			btnStudent.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnStudent.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void Home_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Panel3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Label3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnLogout_Click(object sender, EventArgs e)
		{
			Login l = new Login();
			this.Hide();
			l.Show();
		}


	}
}