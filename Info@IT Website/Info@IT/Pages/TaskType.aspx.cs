using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class TaskType : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void dgTaskType_SelectedIndexChanged(object sender, EventArgs e)
		{
            try
            {
                DAL.TaskTypeClass taskType = new DAL.TaskTypeClass(int.Parse(dgTaskType.SelectedItem.Cells[1].Text.ToString()));

                var value = bll.SelectedForUpdateTaskType(taskType);

                txtName.Text = value.Rows[0].Table.Rows[0].ItemArray[1].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }


        }

		protected void dgTaskType_Load1(object sender, EventArgs e)
		{
			dgTaskType.DataSource = bll.GetTasktype();
			dgTaskType.DataBind();
		}
        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {

                DAL.TaskTypeClass task = new DAL.TaskTypeClass(DAL.TaskTypeClass.TaskTypeCode, txtName.Text);
                int x = bll.AddTaskType(task);

                if (x > 0)
                {
                    txtName.Text = " ";
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
            dgTaskType.DataSource = bll.GetTasktype();
            dgTaskType.DataBind();
        }
        protected void btnManageUpdate (object sender, EventArgs e)
        {
            try
            {

                DAL.TaskTypeClass task = new DAL.TaskTypeClass(DAL.TaskTypeClass.TaskTypeCode,txtName.Text);
                int x = bll.UpdateTaskType(task);

                if (x > 0)
                {
                    txtName.Text = " ";
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
            dgTaskType.DataSource = bll.GetTasktype();
            dgTaskType.DataBind();
        }
    }
}