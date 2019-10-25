using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Equipment : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void dgEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.EquipmentClass equipmentClass = new DAL.EquipmentClass(int.Parse(dgEquipment.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectedForUpdateEquipment(equipmentClass);

                txtDescription.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();

                cmbVenue.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
                cmbEquipType.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

        protected void dgEquipment_Load1(object sender, EventArgs e)
        {
            cmbEquipType.DataSource = bll.GetEquipmentType();

            cmbEquipType.DataTextField = "Type";
            cmbEquipType.DataValueField = "Equipment Type Code";
            cmbEquipType.DataBind();

            cmbVenue.DataSource = bll.GetVenues();

            cmbVenue.DataTextField = "Venue";
            cmbVenue.DataValueField = "Venue Code";
            cmbVenue.DataBind();

            dgEquipment.DataSource = bll.GetEquipment();
            dgEquipment.DataBind();
        }

        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {

                DAL.EquipmentClass equipmentClass = new DAL.EquipmentClass(txtDescription.Text, int.Parse(cmbVenue.SelectedValue.ToString()), int.Parse(cmbEquipType.SelectedValue.ToString()));

                int x = bll.AddEquipment(equipmentClass);

                if (x > 0)
                {
                    txtDescription.Text = "";
                    cmbVenue.Text = "";
                    cmbEquipType.Text = "";
                }
                else
                {
                }
            }
            catch
            {
            }

            dgEquipment.DataSource = bll.GetEquipment();
            dgEquipment.DataBind();
        }

        protected void btnManageUpdate(object sender, EventArgs e)
        {

            try
            {

                //Error for input string not found
                DAL.EquipmentClass equipment = new DAL.EquipmentClass(DAL.EquipmentClass.EquipmentCode, txtDescription.Text, int.Parse(cmbVenue.SelectedValue.ToString()), int.Parse(cmbEquipType.SelectedValue.ToString()));
                int x = bll.UpdateEquipment(equipment);

                if (x > 0)
                {
                    txtDescription.Text = "";
                    cmbVenue.Text = "";
                    cmbEquipType.Text = "";
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

            dgEquipment.DataSource = bll.GetEquipment();
            dgEquipment.DataBind();
        }
    }
}