using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportInspectionDetails : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucReportInspectionDetails()
		{
			InitializeComponent();
		}

		private void UcReportInspectionDetails_Load(object sender, EventArgs e)
		{
            cmbEquipmentCode.DataSource = bll.GetEquipment();

            cmbEquipmentCode.DisplayMember = "EquipmentDescription";
            cmbEquipmentCode.ValueMember = "EquipmentCode";

            cmbStaffCode.DataSource = bll.GetStaff();

            cmbStaffCode.DisplayMember = "FirstName";
            cmbStaffCode.ValueMember = "StaffCode";

            cmbInspectionCode.DataSource = bll.GetInspection();

            cmbInspectionCode.DisplayMember = "InspectionCode";
            cmbInspectionCode.ValueMember = "InspectionCode";

            cmbVenue.DataSource = bll.GetVenues();

            cmbVenue.DisplayMember = "VenueDescription";
            cmbVenue.ValueMember = "VenueCode";
            //cmbVenue.Text = "";

            dgvInspectionReport.DataSource = bll.GetInspectionDetail();
        }

        private void cmbInspectionCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionDetailClass inspectionDetail = new DAL.InspectionDetailClass();
                inspectionDetail.InspectionCode = int.Parse(cmbInspectionCode.SelectedValue.ToString());

                dgvInspectionReport.DataSource = bll.Report_DisplayInspectionDetailsByInspectCode(inspectionDetail);
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        private void cmbEquipmentCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionDetailClass inspectionDetail = new DAL.InspectionDetailClass();
                inspectionDetail.EquipmentCode = int.Parse(cmbEquipmentCode.SelectedValue.ToString());

                dgvInspectionReport.DataSource = bll.Report_DisplayInspectionDetailsByEquip(inspectionDetail);
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        private void cmbStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionDetailClass inspectionDetail = new DAL.InspectionDetailClass();
                inspectionDetail.StaffCode = int.Parse(cmbStaffCode.SelectedValue.ToString());

                dgvInspectionReport.DataSource = bll.Report_DisplayInspectionDetailsByStaffCode(inspectionDetail);
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionClass inspection = new DAL.InspectionClass();
                inspection.VenueCode = int.Parse(cmbVenue.SelectedValue.ToString());

                dgvInspectionReport.DataSource = bll.Report_DisplayInspectionDetailsByVenue(inspection);
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
                DAL.InspectionDetailClass inspectionDetail = new DAL.InspectionDetailClass();
                inspectionDetail.InspectionStatus = cmbStatus.SelectedItem.ToString();

                dgvInspectionReport.DataSource = bll.Report_DisplayInspectionDetailsByStatus(inspectionDetail);
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

		private void BtnRemoveFilter_Click(object sender, EventArgs e)
		{

		}
	}
}
