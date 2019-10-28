using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Inspection : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void dgInspection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionClass inspectClass = new DAL.InspectionClass(int.Parse(dgInspection.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectedForUpdateInspection(inspectClass);


                txtInspectTime.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                txtComment.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();
                calInspectDate.SelectedDate = DateTime.Parse(values.Rows[0].Table.Rows[0].ItemArray[3].ToString());
                calInspectDate.VisibleDate = DateTime.Parse(values.Rows[0].Table.Rows[0].ItemArray[3].ToString());
                cmbVenue.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                cmbStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
            }
            catch (Exception b)
            {

            }
        }

        protected void dgInspection_Load1(object sender, EventArgs e)
        {

            cmbVenue.DataSource = bll.GetVenues();

            cmbVenue.DataTextField = "Venue";
            cmbVenue.DataValueField = "Venue Code";
            cmbVenue.DataBind();

            cmbStaffCode.DataSource = bll.GetStaff();

            cmbStaffCode.DataTextField ="First Name";
            cmbStaffCode.DataValueField = "Staff Code";
            cmbStaffCode.DataBind();

            dgInspection.DataSource = bll.GetInspection();
            dgInspection.DataBind();
        }

        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {


                //Error for input string not found
                DAL.InspectionClass inspection = new DAL.InspectionClass(calInspectDate.SelectedDate, txtInspectTime.Text, txtComment.Text, int.Parse(cmbVenue.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()));
                int x = bll.AddInspection(inspection);

                if (x > 0)
                {
                    calInspectDate.SelectedDate = DateTime.Now;
                    txtInspectTime.Text = "";
                    txtComment.Text = "";
                    cmbVenue.Text = " ";
                    cmbStaffCode.Text = " ";
                }
                else
                {

                }
            }
            catch
            {

            }

            dgInspection.DataSource = bll.GetInspection();
            dgInspection.DataBind();
        }

        protected void btnManageUpdate(object sender, EventArgs e)
        {
            try
            {

                //Error for input string not found
                DAL.InspectionClass inspection = new DAL.InspectionClass(DAL.InspectionClass.InspectionCode, calInspectDate.SelectedDate, txtInspectTime.Text, txtComment.Text, int.Parse(cmbVenue.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()));
                int x = bll.UpdateInspection(inspection);

                if (x > 0)
                {
                    calInspectDate.SelectedDate = DateTime.Now;
                    txtInspectTime.Text = "";
                    txtComment.Text = "";
                    cmbVenue.Text = " ";
                    cmbStaffCode.Text = " ";
                }
                else
                {

                }
            }
            catch (Exception b)
            {

            }

            dgInspection.DataSource = bll.GetInspection();
            dgInspection.DataBind();
        }
    }
}