using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Reports : System.Web.UI.Page
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                dgVenue.DataSource = bll.GetVenues();
                dgVenue.DataBind();

                dgInspectionDetails.DataSource = bll.GetInspectionDetail();
                dgInspectionDetails.DataBind();

                dgInspection.DataSource = bll.GetInspection();
                dgInspection.DataBind();

                dgStaff.DataSource = bll.GetStaff();
                dgStaff.DataBind();

                dgDepartment.DataSource = bll.GetDepartment();
                dgDepartment.DataBind();

                dgEquipment.DataSource = bll.GetEquipment();
                dgEquipment.DataBind();

                dgRequest.DataSource = bll.GetRequests();
                dgRequest.DataBind();

                dgStudent.DataSource = bll.GetStudent();
                dgStudent.DataBind();

                dgTutorRequest.DataSource = bll.GetTutorRequest();
                dgTutorRequest.DataBind();

                cmbBuildingDepartment.DataSource = bll.LoadCMBBuilding();

                cmbBuildingDepartment.DataTextField = "BuildingName";
                cmbBuildingDepartment.DataValueField = "BuildingID";
                cmbBuildingDepartment.DataBind();

                cmbVenueEquipment.DataSource = bll.GetVenues();

                cmbVenueEquipment.DataTextField = "Venue";
                cmbVenueEquipment.DataValueField = "Venue Code";
                cmbVenueEquipment.DataBind();

                cmbEquipTypeEquipment.DataSource = bll.GetEquipmentType();

                cmbEquipTypeEquipment.DataTextField = "Type";
                cmbEquipTypeEquipment.DataValueField = "Equipment Type Code";
                cmbEquipTypeEquipment.DataBind();

                cmbVenueInspection.DataSource = bll.GetVenues();

                cmbVenueInspection.DataTextField = "Venue";
                cmbVenueInspection.DataValueField = "Venue Code";
                cmbVenueInspection.DataBind();

                cmbStaffCodeInspection.DataSource = bll.GetStaff();

                cmbStaffCodeInspection.DataTextField = "First Name";
                cmbStaffCodeInspection.DataValueField = "Staff Code";
                cmbStaffCodeInspection.DataBind();

                cmbInspectionCodeInspectionDetails.DataSource = bll.GetInspection();

                cmbInspectionCodeInspectionDetails.DataTextField = "Inspection Code";
                cmbInspectionCodeInspectionDetails.DataValueField = "Inspection Code";
                cmbInspectionCodeInspectionDetails.DataBind();

                cmbEquipmentInspectionDetails.DataSource = bll.GetEquipment();

                cmbEquipmentInspectionDetails.DataTextField = "Equipment Description";
                cmbEquipmentInspectionDetails.DataValueField = "Equipment Code";
                cmbEquipmentInspectionDetails.DataBind();

                cmbStaffMemberInspectionDetails.DataSource = bll.GetStaff();

                cmbStaffMemberInspectionDetails.DataTextField = "First Name";
                cmbStaffMemberInspectionDetails.DataValueField = "Staff Code";
                cmbStaffMemberInspectionDetails.DataBind();

                cmbStaffRequest.DataSource = bll.GetStaff();

                cmbStaffRequest.DataTextField = "First Name";
                cmbStaffRequest.DataValueField = "Staff Code";
                cmbStaffRequest.DataBind();

                cmbStudentCodeRequest.DataSource = bll.GetStudent();

                cmbStudentCodeRequest.DataTextField = "First Name";
                cmbStudentCodeRequest.DataValueField = "Student Code";
                cmbStudentCodeRequest.DataBind();

                cmbTaskTypeCodeRequest.DataSource = bll.GetTasktype();

                cmbTaskTypeCodeRequest.DataTextField = "Task Name";
                cmbTaskTypeCodeRequest.DataValueField = "Task Type Code";
                cmbTaskTypeCodeRequest.DataBind();

                cmbAssignedStaffCodeRequest.DataSource = bll.GetStaff();

                cmbAssignedStaffCodeRequest.DataTextField = "First Name";
                cmbAssignedStaffCodeRequest.DataValueField = "Staff Code";
                cmbAssignedStaffCodeRequest.DataBind();

                cmbDepartmentCodeStaff.DataSource = bll.GetDepartment();

                cmbDepartmentCodeStaff.DataTextField = "Department Name";
                cmbDepartmentCodeStaff.DataValueField = "Department Code";
                cmbDepartmentCodeStaff.DataBind();

                cmbModuleCodeTutorRequest.DataSource = bll.LoadCMBModels();

                cmbModuleCodeTutorRequest.DataTextField = "ModuleDescription";
                cmbModuleCodeTutorRequest.DataValueField = "ModuleCode";
                cmbModuleCodeTutorRequest.DataBind();

                cmbVenueCodeTutorRequest.DataSource = bll.GetVenues();

                cmbVenueCodeTutorRequest.DataTextField = "Venue";
                cmbVenueCodeTutorRequest.DataValueField = "Venue Code";
                cmbVenueCodeTutorRequest.DataBind();

                cmbBuildingBlocksVenue.DataSource = bll.LoadCMBBuildingBlock();

                cmbBuildingBlocksVenue.DataTextField = "BuildingBlock";
                cmbBuildingBlocksVenue.DataValueField = "BuildingBlockID";
                cmbBuildingBlocksVenue.DataBind();

                cmbBuildingVenue.DataSource = bll.LoadCMBBuilding();

                cmbBuildingVenue.DataTextField = "BuildingName";
                cmbBuildingVenue.DataValueField = "BuildingID";
                cmbBuildingVenue.DataBind();

                List<object> listStart = new List<object>();

                listStart.Add("08:00");
                listStart.Add("08:30");
                listStart.Add("09:00");
                listStart.Add("09:30");
                listStart.Add("10:00");
                listStart.Add("10:30");
                listStart.Add("11:00");
                listStart.Add("11:30");
                listStart.Add("12:00");
                listStart.Add("12:30");
                listStart.Add("13:00");
                listStart.Add("13:30");
                listStart.Add("14:00");
                listStart.Add("14:30");
                listStart.Add("15:00");
                listStart.Add("15:30");
                listStart.Add("16:00");
                listStart.Add("16:30");

                cmbTimeRequest.DataSource = listStart;
                cmbTimeRequest.DataBind();


            }
        }

        protected void cmbBuildingDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.DepartmentClass department = new DAL.DepartmentClass
                {
                    Building = int.Parse(cmbBuildingDepartment.SelectedItem.Value.ToString())
                };

                dgDepartment.DataSource = bll.Report_DislayDepartmentByBuilding(department);
                dgDepartment.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbBuildingBlocksVenue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}