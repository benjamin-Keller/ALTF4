using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucInspection : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucInspection()
		{
			InitializeComponent();
		}

		private void UcNavInspection_Load(object sender, EventArgs e)
		{
			ucInspectionDetails1.Hide();

			cmbVenueCode.DataSource = bll.GetVenues();

			cmbVenueCode.DisplayMember = "VenueDescription";
			cmbVenueCode.ValueMember = "VenueCode";

			cmbStaffCode.DataSource = bll.GetStaff();

			cmbStaffCode.DisplayMember = "FirstName";
			cmbStaffCode.ValueMember = "StaffCode";

			dgvInspection.DataSource = bll.GetInspection();
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


				//Error for input string not found
				DAL.InspectionClass inspection = new DAL.InspectionClass(Convert.ToDateTime(dateInspection.Text), txtTime.Text, txtComment.Text, int.Parse(cmbVenueCode.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()));
				int x = bll.AddInspection(inspection);

				if (x > 0)
				{
					dateInspection.ResetText();
					txtTime.Clear();
					txtComment.Clear();
					cmbVenueCode.ValueMember = "";
					cmbStaffCode.ValueMember = "";
				}
				else
				{
					MessageBox.Show("Please input valid data.");
				}
			}
			catch
			{
				MessageBox.Show("Please input valid data.");
			}

			dgvInspection.DataSource = bll.GetInspection();
		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
			try
			{

				//Error for input string not found
				DAL.InspectionClass inspection = new DAL.InspectionClass(DAL.InspectionClass.InspectionCode, Convert.ToDateTime(dateInspection.Text), txtTime.Text, txtComment.Text, int.Parse(cmbVenueCode.SelectedValue.ToString()), int.Parse(cmbStaffCode.SelectedValue.ToString()));
				int x = bll.UpdateInspection(inspection);

				if (x > 0)
				{
					dateInspection.ResetText();
					txtTime.Clear();
					txtComment.Clear();
					cmbVenueCode.ValueMember = "";
					cmbStaffCode.ValueMember = "";
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

			dgvInspection.DataSource = bll.GetInspection();
		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvInspection.DataSource = bll.GetInspection();
			dgvInspection.BackgroundColor = Color.White;
		}

		private void BtnViewInspectiondetails_Click(object sender, EventArgs e)
		{
			ucInspectionDetails1.Show();
		}

		private void dgvInspection_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DAL.InspectionClass inspectClass = new DAL.InspectionClass(int.Parse(dgvInspection.SelectedRows[0].Cells[0].Value.ToString()));

				var values = bll.SelectedForUpdateInspection(inspectClass);

				dateInspection.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
				txtTime.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
				txtComment.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();

				cmbVenueCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[1];
				cmbStaffCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2];
			}
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}
		}

		private void ucInspectionDetails1_Load(object sender, EventArgs e)
		{

		}

		private void BtnExportToExcel_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "Inspection_Export.xls";
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
				dgvInspection.ClearSelection();

				// Open the newly saved excel file
				if (System.IO.File.Exists(sfd.FileName))
					System.Diagnostics.Process.Start(sfd.FileName);
			}
		}

		private void copyAlltoClipboard()
		{
			dgvInspection.SelectAll();
			DataObject dataObj = dgvInspection.GetClipboardContent();
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
