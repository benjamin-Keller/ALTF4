using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Info_IT.UserControls
{
	public partial class ucEquipmentType : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public ucEquipmentType()
		{
			InitializeComponent();
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
                DAL.EquipmentTypeClass equipment = new DAL.EquipmentTypeClass(txtEquipmentType.Text);
                int x = bll.AddEquipmentType(equipment);

                if (x > 0)
                {
                    txtEquipmentType.Clear();
                    
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

            dgvEquipmentDetails.DataSource = bll.GetEquipmentType();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
            dgvEquipmentDetails.DataSource = bll.GetEquipmentType();
        }
	}
}
