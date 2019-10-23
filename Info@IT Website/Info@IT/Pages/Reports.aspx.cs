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
            dgVenue.DataSource = bll.GetVenues();
            dgVenue.DataBind();
            
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

            cmbBuilding.DataSource = bll.LoadCMBBuilding();

            cmbBuilding.DataTextField = "BuildingName";
            cmbBuilding.DataValueField = "BuildingID";
            cmbBuilding.DataBind();
            
            //cmbVenue.DataSource = bll.GetVenues();
            //cmbVenue.DataTextField = "VenueDescription";
            //cmbVenue.DataValueField = "VenueCode";
            //cmbVenue.DataBind();

            //cmbVenueCode.DataSource = bll.GetVenues();

            //cmbVenueCode.DataTextField = "VenueDescription";
            //cmbVenueCode.DataValueField = "VenueCode";
            //cmbVenueCode.DataBind();

            //cmbAssignedStaffCode.DataSource = bll.GetStaff();

            //cmbAssignedStaffCode.DataTextField = "FirstName";
            //cmbAssignedStaffCode.DataValueField = "StaffCode";
            //cmbAssignedStaffCode.DataBind();
            
        }
	}
}