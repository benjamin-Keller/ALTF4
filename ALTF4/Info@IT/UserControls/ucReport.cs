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
			btnDepartmentReport.BackColor = Color.FromName("ControlDark");
			btnDepartmentReport.ForeColor = Color.Black;
			btnRequestReport.BackColor = Color.FromName("ControlDark");
			btnRequestReport.ForeColor = Color.Black;
			btnTutorRequestsReport.BackColor = Color.FromName("ControlDark");
			btnTutorRequestsReport.ForeColor = Color.Black;
			btnInspectionReport.BackColor = Color.FromName("ControlDark");
			btnInspectionReport.ForeColor = Color.Black;
			btnInspectionDetailsReport.BackColor = Color.FromName("ControlDark");
			btnInspectionDetailsReport.ForeColor = Color.Black;
			btnStaffReport.BackColor = Color.FromName("ControlDark");
			btnStaffReport.ForeColor = Color.Black;
			btnStudentReport.BackColor = Color.FromName("ControlDark");
			btnStudentReport.ForeColor = Color.Black;
		}

		private void HideAll()
		{
			ucReportEquipment1.Hide();
			ucReportVenue1.Hide();
			ucReportDepartment1.Hide();
			ucReportRequest1.Hide();
			ucReportTutorRequest1.Hide();
			ucReportInspection1.Hide();
			ucReportInspectionDetails1.Hide();
			ucReportStaff1.Hide();
			ucReportStudent1.Hide();
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

		private void BtnDepartmentReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportDepartment1.Show();

			InactiveButtons();
			btnDepartmentReport.BackColor = Color.FromName("ControlDarkDark");
			btnDepartmentReport.ForeColor = Color.White;
		}

		private void BtnRequestReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportRequest1.Show();

			InactiveButtons();
			btnRequestReport.BackColor = Color.FromName("ControlDarkDark");
			btnRequestReport.ForeColor = Color.White;
		}

		private void BtnTutorRequestsReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportTutorRequest1.Show();

			InactiveButtons();
			btnTutorRequestsReport.BackColor = Color.FromName("ControlDarkDark");
			btnTutorRequestsReport.ForeColor = Color.White;
		}

		private void BtnInspectionReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportInspection1.Show();

			InactiveButtons();
			btnInspectionReport.BackColor = Color.FromName("ControlDarkDark");
			btnInspectionReport.ForeColor = Color.White;
		}
		private void BtnInspectionDetailsReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportInspectionDetails1.Show();

			InactiveButtons();
			btnInspectionDetailsReport.BackColor = Color.FromName("ControlDarkDark");
			btnInspectionDetailsReport.ForeColor = Color.White;
		}

		private void BtnStaffReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportStaff1.Show();

			InactiveButtons();
			btnStaffReport.BackColor = Color.FromName("ControlDarkDark");
			btnStaffReport.ForeColor = Color.White;
		}

		private void BtnStudentReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportStudent1.Show();

			InactiveButtons();
			btnStudentReport.BackColor = Color.FromName("ControlDarkDark");
			btnStudentReport.ForeColor = Color.White;
		}

		
	}
}
