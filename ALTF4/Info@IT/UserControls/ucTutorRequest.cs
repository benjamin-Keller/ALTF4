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
	public partial class ucTutorRequest : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucTutorRequest()
		{
			InitializeComponent();
		}

		private void UcTutorRequest_Load(object sender, EventArgs e)
		{
            dgvTutorRequest.DataSource = bll.GetTutorRequest();

            cmbRequestCode.DataSource = bll.GetRequests();

            cmbRequestCode.ValueMember = "RequestCode";
            cmbRequestCode.DisplayMember = "RequestCode";

            cmbVenueCode.DataSource = bll.GetVenues();

            cmbVenueCode.DisplayMember = "VenueDescription";
            cmbVenueCode.ValueMember = "VenueCode";

            cmbModuleCode.DataSource = bll.LoadCMBModels();

            cmbModuleCode.DisplayMember = "ModuleDescription";
            cmbModuleCode.ValueMember = "ModuleCode";

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
                DAL.TutorRequestClass tutorRequest = new DAL.TutorRequestClass(int.Parse(cmbRequestCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), Convert.ToDateTime(cmbStartTime.Text), Convert.ToDateTime(cmbEndTime.Text), int.Parse(cmbModuleCode.SelectedValue.ToString()), int.Parse(cmbVenueCode.SelectedValue.ToString()));

                int x = bll.AddTutorRequest(tutorRequest);

                if (x > 0)
                {
                    cmbStartTime.ResetText();
                    cmbEndTime.ResetText();
                    cmbRequestCode.ResetText();
                    cmbModuleCode.ResetText();
                    cmbVenueCode.ResetText();
                    dateRequest.ResetText();
                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Please Enter a valid Time.");
            }

            

            dgvTutorRequest.DataSource = bll.GetTutorRequest();

        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvTutorRequest.DataSource = bll.GetTutorRequest();
			dgvTutorRequest.BackgroundColor = Color.White;

		}
	}
}
