using System;
using System.Windows.Forms;

namespace Info_IT.Errors
{
	public partial class ucErrorStudentNotFound : UserControl
	{
		public ucErrorStudentNotFound()
		{
			InitializeComponent();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Hide();

		}
	}
}
