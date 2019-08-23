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
    public partial class EquipmentType : Form
    {
        public EquipmentType()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

		private void EquipmentType_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}
	}
}
