using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using BLL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucStaff : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucStaff()
		{
			InitializeComponent();
		}

		private void UcStaff_Load(object sender, EventArgs e)
		{
            dgvStaff.DataSource = bll.GetStaff();

            cmbDepartmentCode.DataSource = bll.GetDepartment();

            cmbDepartmentCode.DisplayMember = "DepartmentName";
            cmbDepartmentCode.ValueMember = "DepartmentCode";

            //cmbStaffType.DataSource = bll.GetStaff();
            //cmbStaffType.DisplayMember = "StaffType";
            //cmbStaffType.ValueMember = "StaffCode";
                 
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

			tmrManage.Stop();
		}


		private void TmrView_Tick(object sender, EventArgs e)
		{
			pnlManage.Height = pnlManage.MinimumSize.Height;
			tmrView.Stop();
		}

		private void BtnManageAdd_Click(object sender, EventArgs e)
		{
            try
            {
                string activeStatus = "";
                if(cmbStatus.SelectedItem.ToString() == "Active")
                {
                    activeStatus = "True";
                }
                else
                {
                    activeStatus = "False";
                }
                DAL.StaffClass staff = new DAL.StaffClass(txtStaffNumber.Text, txtName.Text, txtSurname.Text, txtEmailAddress.Text, int.Parse(txtContactNo.Text), cmbStaffType.SelectedItem.ToString(), int.Parse(cmbDepartmentCode.SelectedValue.ToString()),txtUsername.Text,txtPassword.Text, activeStatus);
                int x = bll.AddStaff(staff);


                if (x > 0)
                {
                    txtStaffNumber.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmailAddress.Clear();
                    txtContactNo.Clear();
                    cmbStaffType.Text = " ";
                    cmbDepartmentCode.Text = " ";
                    cmbStatus.Text = " ";
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {
                MessageBox.Show("Please input valid data.");
            }
            dgvStaff.DataSource = bll.GetStaff();
        }

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
            dgvStaff.DataSource = bll.GetStaff();
            dgvStaff.BackgroundColor = Color.White;

            try
            {
                string activeStatus = "";
                if (cmbStatus.SelectedItem.ToString() == "Active")
                {
                    activeStatus = "True";
                }
                else
                {
                    activeStatus = "False";
                }
                DAL.StaffClass staff = new DAL.StaffClass(txtStaffNumber.Text, txtName.Text, txtSurname.Text, txtEmailAddress.Text, int.Parse(txtContactNo.Text), cmbStaffType.SelectedItem.ToString(), int.Parse(cmbDepartmentCode.SelectedValue.ToString()), txtUsername.Text, txtPassword.Text, activeStatus);
                int x = bll.UpdateStaff(staff);


                if (x > 0)
                {
                    txtStaffNumber.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmailAddress.Clear();
                    txtContactNo.Clear();
                    cmbStaffType.Text = " ";
                    cmbDepartmentCode.Text = " ";


                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {
                MessageBox.Show("Please input valid data.");
            }
            dgvStaff.DataSource = bll.GetStaff();

            
        }

		private void BtnViewList_Click(object sender, EventArgs e)
		{
            dgvStaff.DataSource = bll.GetStaff();
            dgvStaff.BackgroundColor = Color.White;

		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvStaffExUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DAL.StaffClass staffClass = new DAL.StaffClass(int.Parse(dgvStaff.SelectedRows[0].Cells[0].Value.ToString()));

                var values = bll.SelectForUpdateStaffExUser(staffClass);

                txtStaffNumber.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                txtName.Text = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
                txtSurname.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
                txtEmailAddress.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                txtContactNo.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

                cmbStaffType.SelectedItem = values.Rows[0].Table.Rows[0].ItemArray[6].ToString();
                cmbDepartmentCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[7];
                if (values.Rows[0].Table.Rows[0].ItemArray[10].ToString() == "True")
                {
                    cmbStatus.SelectedItem = "Active";
                }
                else
                {
                    cmbStatus.SelectedItem = "Inactive";
                }
                txtUsername.Text = values.Rows[0].Table.Rows[0].ItemArray[8].ToString();
                txtPassword.Text = values.Rows[0].Table.Rows[0].ItemArray[9].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {
                MessageBox.Show(b.Message);
            }
           

        }

		private void BtnExportToExcel_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "Staff_Export.xls";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				// Copy DataGridView results to clipboard
				copyAlltoClipboard();

				object misValue = System.Reflection.Missing.Value;
				Microsoft.Office.Interop.Excel.Application xlexcel = new Microsoft.Office.Interop.Excel.Application();

				xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
				Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
				Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

				// Format column D as text before pasting results, this was required for my data
				Microsoft.Office.Interop.Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
				rng.NumberFormat = "@";

				// Paste clipboard results to worksheet range
				Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
				CR.Select();
				xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

				// For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
				// Delete blank column A and select cell A1
				Microsoft.Office.Interop.Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
				delRng.Delete(Type.Missing);
				xlWorkSheet.get_Range("A1").Select();

				// Save the excel file under the captured location from the SaveFileDialog
				xlWorkBook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
				xlexcel.DisplayAlerts = true;
				xlWorkBook.Close(true, misValue, misValue);
				xlexcel.Quit();

				releaseObject(xlWorkSheet);
				releaseObject(xlWorkBook);
				releaseObject(xlexcel);

				// Clear Clipboard and DataGridView selection
				Clipboard.Clear();
				dgvStaff.ClearSelection();

				// Open the newly saved excel file
				if (System.IO.File.Exists(sfd.FileName))
					System.Diagnostics.Process.Start(sfd.FileName);
			}
		}

		private void copyAlltoClipboard()
		{
			dgvStaff.SelectAll();
			DataObject dataObj = dgvStaff.GetClipboardContent();
			if (dataObj != null)
				Clipboard.SetDataObject(dataObj);
		}

		private void releaseObject(object obj)
		{
			try
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
				obj = null;
			}
			catch (Exception ex)
			{
				obj = null;
				MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
			}
			finally
			{
				GC.Collect();
			}
		}
	}


}
