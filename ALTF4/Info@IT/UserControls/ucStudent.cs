using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucStudent : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucStudent()
		{
			InitializeComponent();
		}
		private void UcStudent_Load(object sender, EventArgs e)
		{
            dgvStudent.DataSource = bll.GetStudent();
        }

		//Menu button (Manage)
		private void BtnManage_Click(object sender, EventArgs e)
		{
			tmrManage.Start();
			if (!(pnlManage.Height == pnlManage.MinimumSize.Height))
			{
				pnlManage.Height = pnlManage.MinimumSize.Height;
				tmrManage.Enabled = false;
			}
		}
		private void TmrManage_Tick(object sender, EventArgs e)
		{
			pnlManage.Height = pnlManage.MaximumSize.Height;
			pnlView.Height = pnlView.MinimumSize.Height;

			tmrManage.Stop();
		}

		//Menu button (View)
		private void BtnView_Click(object sender, EventArgs e)
		{
			tmrView.Start();
			if (!(pnlView.Height == pnlView.MinimumSize.Height))
			{
				pnlView.Height = pnlView.MinimumSize.Height;
				tmrView.Enabled = false;
			}
		}
		private void TmrView_Tick(object sender, EventArgs e)
		{
			pnlView.Height = pnlView.MaximumSize.Height;
			pnlManage.Height = pnlManage.MinimumSize.Height;
			tmrView.Stop();
		}

		private void BtnManageAdd_Click(object sender, EventArgs e)
		{
            try
            {
                DAL.StudentClass studentClass = new DAL.StudentClass(txtStudentNumber.Text, txtName.Text, txtSurname.Text, txtEmailAddress.Text);
                int x = bll.AddStudent(studentClass);

                if (x > 0)
                {
                    txtStudentNumber.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmailAddress.Clear();
                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }
            }
            catch (Exception b)
            {
                MessageBox.Show("Please input valid data.");
            }
            dgvStudent.DataSource = bll.GetStudent();

        }

        private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
            dgvStudent.DataSource = bll.GetStudent();
            dgvStudent.BackgroundColor = Color.White;

            try
            {
                DAL.StudentClass studentClass = new DAL.StudentClass(DAL.StudentClass.StudentCode, txtStudentNumber.Text, txtName.Text, txtSurname.Text, txtEmailAddress.Text);
                int x = bll.UpdateStudent(studentClass);

                if(x > 0)
                {
                    txtStudentNumber.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmailAddress.Clear();
                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }
            }
            catch (Exception b)
            {
                MessageBox.Show("Please input valid data.");
            }
            dgvStudent.DataSource = bll.GetStudent();

        }

        private void BtnViewList_Click(object sender, EventArgs e)
		{
            dgvStudent.DataSource = bll.GetStudent();
            dgvStudent.BackgroundColor = Color.White;

        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DAL.StudentClass studclass = new DAL.StudentClass(int.Parse(dgvStudent.SelectedRows[0].Cells[0].Value.ToString()));

            var values = bll.SelectedForUpdateStudent(studclass);

            txtStudentNumber.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
            txtName.Text = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
            txtSurname.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
            txtEmailAddress.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();

        }
    }
}
