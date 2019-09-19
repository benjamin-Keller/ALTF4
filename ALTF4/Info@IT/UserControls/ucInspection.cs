using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Info_IT.UserControls
{
	public partial class ucInspection : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucInspection()
		{
			InitializeComponent();
		}

		private void UcNavInspection_Load(object sender, EventArgs e)
		{
			ucInspectionDetails1.Hide();

            cmbVenueCode.DataSource = bll.GetVenues();

            cmbVenueCode.DisplayMember = "VenueDescription";
            cmbVenueCode.ValueMember = "VenueCode";

            cmbStaffCode.DataSource = bll.GetStaff();

            cmbStaffCode.DisplayMember = "FirstName";
            cmbStaffCode.ValueMember = "StaffCode";

            dgvInspection.DataSource = bll.GetInspection();
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
			pnlManage.Height = pnlManage.MinimumSize.Height;
			tmrView.Stop();
		}

		private void BtnManageAdd_Click(object sender, EventArgs e)
		{
            try
            {


                //Error for input string not found
                DAL.InspectionClass inspection = new DAL.InspectionClass(dateInspection.Text, txtTime.Text, txtComment.Text, int.Parse(cmbVenueCode.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()));
                int x = bll.AddInspection(inspection);

                if (x > 0)
                {
                    dateInspection.ResetText();
                    txtTime.Clear();
                    txtComment.Clear();
                    cmbVenueCode.ValueMember = "";
                    cmbStaffCode.ValueMember = "";
                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }
            }
            catch
            {
                MessageBox.Show("Please input valid data.");
            }

            dgvInspection.DataSource = bll.GetInspection();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
            dgvInspection.DataSource = bll.GetInspection();
            dgvInspection.BackgroundColor = Color.White;
		}

		private void BtnViewInspectiondetails_Click(object sender, EventArgs e)
		{

			ucInspectionDetails1.Show();
		}
	}
}
