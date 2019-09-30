using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucRequest : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucRequest()
		{
			InitializeComponent();
		}
		private void UcRequest_Load(object sender, EventArgs e)
		{
			dateRequest.Value = DateTime.Now;

			dgvRequest.DataSource = bll.GetRequests();

			cmbTaskTypeCode.DataSource = bll.GetTasktype();

			cmbTaskTypeCode.DisplayMember = "TaskName";
			cmbTaskTypeCode.ValueMember = "taskTypeCode";

			cmbAssignedStaffCode.DataSource = bll.GetStaff();

			cmbAssignedStaffCode.DisplayMember = "FirstName";
			cmbAssignedStaffCode.ValueMember = "StaffCode";

			cmbStaffCode.DataSource = bll.GetStaff();

			cmbStaffCode.DisplayMember = "FirstName";
			cmbStaffCode.ValueMember = "StaffCode";

			cmbStudentCode.DataSource = bll.GetStudent();

			cmbStudentCode.DisplayMember = "FirstName";
			cmbStudentCode.ValueMember = "StudentCode";


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
			DAL.RequestClass request = new DAL.RequestClass(txtDescription.Text, int.Parse(cmbStaffCode.SelectedValue.ToString()), int.Parse(cmbStudentCode.SelectedValue.ToString()), int.Parse(cmbTaskTypeCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), cmbTime.SelectedItem.ToString(), int.Parse(cmbAssignedStaffCode.SelectedValue.ToString()), "Pending");

			int x = bll.AddRequest(request);

			if (x > 0)
			{
				txtDescription.Clear();
				cmbTime.ResetText();
				cmbStaffCode.ResetText();
				cmbStudentCode.ResetText();
				cmbTaskTypeCode.ResetText();
				cmbAssignedStaffCode.ResetText();
				dateRequest.ResetText();
			}
			else
			{
				MessageBox.Show("Please input valid data.");
			}

			dgvRequest.DataSource = bll.GetRequests();
		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
			DAL.RequestClass request = new DAL.RequestClass(DAL.RequestClass.RequestCode, txtDescription.Text, int.Parse(cmbStaffCode.SelectedValue.ToString()), int.Parse(cmbStudentCode.SelectedValue.ToString()), int.Parse(cmbTaskTypeCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), cmbTime.SelectedText.ToString(), int.Parse(cmbAssignedStaffCode.SelectedValue.ToString()), "Pending");

			int x = bll.UpdateRequest(request);

			if (x > 0)
			{
				txtDescription.Clear();
				cmbTime.ResetText();
				cmbStaffCode.ResetText();
				cmbStudentCode.ResetText();
				cmbTaskTypeCode.ResetText();
				cmbAssignedStaffCode.ResetText();
				dateRequest.ResetText();
			}
			else
			{
				MessageBox.Show("Please input valid data.");
			}

			dgvRequest.DataSource = bll.GetRequests();
		}

		private void BtnManageDelete_Click(object sender, EventArgs e)
		{

		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvRequest.DataSource = bll.GetRequests();
			dgvRequest.BackgroundColor = Color.White;

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void dgvRequest_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DAL.RequestClass requestClass = new DAL.RequestClass(int.Parse(dgvRequest.SelectedRows[0].Cells[0].Value.ToString()));

			var values = bll.SelectedForUpdateRequest(requestClass);

			txtDescription.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
			dateRequest.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

			cmbStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2];
			cmbStudentCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[3];
			cmbTaskTypeCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[4];
			cmbTime.Text = values.Rows[0].Table.Rows[0].ItemArray[6].ToString();
			cmbAssignedStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[7];
		}

		private void BtnExportToExcel_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "Request_Export.xls";
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
				dgvRequest.ClearSelection();

				// Open the newly saved excel file
				if (System.IO.File.Exists(sfd.FileName))
					System.Diagnostics.Process.Start(sfd.FileName);
			}
		}

		private void copyAlltoClipboard()
		{
			dgvRequest.SelectAll();
			DataObject dataObj = dgvRequest.GetClipboardContent();
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
