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
            try
            {
                DAL.TutorRequestClass request = new DAL.TutorRequestClass(int.Parse(dgTutorRequest.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectedForUpdateTutorRequest(request);

                cmbRequestCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                dateRequest.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
                cmbModuleCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();
                cmbVenueCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[6].ToString();
                cmbStartTime.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
                cmbEndTime.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                cmbStatus.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[7].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

		protected void dgTutorRequest_Load1(object sender, EventArgs e)
		{
            cmbRequestCode.DataSource = bll.GetRequests();
            cmbRequestCode.DataTextField = "RequestCode";
            cmbRequestCode.DataValueField = "RequestCode";
            

            cmbVenueCode.DataSource = bll.GetVenues();
            cmbVenueCode.DataTextField = "VenueDescription";
            cmbVenueCode.DataValueField = "VenueCode";
           

            cmbModuleCode.DataSource = bll.LoadCMBModels();
            cmbModuleCode.DataTextField = "ModuleDescription";
            cmbModuleCode.DataValueField = "ModuleCode";
           

            dgTutorRequest.DataSource = bll.GetTutorRequest();
			dgTutorRequest.DataBind();
		}

		protected void dgTutorRequest_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
		{

		}

        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {
                DAL.TutorRequestClass tutorRequest = new DAL.TutorRequestClass(int.Parse(cmbRequestCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), cmbStartTime.SelectedItem.ToString(), cmbEndTime.SelectedItem.ToString(), int.Parse(cmbModuleCode.SelectedValue.ToString()), int.Parse(cmbVenueCode.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());

                int x = bll.AddTutorRequest(tutorRequest);

                if (x > 0)
                {
                    cmbRequestCode.Text = " ";
                    dateRequest.Text = " ";
                    cmbStartTime.Text = " ";
                    cmbEndTime.Text = " ";
                    cmbRequestCode.Text = " ";
                    cmbModuleCode.Text = " ";
                    cmbVenueCode.Text = " ";
                    cmbStatus.Text = "";
                }
                else
                {

                }
            }
#pragma warning disable CS0168 // The variable 'error' is declared but never used
            catch (Exception error)
#pragma warning restore CS0168 // The variable 'error' is declared but never used
            {

            }



            dgTutorRequest.DataSource = bll.GetTutorRequest();
            dgTutorRequest.DataBind();

        }
        protected void btnManageUpdate(object sender, EventArgs e)
        {
            try
            {
                DAL.TutorRequestClass tutorRequest = new DAL.TutorRequestClass(int.Parse(cmbRequestCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), cmbStartTime.SelectedItem.ToString(), cmbEndTime.SelectedItem.ToString(), int.Parse(cmbModuleCode.SelectedValue.ToString()), int.Parse(cmbVenueCode.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());

                int x = bll.UpdateTutorRequest(tutorRequest);

                if (x > 0)
                {
                    cmbRequestCode.Text = " ";
                    dateRequest.Text = " ";
                    cmbStartTime.Text = " ";
                    cmbEndTime.Text = " ";
                    cmbRequestCode.Text = " ";
                    cmbModuleCode.Text = " ";
                    cmbVenueCode.Text = " ";
                    cmbStatus.Text = "";
                }
                else
                {

                }
            }
#pragma warning disable CS0168 // The variable 'error' is declared but never used
            catch (Exception error)
#pragma warning restore CS0168 // The variable 'error' is declared but never used
            {

            }
            dgTutorRequest.DataSource = bll.GetTutorRequest();
            dgTutorRequest.DataBind();
        }
    }
}