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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //lock input fields when page loads
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            cmbRole.Items.Add("Student");
            cmbRole.Items.Add("Student Assistant");
            cmbRole.Items.Add("Info@IT Staff");
            cmbRole.Items.Add("ICT Helpdesk Staff");
        }

        //enable input fields when a role is selected
        private void cmbRole_TextChanged(object sender, EventArgs e)
        {
            if (cmbRole.Text != "")
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
