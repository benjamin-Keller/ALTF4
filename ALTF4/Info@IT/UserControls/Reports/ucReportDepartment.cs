using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportDepartment : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucReportDepartment()
		{
			InitializeComponent();
		}

		private void UcReportDepartment_Load(object sender, EventArgs e)
		{
			cmbBuilding.DataSource = bll.LoadCMBBuilding();

			cmbBuilding.DisplayMember = "BuildingName";
			cmbBuilding.ValueMember = "BuildingID";
			cmbBuilding.Text = "";

			dgvDepartmentReport.DataSource = bll.GetDepartment();
		}

		private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DAL.DepartmentClass department = new DAL.DepartmentClass();
				department.Building = int.Parse(cmbBuilding.SelectedValue.ToString());

				dgvDepartmentReport.DataSource = bll.Report_DislayDepartmentByBuilding(department);
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}
	}
}
