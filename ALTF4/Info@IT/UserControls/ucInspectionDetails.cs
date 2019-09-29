using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace Info_IT.UserControls
{
	public partial class ucInspectionDetails : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucInspectionDetails()
		{
			InitializeComponent();
		}
		private void UcInspectionDetails_Load(object sender, EventArgs e)
		{
            cmbEquipmentCode.DataSource = bll.GetEquipment();

            cmbEquipmentCode.DisplayMember = "EquipmentDescription";
            cmbEquipmentCode.ValueMember = "Equipmentcode";

            cmbStaffCode.DataSource = bll.GetStaff();

            cmbStaffCode.DisplayMember = "FirstName";
            cmbStaffCode.ValueMember = "StaffCode";

            cmbInspectionCode.DataSource = bll.GetInspection();

            cmbInspectionCode.DisplayMember = "InspectionCode";
            cmbInspectionCode.ValueMember = "InspectionCode";
            
            dgvInspectionDetails.DataSource = bll.GetInspectionDetail();
        }

		private void BtnCloseDetails_Click(object sender, EventArgs e)
		{
			this.Hide();
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
                DAL.InspectionDetailClass inspection = new DAL.InspectionDetailClass(int.Parse(cmbInspectionCode.SelectedValue.ToString()), int.Parse(cmbEquipmentCode.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()), txtFaultComment.Text, cmbStatus.SelectedText.ToString());
                int x = bll.AddInspectionDetail(inspection);

                if (x > 0)
                {
                    txtFaultComment.Clear();
                    cmbEquipmentCode.ValueMember = "";
                    cmbInspectionCode.ValueMember = "";
                    cmbStaffCode.ValueMember = "";
                    cmbStatus.ValueMember = "";
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

            dgvInspectionDetails.DataSource = bll.GetInspectionDetail();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
            dgvInspectionDetails.DataSource = bll.GetInspectionDetail();
            dgvInspectionDetails.BackgroundColor = Color.White;

            try
            {
                //Error for input string not found
                DAL.InspectionDetailClass inspection = new DAL.InspectionDetailClass(DAL.InspectionDetailClass.InspectionDetailCode, int.Parse(cmbInspectionCode.SelectedValue.ToString()), int.Parse(cmbEquipmentCode.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()), txtFaultComment.Text, cmbStatus.Text.ToString());
                int x = bll.UpdateInspectionDetail(inspection);

                if (x > 0)
                {
                    txtFaultComment.Clear();
                    cmbEquipmentCode.ValueMember = "";
                    cmbInspectionCode.ValueMember = "";
                    cmbStaffCode.ValueMember = "";
                    cmbStatus.ValueMember = "";
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

            dgvInspectionDetails.DataSource = bll.GetInspectionDetail();
        }

		private void BtnViewList_Click(object sender, EventArgs e)
		{
            dgvInspectionDetails.DataSource = bll.GetInspectionDetail();
            dgvInspectionDetails.BackgroundColor = Color.White;
        }

        private void dgvinspectionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {  
            try
            {
                DAL.InspectionDetailClass inspectionDetailClass = new DAL.InspectionDetailClass(int.Parse(dgvInspectionDetails.SelectedRows[0].Cells[0].Value.ToString()));

                var values = bll.SelectedForUpdateInspectionDetail(inspectionDetailClass);

                txtFaultComment.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();

                cmbInspectionCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[1];
                cmbEquipmentCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2];
                cmbStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[3];
                cmbStatus.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();
            }
            catch (Exception b)
            {

            }
        }
    }
}