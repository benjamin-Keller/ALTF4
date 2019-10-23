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
	}
}