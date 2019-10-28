using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class EquipmentDetails : System.Web.UI.Page
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
        protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void dgEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.EquipmentTypeClass equipmentTypeClass = new DAL.EquipmentTypeClass(int.Parse(dgEquipmentType.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectedForUpdateEquipmentType(equipmentTypeClass);

                txtDescription.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void dgEquipmentType_Load1(object sender, EventArgs e)
        {
            dgEquipmentType.DataSource = bll.GetEquipmentType();
            dgEquipmentType.DataBind();
        }
        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {


                //Error for input string not found
                DAL.EquipmentTypeClass equipment = new DAL.EquipmentTypeClass(txtDescription.Text);
                int x = bll.AddEquipmentType(equipment);

                if (x > 0)
                {
                    txtDescription.Text = "";
                }
                else
                {
                }
            }
            catch
            {
            }

            dgEquipmentType.DataSource = bll.GetEquipmentType();
            dgEquipmentType.DataBind();
        }

        protected void btnManageUpdate(object sender, EventArgs e)
        {
            try
			{
				DAL.EquipmentTypeClass equipment = new DAL.EquipmentTypeClass(DAL.EquipmentTypeClass.EquipTypeCode, txtDescription.Text);
				int x = bll.UpdateEquipmentType(equipment);

				if (x > 0)
				{
                    txtDescription.Text = "";
				}
				else
				{
				}
			}
			catch
			{
			}

            dgEquipmentType.DataSource = bll.GetEquipmentType();
            dgEquipmentType.DataBind();
        }
    }
}