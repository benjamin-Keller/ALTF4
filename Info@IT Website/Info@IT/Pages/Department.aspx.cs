using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Department : System.Web.UI.Page
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{
            cmbBuilding.DataSource = bll.LoadCMBBuilding();
            cmbBuilding.DataTextField = "BuildingName";
            cmbBuilding.DataValueField = "BuildingID";
            cmbBuilding.DataBind();
		}
        
        protected void dgDepartment_Load(object sender, EventArgs e)
        {
            dgDepartment.DataSource = bll.GetDepartment();
            dgDepartment.DataBind();
        }

        protected void dgDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgDepartment_Load1(object sender, EventArgs e)
        {
            dgDepartment.DataSource = bll.GetDepartment();
            dgDepartment.DataBind();
        }

        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {
                //Error for input string not found
                DAL.DepartmentClass dep = new DAL.DepartmentClass(txtName.Text, int.Parse(cmbBuilding.SelectedItem.Value), txtContactPerson.Text, txtEmailAddress.Text, txtContactNo.Text);
                int x = bll.AddDepartment(dep);

                if (x > 0)
                {
                    txtName.Text = "";
                    txtContactPerson.Text = "";
                    txtContactNo.Text = "";
                    txtEmailAddress.Text = "";
                    cmbBuilding.Text = "";
                }
                else
                {
                    
                }
            }
            catch(Exception b)
            {
                
            }

            dgDepartment.DataSource = bll.GetDepartment();
            dgDepartment.DataBind();

        }

        private void BtnManageUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                //Error for input string not found
                DAL.DepartmentClass dep = new DAL.DepartmentClass(DAL.DepartmentClass.DepartmentCode, txtName.Text, int.Parse(cmbBuilding.SelectedValue.ToString()), txtContactPerson.Text, txtEmailAddress.Text, txtContactNo.Text);
                int x = bll.UpdateDepartment(dep);

                if (x > 0)
                {
                    txtName.Text = "";
                    txtContactPerson.Text = "";
                    txtContactNo.Text = "";
                    txtEmailAddress.Text = "";
                    cmbBuilding.Text = "";
                }
                else
                {
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {
            }

            dgDepartment.DataSource = bll.GetDepartment();
            dgDepartment.DataBind();
        }

        private void dgvDepartment_CellClick(object sender, EventArgs e)
        {
            
        }

        protected void dgDepartment_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {
                
                DAL.DepartmentClass depClass = new DAL.DepartmentClass(int.Parse(dgDepartment.SelectedItem.Cells[0].Text.ToString()));

                var values = bll.SelectedForUpdateDepartment(depClass);

                txtName.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                txtContactPerson.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
                txtEmailAddress.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                txtContactNo.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

                cmbBuilding.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void dgDepartment_EditCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {

                DAL.DepartmentClass depClass = new DAL.DepartmentClass(int.Parse(dgDepartment.SelectedItem.Cells[0].Text.ToString()));

                var values = bll.SelectedForUpdateDepartment(depClass);

                txtName.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                txtContactPerson.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
                txtEmailAddress.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                txtContactNo.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

                cmbBuilding.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }
    }
}