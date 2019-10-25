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
            dateRequest.SelectedDate = DateTime.Now;

            cmbTaskTypeCode.DataSource = bll.GetTasktype();

            cmbTaskTypeCode.DataTextField = "Task Name";
            cmbTaskTypeCode.DataValueField = "Task Type Code";
            cmbTaskTypeCode.DataBind();

            cmbAssignedStaffCode.DataSource = bll.GetStaff();

            cmbAssignedStaffCode.DataTextField = "First Name";
            cmbAssignedStaffCode.DataValueField = "Staff Code";
            cmbAssignedStaffCode.DataBind();

            cmbStaff.DataSource = bll.GetStaff();

            cmbStaff.DataTextField = "First Name";
            cmbStaff.DataValueField = "Staff Code";
            cmbStaff.DataBind();

            cmbStudentCode.DataSource = bll.GetStudent();

            cmbStudentCode.DataTextField = "First Name";
            cmbStudentCode.DataValueField = "Student Code";
            cmbStudentCode.DataBind();

            dgRequest.DataSource = bll.GetRequests();
            dgRequest.DataBind();
        }

        protected void dgRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass requestClass = new DAL.RequestClass(int.Parse(dgRequest.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectedForUpdateRequest(requestClass);

                txtDescription.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                //dateRequest.SelectedDate = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

                cmbStaff.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
                cmbStudentCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
                cmbTaskTypeCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                cmbTime.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[6].ToString();
                cmbAssignedStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[7].ToString();
                cmbStatus.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[8].ToString();
            }
            catch
            {
            }
        }

        protected void btnManageAdd(object sender, EventArgs e)
        {
            DAL.RequestClass request = new DAL.RequestClass(txtDescription.Text, int.Parse(cmbStaff.SelectedValue.ToString()), int.Parse(cmbStudentCode.SelectedValue.ToString()), int.Parse(cmbTaskTypeCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.SelectedDate), cmbTime.SelectedItem.ToString(), int.Parse(cmbAssignedStaffCode.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());

            int x = bll.AddRequest(request);

            if (x > 0)
            {
                txtDescription.Text = "";
                cmbTime.Text = "";
                cmbStaff.Text = "";
                cmbStudentCode.Text = "";
                cmbTaskTypeCode.Text = "";
                cmbAssignedStaffCode.Text = "";
                dateRequest.SelectedDate = DateTime.Today;
                cmbStatus.Text = "";
            }
            else
            {
            }

            dgRequest.DataSource = bll.GetRequests();
            dgRequest.DataBind();
        }

        protected void btnManageUpdate(object sender, EventArgs e)
        {
            DAL.RequestClass request = new DAL.RequestClass(DAL.RequestClass.RequestCode, txtDescription.Text, int.Parse(cmbStaff.SelectedValue.ToString()), int.Parse(cmbStudentCode.SelectedValue.ToString()), int.Parse(cmbTaskTypeCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.SelectedDate), cmbTime.SelectedItem.ToString(), int.Parse(cmbAssignedStaffCode.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());

            int x = bll.UpdateRequest(request);

            if (x > 0)
            {
                txtDescription.Text = "";
                cmbTime.Text = "";
                cmbStaff.Text = "";
                cmbStudentCode.Text = "";
                cmbTaskTypeCode.Text = "";
                cmbAssignedStaffCode.Text = "";
                dateRequest.SelectedDate = DateTime.Today;
                cmbStatus.Text = "";
            }
            else
            {
            }

            dgRequest.DataSource = bll.GetRequests();
            dgRequest.DataBind();
        }
    }
}