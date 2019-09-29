using BLL;
using System;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucReportStudent : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucReportStudent()
		{
			InitializeComponent();
		}

		private void UcReportStudent_Load(object sender, EventArgs e)
		{
			dgvStudentReport.DataSource = bll.GetStudent();
		}
	}
}
