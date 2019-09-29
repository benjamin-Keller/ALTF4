using System;
using System.Windows.Forms;
using BLL;

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
            cmbEquipmentCode.ValueMember = "Equipmentcode";

            cmbStaffCode.DataSource = bll.GetStaff();

            cmbStaffCode.DisplayMember = "FirstName";
            cmbStaffCode.ValueMember = "StaffCode";

            cmbInspectionCode.DataSource = bll.GetInspection();

            cmbInspectionCode.DisplayMember = "InspectionCode";
            cmbInspectionCode.ValueMember = "InspectionCode";

            cmbVenue.DataSource = bll.GetVenues();

            cmbVenue.DisplayMember = "VenueDescription";
            cmbVenue.ValueMember = "VenueCode";
            cmbVenue.Text = "";

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
            catch (Exception b)
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
            catch (Exception b)
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
            catch (Exception b)
            {

            }
        }

        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionDetailClass inspectionDetail = new DAL.InspectionDetailClass();
                inspectionDetail.InspectionCode = int.Parse(cmbInspectionCode.SelectedValue.ToString());

                //dgvInspectionReport.DataSource = bll.re(inspectionDetail);
            }
            catch (Exception b)
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
            catch (Exception b)
            {

            }
        }
    }
}
