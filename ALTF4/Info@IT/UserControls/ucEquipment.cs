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

		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvEquipment.DataSource = bll.GetEquipment();
			dgvEquipment.BackgroundColor = Color.White;
		}

		
	}
}
