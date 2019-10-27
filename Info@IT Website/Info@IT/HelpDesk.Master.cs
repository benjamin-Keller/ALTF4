using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Info_IT
{
	public partial class HelpDesk : System.Web.UI.MasterPage
	{
        string role;

		protected void Page_Load(object sender, EventArgs e)
		{
            try
            {
                role = Session["Role"].ToString();
            }
            catch
            {
                Response.Redirect("/Login.aspx");
            }

            lblRole.Text = role;

            venue.Visible = true;
            department.Visible = true;
            tasktype.Visible = true;
            student.Visible = true;
            staff.Visible = true;

            switch (role)
            {
                case "Info@IT":
                    
                    venue.Visible = false;
                    department.Visible = false;
                    staff.Visible = false;

                    break;

                case "Student Assistant":
                    
                    venue.Visible = false;
                    department.Visible = false;
                    tasktype.Visible = false;
                    student.Visible = false;
                    staff.Visible = false;

                    break;
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }

    }
}