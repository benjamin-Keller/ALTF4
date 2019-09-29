using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportInspection : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucReportInspection()
		{
			InitializeComponent();
		}

		private void UcReportInspection_Load(object sender, EventArgs e)
		{
			cmbVenueCode.DataSource = bll.GetVenues();

			cmbVenueCode.DisplayMember = "VenueDescription";
			cmbVenueCode.ValueMember = "VenueCode";
			cmbVenueCode.Text = "";

			cmbStaffCode.DataSource = bll.GetStaff();

			cmbStaffCode.DisplayMember = "FirstName";
			cmbStaffCode.ValueMember = "StaffCode";
			cmbStaffCode.Text = "";

			dgvInspectionReport.DataSource = bll.GetInspection();
		}

		private void dateInspection_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.InspectionClass inspection = new DAL.InspectionClass();
				inspection.InspectionDate = Convert.ToDateTime(dateInspection.Text);

				dgvInspectionReport.DataSource = bll.Report_DisplayInspectionByDate(inspection);
			}
			catch (Exception b)
			{

			}
		}

		private void cmbVenueCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.InspectionClass inspection = new DAL.InspectionClass();
				inspection.VenueCode = int.Parse(cmbVenueCode.SelectedValue.ToString());

				dgvInspectionReport.DataSource = bll.Report_DisplayInspectionByVenue(inspection);
			}
			catch (Exception b)
			{

			}
		}

		private void cmbStaffCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.InspectionClass inspection = new DAL.InspectionClass();
				inspection.StaffCode = int.Parse(cmbStaffCode.SelectedValue.ToString());

				dgvInspectionReport.DataSource = bll.Report_DisplayInspectionByStaffCode(inspection);
			}
			catch (Exception b)
			{

			}
		}
	}
}
