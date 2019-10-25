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
            List<object> times = new List<object>();
            times.Add("08:00:00");
            times.Add("08:30:00");
            times.Add("09:00:00");
            times.Add("09:30:00");
            times.Add("10:00:00");
            times.Add("10:30:00");
            times.Add("11:00:00");
            times.Add("11:30:00");
            times.Add("12:00:00");
            times.Add("12:30:00");
            times.Add("13:00:00");
            times.Add("13:30:00");
            times.Add("14:00:00");
            times.Add("14:30:00");
            times.Add("15:00:00");
            times.Add("15:30:00");
            times.Add("16:00:00");
            times.Add("16:30:00");

            cmbTime.DataSource = times;
            cmbTime.DataBind();
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