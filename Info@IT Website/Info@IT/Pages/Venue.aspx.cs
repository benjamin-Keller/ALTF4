using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Venue : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void dgVenue_SelectedIndexChanged(object sender, EventArgs e)
		{
            try
            {

                DAL.VenueClass venue = new DAL.VenueClass(int.Parse(dgVenue.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectedForUpdateVenue(venue);


                txtDescription.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                txtCapacity.Text = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
                txtDoorNumber.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();

                cmbBuildingBlocks.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                cmbBuilding.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {

            }
        }

		protected void dgVenue_Load1(object sender, EventArgs e)
		{
            cmbBuilding.DataSource = bll.LoadCMBBuilding();

            cmbBuilding.DataTextField = "BuildingName";
            cmbBuilding.DataValueField = "BuildingID";
            cmbBuilding.DataBind();

            cmbBuildingBlocks.DataSource = bll.LoadCMBBuildingBlock();

            cmbBuildingBlocks.DataTextField = "BuildingBlock";
            cmbBuildingBlocks.DataValueField = "BuildingBlockID";
            cmbBuildingBlocks.DataBind();

            dgVenue.DataSource = bll.GetVenues();
			dgVenue.DataBind();
		}

		protected void dgVenue_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
		{

		}

        protected void btnManageAdd(object sender, EventArgs e)
        {
            try
            {
                //Error for input string not found
                DAL.VenueClass venue = new DAL.VenueClass(txtDescription.Text, int.Parse(txtCapacity.Text), int.Parse(txtDoorNumber.Text), int.Parse(cmbBuildingBlocks.SelectedValue.ToString()), int.Parse(cmbBuilding.SelectedValue.ToString()));
                int x = bll.AddVenue(venue);

                if (x > 0)
                {
                    txtDescription.Text = "";
                    txtCapacity.Text = "";
                    txtDoorNumber.Text = "";
                    cmbBuildingBlocks.Text = "";
                    cmbBuilding.Text = "";
                }
                else
                {
                }
            }
            catch
            {
            }

            dgVenue.DataSource = bll.GetVenues();
            dgVenue.DataBind();
        }

        protected void btnManageUpdate(object sender, EventArgs e)
        {
            try
            {

                //Error for input string not found
                DAL.VenueClass venue = new DAL.VenueClass(DAL.VenueClass.VenueCode, txtDescription.Text, int.Parse(txtCapacity.Text), int.Parse(txtDoorNumber.Text), int.Parse(cmbBuildingBlocks.SelectedValue.ToString()), int.Parse(cmbBuilding.SelectedValue.ToString()));
                int x = bll.UpdateVenue(venue);

                if (x > 0)
                {
                    txtDescription.Text = "";
                    txtCapacity.Text = "";
                    txtDoorNumber.Text = "";
                    cmbBuildingBlocks.Text = "";
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

            dgVenue.DataSource = bll.GetVenues();
            dgVenue.DataBind();
        }
    }
}