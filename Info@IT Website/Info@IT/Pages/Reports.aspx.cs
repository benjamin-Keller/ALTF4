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

                listStart.Add("ICT HelpDesk");
                listStart.Add("Student Assistant");
                listStart.Add("Info@IT");

                cmbStaffTypeStaff.DataSource = listStart;
                cmbStaffTypeStaff.DataBind();
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
            try
            {
                    DAL.VenueClass venueClass = new DAL.VenueClass
                    {
                        VenueBuildingBlock = int.Parse(cmbBuildingBlocksVenue.SelectedValue.ToString())
                    };

                    dgVenue.DataSource = bll.Report_DisplayVenueByBuildingBlock(venueClass);
                dgVenue.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbStaffTypeStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                    DAL.StaffClass staff = new DAL.StaffClass
                    {
                        StaffType = cmbStaffTypeStaff.SelectedItem.ToString()
                    };

                    dgStaff.DataSource = bll.Report_DisplayStaffByStaffType(staff);
                    dgStaff.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }

        }

        protected void cmbDepartmentCodeStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartmentCodeStaff.DataValueField != "")
                {
                    DAL.StaffClass staff = new DAL.StaffClass
                    {
                        DepartmentCode = int.Parse(cmbDepartmentCodeStaff.SelectedValue.ToString())
                    };

                    dgStaff.DataSource = bll.Report_DisplayStaffByDepartment(staff);
                    dgStaff.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }
        
        protected void cmbVenueInspection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionClass inspection = new DAL.InspectionClass
                {
                    VenueCode = int.Parse(cmbVenueInspection.SelectedValue.ToString())
                };

                dgInspection.DataSource = bll.Report_DisplayInspectionByVenue(inspection);
                dgInspection.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbStaffCodeInspection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionClass inspection = new DAL.InspectionClass
                {
                    StaffCode = int.Parse(cmbStaffCodeInspection.SelectedValue.ToString())
                };

                dgInspection.DataSource = bll.Report_DisplayInspectionByStaffCode(inspection);
                dgInspection.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbInspectionCodeInspectionDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbInspectionCodeInspectionDetails.DataValueField != "")
                {
                    DAL.InspectionDetailClass inspectionDetail = new DAL.InspectionDetailClass
                    {
                        InspectionCode = int.Parse(cmbInspectionCodeInspectionDetails.SelectedValue.ToString())
                    };

                    dgInspectionDetails.DataSource = bll.Report_DisplayInspectionDetailsByInspectCode(inspectionDetail);
                    dgInspectionDetails.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbEquipmentInspectionDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEquipmentInspectionDetails.DataValueField != "")
                {
                    DAL.InspectionDetailClass inspectionDetail = new DAL.InspectionDetailClass
                    {
                        EquipmentCode = int.Parse(cmbEquipmentInspectionDetails.SelectedValue.ToString())
                    };

                    dgInspectionDetails.DataSource = bll.Report_DisplayInspectionDetailsByEquip(inspectionDetail);
                    dgInspectionDetails.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbStaffMemberInspectionDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStaffMemberInspectionDetails.DataValueField != "")
                {
                    DAL.InspectionDetailClass inspectionDetail = new DAL.InspectionDetailClass
                    {
                        StaffCode = int.Parse(cmbStaffMemberInspectionDetails.SelectedValue.ToString())
                    };

                    dgInspectionDetails.DataSource = bll.Report_DisplayInspectionDetailsByStaffCode(inspectionDetail);
                    dgInspectionDetails.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }
        
        protected void cmbVenueCodeTutorRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVenueCodeTutorRequest.DataValueField != "")
                {
                    DAL.TutorRequestClass tutor = new DAL.TutorRequestClass
                    {
                        VenueCode = int.Parse(cmbVenueCodeTutorRequest.SelectedValue.ToString())
                    };

                    dgTutorRequest.DataSource = bll.Report_DisplayTutorRequestByRequestVenue(tutor);
                    dgTutorRequest.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }
        

        protected void dateTutorRequest_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                DAL.TutorRequestClass tutor = new DAL.TutorRequestClass
                {
                    Date = Convert.ToDateTime(dateRequest.SelectedDate)
                };

                dgTutorRequest.DataSource = bll.Report_DisplayTutorRequestByRequestDate(tutor);
                dgTutorRequest.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void calInspectDate_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionClass inspection = new DAL.InspectionClass
                {
                    InspectionDate = Convert.ToDateTime(calInspectDate.SelectedDate)
                };

                dgInspection.DataSource = bll.Report_DisplayInspectionByDate(inspection);
                dgInspection.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbStaffRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStaffRequest.DataValueField != "")
                {
                    DAL.RequestClass request = new DAL.RequestClass
                    {
                        RequestStaffCode = int.Parse(cmbStaffRequest.SelectedValue.ToString())
                    };

                    dgRequest.DataSource = bll.Report_DisplayRequestsByStaffCode(request);
                    dgRequest.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbStudentCodeRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudentCodeRequest.DataValueField != "")
                {
                    DAL.RequestClass request = new DAL.RequestClass
                    {
                        RequestStudentCode = int.Parse(cmbStudentCodeRequest.SelectedValue.ToString())
                    };

                    dgRequest.DataSource = bll.Report_DisplayRequestsByStudentCode(request);
                    dgRequest.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbTaskTypeCodeRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTaskTypeCodeRequest.DataValueField != "")
                {
                    DAL.RequestClass request = new DAL.RequestClass
                    {
                        RequestTaskTypeCode = int.Parse(cmbTaskTypeCodeRequest.SelectedValue.ToString())
                    };

                    dgRequest.DataSource = bll.Report_DisplayRequestsByTaskType(request);
                    dgRequest.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void dateRequest_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass request = new DAL.RequestClass
                {
                    RequestDate = Convert.ToDateTime(dateRequest.SelectedDate)
                };

                dgRequest.DataSource = bll.Report_DisplayRequestsByDate(request);
                dgRequest.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbTimeRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTimeRequest.DataValueField != "")
                {
                    DAL.RequestClass request = new DAL.RequestClass
                    {
                        RequestTime = cmbTimeRequest.SelectedItem.ToString()
                    };

                    dgRequest.DataSource = bll.Report_DisplayRequestsByTime(request);
                    dgRequest.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbAssignedStaffCodeRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssignedStaffCodeRequest.DataValueField != "")
                {
                    DAL.RequestClass request = new DAL.RequestClass
                    {
                        RequestAssignedStaffCode = int.Parse(cmbAssignedStaffCodeRequest.SelectedValue.ToString())
                    };

                    dgRequest.DataSource = bll.Report_DisplayRequestsByAssignedStaff(request);
                    dgRequest.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }
        
        protected void cmbVenueEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.EquipmentClass equipment = new DAL.EquipmentClass
                {
                    VenueCode = int.Parse(cmbVenueEquipment.SelectedValue.ToString())
                };

                dgEquipment.DataSource = bll.Report_DisplayEquipmentByVenue(equipment);
                dgEquipment.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbEquipTypeEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.EquipmentClass equipment = new DAL.EquipmentClass
                {
                    EquipTypeCode = int.Parse(cmbEquipTypeEquipment.SelectedValue.ToString())
                };

                dgEquipment.DataSource = bll.Report_DisplayEquipmentByEquipmentType(equipment);
                dgEquipment.DataBind();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void cmbBuildingVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBuildingVenue.DataValueField != "")
                {
                    DAL.VenueClass venueClass = new DAL.VenueClass
                    {
                        VenueBuilding = int.Parse(cmbBuildingVenue.SelectedValue.ToString())
                    };

                    dgVenue.DataSource = bll.Report_DisplayVenueByBuilding(venueClass);
                    dgVenue.DataBind();
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }
    }
}