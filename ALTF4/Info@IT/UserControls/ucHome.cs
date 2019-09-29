using System;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucHome : UserControl
	{

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public ucHome()
		{
			InitializeComponent();
		}

		private void UcHome_Load(object sender, EventArgs e)
		{

		}
	}
}
