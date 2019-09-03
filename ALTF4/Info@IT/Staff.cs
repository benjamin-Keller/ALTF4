using System;
using System.Windows.Forms;
using BLL;

namespace Info_IT
{
	public partial class Staff : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public Staff()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Home h = new Home();
			h.Show();
			this.Hide();
		}

		private void Staff_FormClosing(object sender, FormClosingEventArgs e)
		{
			Home home = new Home();
			home.Show();
		}

		private void Staff_Load(object sender, EventArgs e)
		{
			cmbStaffType.Items.Add("Student Assistant");
			cmbStaffType.Items.Add("Info@IT Staff");
			cmbStaffType.Items.Add("ICT Helpdesk Staff");
            dgvStaff.DataSource = bll.GetStaff();

        }
    }
}
