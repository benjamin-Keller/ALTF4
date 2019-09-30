﻿using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportInspection : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucReportInspection()
		{
			InitializeComponent();
		}

		private void UcReportInspection_Load(object sender, EventArgs e)
		{
			cmbVenueCode.DataSource = bll.GetVenues();

			cmbVenueCode.DisplayMember = "VenueDescription";
			cmbVenueCode.ValueMember = "VenueCode";
			cmbVenueCode.Text = "";

			cmbStaffCode.DataSource = bll.GetStaff();

			cmbStaffCode.DisplayMember = "FirstName";
			cmbStaffCode.ValueMember = "StaffCode";
			cmbStaffCode.Text = "";

			dgvInspectionReport.DataSource = bll.GetInspection();
		}

		private void dateInspection_ValueChanged(object sender, EventArgs e)
		{
			try
			{
                DAL.InspectionClass inspection = new DAL.InspectionClass
                {
                    InspectionDate = Convert.ToDateTime(dateInspection.Text)
                };

                dgvInspectionReport.DataSource = bll.Report_DisplayInspectionByDate(inspection);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbVenueCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                DAL.InspectionClass inspection = new DAL.InspectionClass
                {
                    VenueCode = int.Parse(cmbVenueCode.SelectedValue.ToString())
                };

                dgvInspectionReport.DataSource = bll.Report_DisplayInspectionByVenue(inspection);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbStaffCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                DAL.InspectionClass inspection = new DAL.InspectionClass
                {
                    StaffCode = int.Parse(cmbStaffCode.SelectedValue.ToString())
                };

                dgvInspectionReport.DataSource = bll.Report_DisplayInspectionByStaffCode(inspection);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void BtnRemoveFilter_Click(object sender, EventArgs e)
		{
            dgvInspectionReport.DataSource = bll.GetInspection();
			cmbVenueCode.Text = "";
			cmbStaffCode.Text = "";

		}
	}
}
