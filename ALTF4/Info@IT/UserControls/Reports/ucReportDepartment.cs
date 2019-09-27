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
            catch(Exception b)
            {

            }
        }
    }
}
