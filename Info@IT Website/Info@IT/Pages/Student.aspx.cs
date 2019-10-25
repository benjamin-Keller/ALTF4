using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Student : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void dgStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.StudentClass studclass = new DAL.StudentClass(int.Parse(dgStudent.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectedForUpdateStudent(studclass);

                txtStudentNumber.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                txtName.Text = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
                txtSurname.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
                txtEmailAddress.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {
            }

        }

        protected void dgStudent_Load1(object sender, EventArgs e)
		{
			dgStudent.DataSource = bll.GetStudent();
			dgStudent.DataBind();
		}

        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {
                DAL.StudentClass studentClass = new DAL.StudentClass(txtStudentNumber.Text, txtName.Text, txtSurname.Text, txtEmailAddress.Text);
                int x = bll.AddStudent(studentClass);

                if (x > 0)
                {
                    txtStudentNumber.Text = "";
                    txtName.Text = "";
                    txtSurname.Text = "";
                    txtEmailAddress.Text = "";
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
            dgStudent.DataSource = bll.GetStudent();
            dgStudent.DataBind();
        }

        protected void btnManageUpdate(object sender, EventArgs e)
        {
            try
            {
                DAL.StudentClass studentClass = new DAL.StudentClass(DAL.StudentClass.StudentCode, txtStudentNumber.Text, txtName.Text, txtSurname.Text, txtEmailAddress.Text);
                int x = bll.UpdateStudent(studentClass);

                if (x > 0)
                {
                    txtStudentNumber.Text = "";
                    txtName.Text = "";
                    txtSurname.Text = "";
                    txtEmailAddress.Text = "";
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
            dgStudent.DataSource = bll.GetStudent();
            dgStudent.DataBind();
        }
    }
}