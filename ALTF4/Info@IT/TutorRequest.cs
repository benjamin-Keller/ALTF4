using System;
using System.Windows.Forms;
using BLL;

namespace Info_IT
{
	public partial class TutorRequest : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public TutorRequest()
		{
			InitializeComponent();
		}

		private void TutorRequest_FormClosing(object sender, FormClosingEventArgs e)
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

		private void BtnNavHome_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.Show();
			this.Hide();
		}

		private void BtnManageAdd_Click(object sender, EventArgs e)
		{

		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
            dgvTutorRequest.DataSource = bll.GetTutorRequest();

        }

        private void BtnNavVenue_Click(object sender, EventArgs e)
		{
			Venue v = new Venue();
			v.Show();
			this.Hide();
		}

		private void BtnNavEquipmentType_Click(object sender, EventArgs e)
		{
			EquipmentType et = new EquipmentType();
			et.Show();
			this.Hide();
		}

		private void BtnNavDepartment_Click(object sender, EventArgs e)
		{
			Department d = new Department();
			d.Show();
			this.Hide();
		}

		private void BtnNavRequest_Click(object sender, EventArgs e)
		{
			Request r = new Request();
			r.Show();
			this.Hide();
		}

		private void BtnNavInspection_Click(object sender, EventArgs e)
		{
			Inspection i = new Inspection();
			i.Show();
			this.Hide();
		}

		private void BtnNavInspectionDetail_Click(object sender, EventArgs e)
		{
			InspectionDetail id = new InspectionDetail();
			id.Show();
			this.Hide();
		}

		private void BtnNavTaskType_Click(object sender, EventArgs e)
		{
			TaskType t = new TaskType();
			t.Show();
			this.Hide();
		}

		private void BtnNavEquipment_Click(object sender, EventArgs e)
		{
			Equipment eq = new Equipment();
			eq.Show();
			this.Hide();
		}
	}
}
