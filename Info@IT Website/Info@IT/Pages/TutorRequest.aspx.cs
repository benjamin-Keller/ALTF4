using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class TutorRequest : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void dgTutorRequest_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void dgTutorRequest_Load1(object sender, EventArgs e)
		{
			dgTutorRequest.DataSource = bll.GetTutorRequest();
			dgTutorRequest.DataBind();
		}

		protected void dgTutorRequest_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
		{

		}
	}
}