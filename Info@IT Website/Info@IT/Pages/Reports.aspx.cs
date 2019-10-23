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
            dgVenue.DataBind();

            dgEquipment.DataSource = bll.GetEquipment();
            dgVenue.DataBind();

            dgRequest.DataSource = bll.GetRequests();
            dgVenue.DataBind();

            dgStudent.DataSource = bll.GetStudent();
            dgVenue.DataBind();

            dgTutorRequest.DataSource = bll.GetTutorRequest();
            dgVenue.DataBind();
            

        }
	}
}