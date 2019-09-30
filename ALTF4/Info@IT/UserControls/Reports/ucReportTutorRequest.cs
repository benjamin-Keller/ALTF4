using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportTutorRequest : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucReportTutorRequest()
		{
			InitializeComponent();
		}

		private void UcReportTutorRequest_Load(object sender, EventArgs e)
		{
			dgvTutorRequestReport.DataSource = bll.GetTutorRequest();

			cmbVenueCode.DataSource = bll.GetVenues();

			cmbVenueCode.DisplayMember = "VenueDescription";
			cmbVenueCode.ValueMember = "VenueCode";
			cmbVenueCode.Text = "";

			cmbModuleCode.DataSource = bll.LoadCMBModels();

			cmbModuleCode.DisplayMember = "ModuleDescription";
			cmbModuleCode.ValueMember = "ModuleCode";
			cmbModuleCode.Text = "";
		}

		private void cmbRequestCode_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dateRequest_ValueChanged(object sender, EventArgs e)
		{
			try
			{

                DAL.TutorRequestClass tutor = new DAL.TutorRequestClass
                {
                    Date = Convert.ToDateTime(dateRequest.Text)
                };

                dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestDate(tutor);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbModuleCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                if (cmbModuleCode.ValueMember != "")
                {
                    DAL.TutorRequestClass tutor = new DAL.TutorRequestClass
                    {
                        ModuleCode = int.Parse(cmbModuleCode.SelectedValue.ToString())
                    };

                    dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestModuleCode(tutor);
                }
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbVenueCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                if (cmbVenueCode.ValueMember != "")
                {
                    DAL.TutorRequestClass tutor = new DAL.TutorRequestClass
                    {
                        VenueCode = int.Parse(cmbVenueCode.SelectedValue.ToString())
                    };

                    dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestVenue(tutor);
                }
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbStartTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                if (cmbStartTime.SelectedText != "")
                {
                    DAL.TutorRequestClass tutor = new DAL.TutorRequestClass
                    {
                        StartTime = cmbStartTime.SelectedItem.ToString()
                    };

                    dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestStartTime(tutor);
                }
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbEndTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                if (cmbEndTime.SelectedText != "")
                {
                    DAL.TutorRequestClass tutor = new DAL.TutorRequestClass
                    {
                        EndTime = cmbEndTime.SelectedItem.ToString()
                    };

                    dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestEndTime(tutor);
                }
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void BtnRemoveFilter_Click(object sender, EventArgs e)
		{
            dgvTutorRequestReport.DataSource = bll.GetTutorRequest();
			cmbEndTime.SelectedText = "";
			cmbModuleCode.SelectedText = "";
			cmbStartTime.SelectedText = "";
			cmbStatus.SelectedText = "";
			cmbVenueCode.SelectedText = "";
		}

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
