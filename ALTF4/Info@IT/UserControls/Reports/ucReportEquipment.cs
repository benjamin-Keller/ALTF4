﻿using BLL;
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
			dgvEquipmentReport.DataSource = bll.GetEquipment();

			cmbEquipType.DataSource = bll.GetEquipmentType();
			cmbEquipType.DisplayMember = "TypeDescription";
			cmbEquipType.ValueMember = "EquipTypeCode";
			cmbEquipType.Text = "";

			cmbVenue.DataSource = bll.GetVenues();
			cmbVenue.DisplayMember = "VenueDescription";
			cmbVenue.ValueMember = "VenueCode";
			cmbVenue.Text = "";
		}

		private void cmbEquipType_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.EquipmentClass equipment = new DAL.EquipmentClass();
				equipment.EquipTypeCode = int.Parse(cmbEquipType.SelectedValue.ToString());

				dgvEquipmentReport.DataSource = bll.Report_DisplayEquipmentByEquipmentType(equipment);
			}
			catch (Exception b)
			{

			}
		}

		private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.EquipmentClass equipment = new DAL.EquipmentClass();
				equipment.VenueCode = int.Parse(cmbVenue.SelectedValue.ToString());

				dgvEquipmentReport.DataSource = bll.Report_DisplayEquipmentByVenue(equipment);
			}
			catch (Exception b)
			{

			}
		}
	}
}
