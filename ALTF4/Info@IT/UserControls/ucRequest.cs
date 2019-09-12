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
	public partial class ucRequest : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucRequest()
		{
			InitializeComponent();
		}
		private void UcRequest_Load(object sender, EventArgs e)
		{
			dateRequest.Value = DateTime.Now;

            //dgvRequest.DataSource = bll.GetRequests();

            cmbTaskTypeCode.DataSource = bll.GetTasktype();
            
            cmbTaskTypeCode.DisplayMember = "TaskName";
            cmbTaskTypeCode.ValueMember = "taskTypeCode";

            cmbAssignedStaffCode.DataSource = bll.GetStaff();

            cmbAssignedStaffCode.DisplayMember = "FirstName";
            cmbAssignedStaffCode.ValueMember = "StaffCode";

            cmbStaffCode.DataSource = bll.GetStaff();

            cmbStaffCode.DisplayMember = "FirstName";
            cmbStaffCode.ValueMember = "StaffCode";

            cmbStudentCode.DataSource = bll.GetStudent();

            cmbStudentCode.DisplayMember = "FirstName";
            cmbStudentCode.ValueMember = "StudentCode";


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
            DAL.RequestClass request = new DAL.RequestClass(txtDescription.Text, int.Parse(cmbStaffCode.SelectedValue.ToString()), int.Parse(cmbStudentCode.SelectedValue.ToString()), int.Parse(cmbTaskTypeCode.SelectedValue.ToString()), dateRequest.ToString(), int.Parse(txtTime.Text), int.Parse(cmbAssignedStaffCode.SelectedValue.ToString()), "Pending");

            int x = bll.AddRequest(request);

            if (x > 0)
            {
                txtDescription.Clear();
                txtTime.Clear();
                cmbStaffCode.ResetText();
                cmbStudentCode.ResetText();
                cmbTaskTypeCode.ResetText();
                dateRequest.ResetText();
            }
            else
            {
                MessageBox.Show("Please input valid data.");
            }

            dgvRequest.DataSource = bll.GetTutorRequest();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvRequest.DataSource = bll.GetRequests();
			dgvRequest.BackgroundColor = Color.White;

		}
	}
}
