using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucReportStaff : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucReportStaff()
		{
			InitializeComponent();
		}

		private void UcReportStaff_Load(object sender, EventArgs e)
		{
			dgvStaffReport.DataSource = bll.GetStaff();

			cmbDepartmentCode.DataSource = bll.GetDepartment();

			cmbDepartmentCode.DisplayMember = "DepartmentName";
			cmbDepartmentCode.ValueMember = "DepartmentCode";
			cmbDepartmentCode.Text = "";
		}

		private void cmbStaffType_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.StaffClass staff = new DAL.StaffClass();
				staff.StaffType = cmbStaffType.SelectedItem.ToString();

				dgvStaffReport.DataSource = bll.Report_DisplayStaffByStaffType(staff);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void cmbDepartmentCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.StaffClass staff = new DAL.StaffClass();
				staff.DepartmentCode = int.Parse(cmbDepartmentCode.SelectedValue.ToString());

				dgvStaffReport.DataSource = bll.Report_DisplayStaffByDepartment(staff);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void BtnRemoveFilter_Click(object sender, EventArgs e)
		{

		}
	}
}
