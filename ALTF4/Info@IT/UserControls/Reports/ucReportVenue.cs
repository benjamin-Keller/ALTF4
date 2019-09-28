using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportVenue : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public ucReportVenue()
		{
			InitializeComponent();
		}

		private void UcReportVenue_Load(object sender, EventArgs e)
		{
            cmbBuilding.DataSource = bll.LoadCMBBuilding();

            cmbBuilding.DisplayMember = "BuildingName";
            cmbBuilding.ValueMember = "BuildingID";

            cmbBuildingBlock.DataSource = bll.LoadCMBBuildingBlock();

            cmbBuildingBlock.DisplayMember = "BuildingBlock";
            cmbBuildingBlock.ValueMember = "BuildingBlockID";

            dgvVenueReport.DataSource = bll.GetVenues();
        }

        private void cmbBuildingBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.VenueClass venueClass = new DAL.VenueClass();
                venueClass.VenueBuildingBlock = int.Parse(cmbBuildingBlock.SelectedValue.ToString());

                dgvVenueReport.DataSource = bll.Report_DisplayVenueByBuildingBlock(venueClass);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.VenueClass venueClass = new DAL.VenueClass();
                venueClass.VenueBuilding = int.Parse(cmbBuilding.SelectedValue.ToString());

                dgvVenueReport.DataSource = bll.Report_DisplayVenueByBuilding(venueClass);
            }
            catch (Exception b)
            {

            }
        }
    }
}
