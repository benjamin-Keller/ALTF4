using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Request : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void dgRequest_Load1(object sender, EventArgs e)
		{
			dgRequest.DataSource = bll.GetRequests();
			dgRequest.DataBind();
		}

		protected void dgRequest_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}