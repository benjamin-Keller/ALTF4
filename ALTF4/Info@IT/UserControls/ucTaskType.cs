using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucTaskType : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucTaskType()
		{
			InitializeComponent();
		}

		private void UcTaskType_Load(object sender, EventArgs e)
		{
			dgvTaskType.DataSource = bll.GetTasktype();
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

			tmrManage.Stop();
		}

		private void TmrView_Tick(object sender, EventArgs e)
		{
			pnlManage.Height = pnlManage.MinimumSize.Height;
			tmrView.Stop();
		}

		private void BtnManageAdd_Click(object sender, EventArgs e)
		{
			try
			{

				DAL.TaskTypeClass task = new DAL.TaskTypeClass(DAL.TaskTypeClass.TaskTypeCode, txtName.Text);
				int x = bll.AddTaskType(task);

				if (x > 0)
				{
					txtName.Clear();
				}
				else
				{
					MessageBox.Show("Please input valid data.");
				}


			}
			catch (Exception b)
			{
				MessageBox.Show("Please input valid data.");
			}
			dgvTaskType.DataSource = bll.GetTasktype();
		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
			dgvTaskType.DataSource = bll.GetTasktype();
			dgvTaskType.BackgroundColor = Color.White;

			try
			{

				DAL.TaskTypeClass task = new DAL.TaskTypeClass(DAL.TaskTypeClass.TaskTypeCode, txtName.Text);
				int x = bll.UpdateTaskType(task);

				if (x > 0)
				{
					txtName.Clear();
				}
				else
				{
					MessageBox.Show("Please input valid data.");
				}


			}
			catch (Exception b)
			{
				MessageBox.Show("Please input valid data.");
			}
			dgvTaskType.DataSource = bll.GetTasktype();
		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvTaskType.DataSource = bll.GetTasktype();
			dgvTaskType.BackgroundColor = Color.White;

		}

		private void dgvTaskType_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DAL.TaskTypeClass taskType = new DAL.TaskTypeClass(int.Parse(dgvTaskType.SelectedRows[0].Cells[0].Value.ToString()));

				var value = bll.SelectedForUpdateTaskType(taskType);

				txtName.Text = value.Rows[0].Table.Rows[0].ItemArray[1].ToString();
			}
			catch (Exception b)
			{

			}
		}
	}
}
