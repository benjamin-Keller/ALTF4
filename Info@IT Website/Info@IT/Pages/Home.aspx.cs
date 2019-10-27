using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Info_IT.Pages
{
	public partial class Default : System.Web.UI.Page
	{
        string role;

        protected void Page_Load(object sender, EventArgs e)
		{
            role = Session["Role"].ToString();
            lblRole.Text = "Your Current Role: " + role;
		}
	}
}