using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucReport : UserControl
	{
		public ucReport()
		{
			InitializeComponent();
		}

		private void UcReport_Load(object sender, EventArgs e)
		{
			HideAll();
		}
		private void InactiveButtons()
		{
			btnEquipmentReport.BackColor = Color.FromName("ControlDark");
			btnEquipmentReport.ForeColor = Color.Black;
			btnVenueReport.BackColor = Color.FromName("ControlDark");
			btnVenueReport.ForeColor = Color.Black;

		}

		private void HideAll()
		{
			ucReportEquipment1.Hide();
			ucReportVenue1.Hide();
		}

		private void BtnEquipmentReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportEquipment1.Show();

			InactiveButtons();
			btnEquipmentReport.BackColor = Color.FromName("ControlDarkDark");
			btnEquipmentReport.ForeColor = Color.White;
		}

		private void BtnVenueReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportVenue1.Show();

			InactiveButtons();
			btnVenueReport.BackColor = Color.FromName("ControlDarkDark");
			btnVenueReport.ForeColor = Color.White;

		}
	}
}
