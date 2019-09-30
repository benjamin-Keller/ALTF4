using BLL;
using System;
using System.Windows.Forms;

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
			cmbBuilding.Text = "";

			cmbBuildingBlock.DataSource = bll.LoadCMBBuildingBlock();

			cmbBuildingBlock.DisplayMember = "BuildingBlock";
			cmbBuildingBlock.ValueMember = "BuildingBlockID";
			cmbBuildingBlock.Text = "";

			dgvVenueReport.DataSource = bll.GetVenues();
		}

		private void cmbBuildingBlock_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                if (cmbBuildingBlock.ValueMember != "")
                {
                    DAL.VenueClass venueClass = new DAL.VenueClass
                    {
                        VenueBuildingBlock = int.Parse(cmbBuildingBlock.SelectedValue.ToString())
                    };

                    dgvVenueReport.DataSource = bll.Report_DisplayVenueByBuildingBlock(venueClass);
                }
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
		{
		try
			{
                if (cmbBuilding.ValueMember != "")
                {
                    DAL.VenueClass venueClass = new DAL.VenueClass
                    {
                        VenueBuilding = int.Parse(cmbBuilding.SelectedValue.ToString())
                    };

                    dgvVenueReport.DataSource = bll.Report_DisplayVenueByBuilding(venueClass);
                }
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void BtnRemoveFilter_Click(object sender, EventArgs e)
		{
            dgvVenueReport.DataSource = bll.GetVenues();
        }
	}
}
