using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportEquipment : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucReportEquipment()
		{
			InitializeComponent();
		}

		private void UcReportEquipment_Load(object sender, EventArgs e)
		{
			

			cmbEquipType.DataSource = bll.GetEquipmentType();
			cmbEquipType.DisplayMember = "TypeDescription";
			cmbEquipType.ValueMember = "EquipTypeCode";
			cmbEquipType.Text = "";

			cmbVenue.DataSource = bll.GetVenues();
			cmbVenue.DisplayMember = "VenueDescription";
			cmbVenue.ValueMember = "VenueCode";
			cmbVenue.Text = "";

            dgvEquipmentReport.DataSource = bll.GetEquipment();
        }

		private void cmbEquipType_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                DAL.EquipmentClass equipment = new DAL.EquipmentClass
                {
                    EquipTypeCode = int.Parse(cmbEquipType.SelectedValue.ToString())
                };

                dgvEquipmentReport.DataSource = bll.Report_DisplayEquipmentByEquipmentType(equipment);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                DAL.EquipmentClass equipment = new DAL.EquipmentClass
                {
                    VenueCode = int.Parse(cmbVenue.SelectedValue.ToString())
                };

                dgvEquipmentReport.DataSource = bll.Report_DisplayEquipmentByVenue(equipment);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void BtnRemoveFilter_Click(object sender, EventArgs e)
		{
            dgvEquipmentReport.DataSource = bll.GetEquipment();
			cmbEquipType.Text = "";
			cmbVenue.Text = "";
        }
	}
}
