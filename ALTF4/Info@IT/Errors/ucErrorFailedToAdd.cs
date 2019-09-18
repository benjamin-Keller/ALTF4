using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT.Errors
{
	public partial class ucErrorFailedToAdd : UserControl
	{
		public ucErrorFailedToAdd()
		{
			InitializeComponent();
		}

		public string _Data { get; set; }

		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		public ucErrorFailedToAdd(string Data)
		{
			_Data = Data;
		}

		private void UcErrorFailedToAdd_Load(object sender, EventArgs e)
		{
			lblData.Text = _Data;
			lblDataSub.Text = "Failed to add " + _Data + " To the Database";
		}
	}
}
