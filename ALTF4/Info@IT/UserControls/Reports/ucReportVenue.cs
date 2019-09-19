using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportVenue : UserControl
	{
		public ucReportVenue()
		{
			InitializeComponent();
		}

		private void BtnCloseDetails_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void UcReportVenue_Load(object sender, EventArgs e)
		{

		}
	}
}
