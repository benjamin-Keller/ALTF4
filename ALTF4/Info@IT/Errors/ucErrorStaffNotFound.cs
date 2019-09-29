using System;
using System.Windows.Forms;

namespace Info_IT.Errors
{
	public partial class ucErrorStaffNotFound : UserControl
	{
		public ucErrorStaffNotFound()
		{
			InitializeComponent();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
