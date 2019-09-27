using System;
using System.Drawing;
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
                DAL.InspectionClass inspection = new DAL.InspectionClass(Convert.ToDateTime(dateInspection.Text), txtTime.Text, txtComment.Text, int.Parse(cmbVenueCode.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()));
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
            try
            {

                //Error for input string not found
                DAL.InspectionClass inspection = new DAL.InspectionClass(DAL.InspectionClass.InspectionCode, Convert.ToDateTime(dateInspection.Text), txtTime.Text, txtComment.Text, int.Parse(cmbVenueCode.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()));
                int x = bll.UpdateInspection(inspection);

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
            catch (Exception b)
            {
                MessageBox.Show("Please input valid data.");
            }

            dgvInspection.DataSource = bll.GetInspection();
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

        private void dgvInspection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DAL.InspectionClass inspectClass = new DAL.InspectionClass(int.Parse(dgvInspection.SelectedRows[0].Cells[0].Value.ToString()));

            var values = bll.SelectedForUpdateInspection(inspectClass);

            dateInspection.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
            txtTime.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
            txtComment.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

            cmbVenueCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[1];
            cmbStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2];
        }
    }
}
