using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucStaff : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucStaff()
		{
			InitializeComponent();
		}

		private void UcStaff_Load(object sender, EventArgs e)
		{
			dgvStaff.DataSource = bll.GetStaff();

			cmbDepartmentCode.DataSource = bll.GetDepartment();

			cmbDepartmentCode.DisplayMember = "DepartmentName";
			cmbDepartmentCode.ValueMember = "DepartmentCode";

			cmbStaffType.DisplayMember = "StaffType";
			cmbStaffType.ValueMember = "StaffCode";

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
				DAL.StaffClass staff = new DAL.StaffClass(int.Parse(txtStaffNumber.Text), txtName.Text, txtSurname.Text, txtEmailAddress.Text, int.Parse(txtContactNo.Text), cmbStaffType.SelectedValue.ToString(), int.Parse(cmbDepartmentCode.SelectedValue.ToString()));
				int x = bll.AddStaff(staff);


				if (x > 0)
				{
					txtStaffNumber.Clear();
					txtName.Clear();
					txtSurname.Clear();
					txtEmailAddress.Clear();
					txtContactNo.Clear();
					cmbStaffType.Text = " ";
					cmbDepartmentCode.Text = " ";


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
			dgvStaff.DataSource = bll.GetStaff();
		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
			dgvStaff.DataSource = bll.GetStaff();
			dgvStaff.BackgroundColor = Color.White;

			try
			{
				DAL.StaffClass staff = new DAL.StaffClass(int.Parse(txtStaffNumber.Text), txtName.Text, txtSurname.Text, txtEmailAddress.Text, int.Parse(txtContactNo.Text), cmbStaffType.SelectedValue.ToString(), int.Parse(cmbDepartmentCode.SelectedValue.ToString()));
				int x = bll.UpdateStaff(staff);


				if (x > 0)
				{
					txtStaffNumber.Clear();
					txtName.Clear();
					txtSurname.Clear();
					txtEmailAddress.Clear();
					txtContactNo.Clear();
					cmbStaffType.Text = " ";
					cmbDepartmentCode.Text = " ";


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
			dgvStaff.DataSource = bll.GetStaff();


		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvStaff.DataSource = bll.GetStaff();
			dgvStaff.BackgroundColor = Color.White;

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dgvStaffExUser_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DAL.StaffClass staffClass = new DAL.StaffClass(int.Parse(dgvStaff.SelectedRows[0].Cells[0].Value.ToString()));

				var values = bll.SelectForUpdateStaffExUser(staffClass);

				txtStaffNumber.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
				txtName.Text = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
				txtSurname.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
				txtEmailAddress.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
				txtContactNo.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

				cmbStaffType.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[6];
				cmbDepartmentCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[7];
			}
			catch (Exception b)
			{

			}


		}
	}


}
