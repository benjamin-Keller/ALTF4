using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT
{
    public partial class Login : System.Web.UI.Page
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DAL.LoginClass login = new DAL.LoginClass(txtUsername.Text, txtPassword.Text);

            var x = bll.GetLogin(login);
            lblError.Visible = false;
            if (x.Rows.Count == 0)
            {
                lblError.Visible = true;
            }
            else
            {
                try
                {
                    var a = x.Rows[0].Table.Rows[0].ItemArray;
                    Session["Role"] = a[6].ToString();
                }
                catch
                {
                }

                Response.Redirect("Pages/Default.aspx");
            }
        }
    }
}