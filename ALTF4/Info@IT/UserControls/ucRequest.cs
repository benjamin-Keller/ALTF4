using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace Info_IT.UserControls
{
	public partial class ucRequest : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucRequest()
		{
			InitializeComponent();
		}
		private void UcRequest_Load(object sender, EventArgs e)
		{
			dateRequest.Value = DateTime.Now;

            dgvRequest.DataSource = bll.GetRequests();

            cmbTaskTypeCode.DataSource = bll.GetTasktype();
            
            cmbTaskTypeCode.DisplayMember = "TaskName";
            cmbTaskTypeCode.ValueMember = "taskTypeCode";

            cmbAssignedStaffCode.DataSource = bll.GetStaff();

            cmbAssignedStaffCode.DisplayMember = "FirstName";
            cmbAssignedStaffCode.ValueMember = "StaffCode";

            cmbStaffCode.DataSource = bll.GetStaff();

            cmbStaffCode.DisplayMember = "FirstName";
            cmbStaffCode.ValueMember = "StaffCode";

            cmbStudentCode.DataSource = bll.GetStudent();

            cmbStudentCode.DisplayMember = "FirstName";
            cmbStudentCode.ValueMember = "StudentCode";


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
            DAL.RequestClass request = new DAL.RequestClass(txtDescription.Text, int.Parse(cmbStaffCode.SelectedValue.ToString()), int.Parse(cmbStudentCode.SelectedValue.ToString()), int.Parse(cmbTaskTypeCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), cmbTime.SelectedItem.ToString(), int.Parse(cmbAssignedStaffCode.SelectedValue.ToString()), "Pending");

            int x = bll.AddRequest(request);

            if (x > 0)
            {
                txtDescription.Clear();
                cmbTime.ResetText();
                cmbStaffCode.ResetText();
                cmbStudentCode.ResetText();
                cmbTaskTypeCode.ResetText();
                cmbAssignedStaffCode.ResetText();
                dateRequest.ResetText();
            }
            else
            {
                MessageBox.Show("Please input valid data.");
            }

            dgvRequest.DataSource = bll.GetRequests();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
            DAL.RequestClass request = new DAL.RequestClass(DAL.RequestClass.RequestCode, txtDescription.Text, int.Parse(cmbStaffCode.SelectedValue.ToString()), int.Parse(cmbStudentCode.SelectedValue.ToString()), int.Parse(cmbTaskTypeCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), cmbTime.SelectedText.ToString(), int.Parse(cmbAssignedStaffCode.SelectedValue.ToString()), "Pending");

            int x = bll.UpdateRequest(request);

            if (x > 0)
            {
                txtDescription.Clear();
                cmbTime.ResetText();
                cmbStaffCode.ResetText();
                cmbStudentCode.ResetText();
                cmbTaskTypeCode.ResetText();
                cmbAssignedStaffCode.ResetText();
                dateRequest.ResetText();
            }
            else
            {
                MessageBox.Show("Please input valid data.");
            }

            dgvRequest.DataSource = bll.GetRequests();
        }

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvRequest.DataSource = bll.GetRequests();
			dgvRequest.BackgroundColor = Color.White;

		}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DAL.RequestClass requestClass = new DAL.RequestClass(int.Parse(dgvRequest.SelectedRows[0].Cells[0].Value.ToString()));

            var values = bll.SelectedForUpdateRequest(requestClass);

            txtDescription.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
            dateRequest.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

            cmbStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2];
            cmbStudentCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[3];
            cmbTaskTypeCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[4];
            cmbTime.Text = values.Rows[0].Table.Rows[0].ItemArray[6].ToString();
            cmbAssignedStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[7];
        }
    }
}
