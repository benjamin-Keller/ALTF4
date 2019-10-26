using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Staff : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void dgStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.StaffClass staffClass = new DAL.StaffClass(int.Parse(dgStaff.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectForUpdateStaffExUser(staffClass);

                txtStaffNo.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                txtFirstName.Text = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
                txtLastName.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
                txtEmail.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                txtContactNumber.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

                cmbStaffType.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[6].ToString();
                cmbDepartmentCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[7].ToString();
            }
            catch (Exception b)
            {

            }
        }

        protected void dgStaff_Load1(object sender, EventArgs e)
        {

            cmbDepartmentCode.DataSource = bll.GetDepartment();

            cmbDepartmentCode.DataTextField = "Department Name";
            cmbDepartmentCode.DataValueField = "Department Code";
            cmbDepartmentCode.DataBind();

            dgStaff.DataSource = bll.GetStaff();
            cmbStaffType.DataTextField = "Staff Type";
            cmbStaffType.DataValueField = "Staff Type";
            cmbStaffType.DataBind();

            dgStaff.DataSource = bll.GetStaff();
            dgStaff.DataBind();
        }

        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {
                DAL.StaffClass staff = new DAL.StaffClass(txtStaffNo.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, int.Parse(txtContactNumber.Text), cmbStaffType.SelectedValue.ToString(), int.Parse(cmbDepartmentCode.SelectedValue.ToString()), txtUsername.Text, txtPassword.Text, cmbActiveStatus.SelectedValue.ToString());
                int x = bll.AddStaff(staff);


                if (x > 0)
                {
                    txtStaffNo.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                    txtContactNumber.Text = "";
                    cmbStaffType.Text = " ";
                    cmbDepartmentCode.Text = " ";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    cmbActiveStatus.Text = " ";

                }
                else
                {
                }
            }
            catch
            {

            }
            dgStaff.DataSource = bll.GetStaff();
            dgStaff.DataBind();
        }



        protected void btnManageUpdate(object sender, EventArgs e)
        {

            try
            {
                DAL.StaffClass staff = new DAL.StaffClass(txtStaffNo.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, int.Parse(txtContactNumber.Text), cmbStaffType.SelectedValue.ToString(), int.Parse(cmbDepartmentCode.SelectedValue.ToString()), txtUsername.Text, txtPassword.Text, cmbActiveStatus.SelectedValue.ToString());
                int x = bll.UpdateStaff(staff);


                if (x > 0)
                {
                    txtStaffNo.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                    txtContactNumber.Text = "";
                    cmbStaffType.Text = " ";
                    cmbDepartmentCode.Text = " ";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    cmbActiveStatus.Text = " ";

                }
                else
                {

                }
            }
            catch (Exception b)
            {

            }
            dgStaff.DataSource = bll.GetStaff();
            dgStaff.DataBind();

        }
    }
}