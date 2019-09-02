using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Template : Form
	{
		public Template()
		{
			InitializeComponent();
		}

		private void BtnNavigation_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tabNavigation;
		}

		private void BtnManage_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tabManage;
		}

		private void BtnView_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tabView;

		}

		private void Template_Resize(object sender, EventArgs e)
		{
			tabControl.Height = this.Height;
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.TopLevel = false;
			h.AutoScroll = true;
			this.pnlForm.Controls.Add(h);
			h.Show();
		}
	}
}
