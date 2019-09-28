using BLL;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Info_IT.UserControls
{
	public partial class ucDepartment : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucDepartment()
		{
			InitializeComponent();
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
                DAL.DepartmentClass dep = new DAL.DepartmentClass(txtName.Text, int.Parse(cmbBuilding.SelectedValue.ToString()), txtContactPerson.Text, txtEmailAddress.Text, txtContactNo.Text);
                int x = bll.AddDepartment(dep);

                if (x > 0)
                {
                    txtName.Clear();
                    txtContactPerson.Clear();
                    txtContactNo.Clear();
                    txtEmailAddress.Clear();
                    cmbBuilding.Text = "";
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

            dgvDepartment.DataSource = bll.GetDepartment();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
            dgvDepartment.DataSource = bll.GetDepartment();
            dgvDepartment.BackgroundColor = Color.White;

            try
            {

                //Error for input string not found
                DAL.DepartmentClass dep = new DAL.DepartmentClass(DAL.DepartmentClass.DepartmentCode, txtName.Text, int.Parse(cmbBuilding.SelectedValue.ToString()), txtContactPerson.Text, txtEmailAddress.Text, txtContactNo.Text);
                int x = bll.UpdateDepartment(dep);

                if (x > 0)
                {
                    txtName.Clear();
                    txtContactPerson.Clear();
                    txtContactNo.Clear();
                    txtEmailAddress.Clear();
                    cmbBuilding.Text = "";
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

            dgvDepartment.DataSource = bll.GetDepartment();
        }

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvDepartment.DataSource = bll.GetDepartment();
			dgvDepartment.BackgroundColor = Color.White;


		}

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			DAL.DepartmentClass depClass = new DAL.DepartmentClass(int.Parse(dgvDepartment.SelectedRows[0].Cells[0].Value.ToString()));

            var values = bll.SelectedForUpdateDepartment(depClass);

            txtName.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
            txtContactPerson.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
            txtEmailAddress.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
            txtContactNo.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();
            
            cmbBuilding.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2];
        }

        private void ucDepartment_Load(object sender, EventArgs e)
        {
            cmbBuilding.DataSource = bll.LoadCMBBuilding();

            cmbBuilding.DisplayMember = "BuildingName";
            cmbBuilding.ValueMember = "BuildingID";

            dgvDepartment.DataSource = bll.GetDepartment();
        }
    }
}
