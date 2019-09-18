﻿using BLL;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Info_IT.UserControls
{
	public partial class ucVenue : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucVenue()
		{
			InitializeComponent();
		}

		private void UcVenue_Load(object sender, EventArgs e)
		{
            cmbBuilding.DataSource = bll.LoadCMBBuilding();
            
            cmbBuilding.DisplayMember = "BuildingName";
            cmbBuilding.ValueMember = "BuildingID";
            
            cmbBuildingBlock.DataSource = bll.LoadCMBBuildingBlock();
            
            cmbBuildingBlock.DisplayMember = "BuildingBlock";
            cmbBuildingBlock.ValueMember = "BuildingBlockID";
            
            dgvVenue.DataSource = bll.GetVenues();
        }

		//Menu button (Manage)
		private void BtnManage_Click(object sender, EventArgs e)
		{
			tmrManage.Start();
			if (!(pnlManage.Height == pnlManage.MinimumSize.Height))
			{
				pnlManage.Height = pnlManage.MinimumSize.Height;
				tmrManage.Enabled = false;
			}
		}
		private void TmrManage_Tick(object sender, EventArgs e)
		{
			pnlManage.Height = pnlManage.MaximumSize.Height;
			pnlView.Height = pnlView.MinimumSize.Height;

			tmrManage.Stop();
		}

		//Menu button (View)
		private void BtnView_Click(object sender, EventArgs e)
		{
			tmrView.Start();
			if (!(pnlView.Height == pnlView.MinimumSize.Height))
			{
				pnlView.Height = pnlView.MinimumSize.Height;
				tmrView.Enabled = false;
			}
		}
		private void TmrView_Tick(object sender, EventArgs e)
		{
			pnlView.Height = pnlView.MaximumSize.Height;
			pnlManage.Height = pnlManage.MinimumSize.Height;
			tmrView.Stop();
		}

		private void BtnManageAdd_Click(object sender, EventArgs e)
		{
            try
            {


                //Error for input string not found
                DAL.VenueClass venue = new DAL.VenueClass(txtDescription.Text, int.Parse(txtCapacity.Text), int.Parse(txtDoorNo.Text), int.Parse(cmbBuildingBlock.SelectedValue.ToString()), int.Parse(cmbBuilding.SelectedIndex.ToString()));
                int x = bll.AddVenue(venue);

                if (x > 0)
                {
                    txtDescription.Clear();
                    txtCapacity.Clear();
                    txtDoorNo.Clear();
                    cmbBuildingBlock.ValueMember = "";
                    cmbBuilding.ValueMember = "";
                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }
            }
            catch
            {
                MessageBox.Show("Please input valid data.");
            }

            dgvVenue.DataSource = bll.GetVenues();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
            dgvVenue.DataSource = bll.GetVenues();
			dgvVenue.BackgroundColor = Color.White;

            try
            {


                //Error for input string not found
                DAL.VenueClass venue = new DAL.VenueClass(txtDescription.Text, int.Parse(txtCapacity.Text), int.Parse(txtDoorNo.Text), int.Parse(cmbBuildingBlock.SelectedValue.ToString()), int.Parse(cmbBuilding.SelectedIndex.ToString()));
                int x = bll.AddVenue(venue);

                if (x > 0)
                {
                    txtDescription.Clear();
                    txtCapacity.Clear();
                    txtDoorNo.Clear();
                    cmbBuildingBlock.ValueMember = "";
                    cmbBuilding.ValueMember = "";
                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }
            }
            catch
            {
                MessageBox.Show("Please input valid data.");
            }

            dgvVenue.DataSource = bll.GetVenues();

        }

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvVenue.DataSource = bll.GetVenues();
			dgvVenue.BackgroundColor = Color.White;

		}

        private void dgvVenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescription.Text = dgvVenue.SelectedRows[0].Cells[1].Value.ToString();
            txtCapacity.Text = dgvVenue.SelectedRows[0].Cells[2].Value.ToString();
            txtDoorNo.Text = dgvVenue.SelectedRows[0].Cells[3].Value.ToString();
            cmbBuilding.SelectedText = dgvVenue.SelectedRows[0].Cells[4].Value.ToString();
            cmbBuildingBlock.SelectedText = dgvVenue.SelectedRows[0].Cells[5].Value.ToString();


        }
    }
}
