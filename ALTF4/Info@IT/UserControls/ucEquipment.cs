using BLL;
using System;
using System.Windows.Forms;
using System.Drawing;


namespace Info_IT.UserControls
{
	public partial class UcEquipment : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public UcEquipment()
		{
			InitializeComponent();
		}
		private void UcEquipment_Load(object sender, EventArgs e)
		{
			ucEquipmentType1.Hide();

            cmbEquipTypeCode.DataSource = bll.GetEquipmentType();
            cmbEquipTypeCode.DisplayMember = "TypeDescription";
            cmbEquipTypeCode.ValueMember = "EquipTypeCode";

            cmbVenue.DataSource = bll.GetVenues();
            cmbVenue.DisplayMember = "VenueDescription";
            cmbVenue.ValueMember = "VenueCode";

            dgvEquipment.DataSource = bll.GetEquipment();
        }
		private void CmbEquipTypeCode_SelectedIndexChanged(object sender, EventArgs e)
		{

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


		//Sub-Nav buttons
		private void BtnManageAdd_Click(object sender, EventArgs e)
		{
            try { 

                DAL.EquipmentClass equipmentClass = new DAL.EquipmentClass(txtDescription.Text, int.Parse(cmbVenue.SelectedValue.ToString()), int.Parse(cmbEquipTypeCode.SelectedValue.ToString()));

                int x = bll.AddEquipment(equipmentClass);

                if (x > 0)
                {
                    txtDescription.Clear();
                    cmbVenue.ValueMember = "";
                    cmbEquipTypeCode.ValueMember = "";
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

            dgvEquipment.DataSource = bll.GetEquipment();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{

            dgvEquipment.DataSource = bll.GetEquipment();
        }

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvEquipment.DataSource = bll.GetEquipment();
			dgvEquipment.BackgroundColor = Color.White;
		}

		private void BtnViewEquipmentTypes_Click(object sender, EventArgs e)
		{
			ucEquipmentType1.Show();
		}
	}
}
