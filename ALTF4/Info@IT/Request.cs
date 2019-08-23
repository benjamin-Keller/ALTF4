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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void updateSelectedRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

		private void Request_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}
	}
}
