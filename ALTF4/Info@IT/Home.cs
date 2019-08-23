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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venue ven = new Venue();
            ven.Show();
            this.Hide();
		}

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
            this.Hide();
        }

        private void btnEquipmentType_Click(object sender, EventArgs e)
        {
            EquipmentType eqT = new EquipmentType();
            eqT.Show();
            this.Hide();
        }

        private void btnInspection_Click(object sender, EventArgs e)
        {
            Inspection ins = new Inspection();
            ins.Show();
            this.Hide();
        }

        private void btnInspecDetail_Click(object sender, EventArgs e)
        {
            InspectionDetail insD = new InspectionDetail();
            insD.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.Show();
            this.Hide();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep.Show();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Request req = new Request();
            req.Show();
            this.Hide();
        }

        private void btnTaskType_Click(object sender, EventArgs e)
        {
            TaskType taskT = new TaskType();
            taskT.Show();
            this.Hide();
        }

        private void btnTutorReq_Click(object sender, EventArgs e)
        {
            TutorRequest tutR = new TutorRequest();
            tutR.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Show();
            this.Hide();
        }

		private void Label1_Click(object sender, EventArgs e)
		{

		}


		// On hover color change events
		private void BtnEquipment_MouseEnter(object sender, EventArgs e)
		{
			btnEquipment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(128, 200, 255);
			btnEquipment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(128, 200, 255);
		}

		private void BtnEquipment_MouseLeave(object sender, EventArgs e)
		{
			btnEquipment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 192, 0);
			btnEquipment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 192, 0);
		}

		private void BtnVenue_MouseEnter(object sender, EventArgs e)
		{
			btnVenue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(128, 200, 255);
			btnVenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(128, 200, 255);
		}

		private void BtnVenue_MouseLeave(object sender, EventArgs e)
		{
			btnVenue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 192, 0);
			btnVenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 192, 0);
		}
	}
}