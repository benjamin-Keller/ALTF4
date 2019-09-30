using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportRequest : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucReportRequest()
		{
			InitializeComponent();
		}

		private void UcReportRequest_Load(object sender, EventArgs e)
		{
			dateRequest.Value = DateTime.Now;

			dgvRequestReport.DataSource = bll.GetRequests();

			cmbTaskTypeCode.DataSource = bll.GetTasktype();

			cmbTaskTypeCode.DisplayMember = "TaskName";
			cmbTaskTypeCode.ValueMember = "taskTypeCode";
			cmbTaskTypeCode.Text = "";

			cmbAssignedStaffCode.DataSource = bll.GetStaff();

			cmbAssignedStaffCode.DisplayMember = "FirstName";
			cmbAssignedStaffCode.ValueMember = "StaffCode";
			cmbAssignedStaffCode.Text = "";

			cmbStaffCode.DataSource = bll.GetStaff();

			cmbStaffCode.DisplayMember = "FirstName";
			cmbStaffCode.ValueMember = "StaffCode";
			cmbStaffCode.Text = "";

			cmbStudentCode.DataSource = bll.GetStudent();

			cmbStudentCode.DisplayMember = "FirstName";
			cmbStudentCode.ValueMember = "StudentCode";
			cmbStudentCode.Text = "";

		}

		private void cmbStaffCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.RequestClass request = new DAL.RequestClass();
				request.RequestStaffCode = int.Parse(cmbStaffCode.SelectedValue.ToString());

				dgvRequestReport.DataSource = bll.Report_DisplayRequestsByStaffCode(request);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbStudentCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.RequestClass request = new DAL.RequestClass();
				request.RequestStudentCode = int.Parse(cmbStudentCode.SelectedValue.ToString());

				dgvRequestReport.DataSource = bll.Report_DisplayRequestsByStudentCode(request);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbTaskTypeCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.RequestClass request = new DAL.RequestClass();
				request.RequestTaskTypeCode = int.Parse(cmbTaskTypeCode.SelectedValue.ToString());

				dgvRequestReport.DataSource = bll.Report_DisplayRequestsByTaskType(request);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void dateRequest_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.RequestClass request = new DAL.RequestClass();
				request.RequestDate = Convert.ToDateTime(dateRequest.Text);

				dgvRequestReport.DataSource = bll.Report_DisplayRequestsByDate(request);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.RequestClass request = new DAL.RequestClass();
				request.RequestTime = cmbTime.SelectedItem.ToString();

				dgvRequestReport.DataSource = bll.Report_DisplayRequestsByTime(request);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbAssignedStaffCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.RequestClass request = new DAL.RequestClass();
				request.RequestAssignedStaffCode = int.Parse(cmbAssignedStaffCode.SelectedValue.ToString());

				dgvRequestReport.DataSource = bll.Report_DisplayRequestsByAssignedStaff(request);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass request = new DAL.RequestClass();
                request.RequestStatus = cmbStatus.SelectedItem.ToString();

                dgvRequestReport.DataSource = bll.Report_DisplayRequestsByStatus(request);
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }
    }
}
