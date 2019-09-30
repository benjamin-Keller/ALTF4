using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucTutorRequest : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();

		public ucTutorRequest()
		{
			InitializeComponent();
		}

		private void UcTutorRequest_Load(object sender, EventArgs e)
		{
			dgvTutorRequest.DataSource = bll.GetTutorRequest();

			cmbRequestCode.DataSource = bll.GetRequests();

			cmbRequestCode.ValueMember = "RequestCode";
			cmbRequestCode.DisplayMember = "RequestCode";

			cmbVenueCode.DataSource = bll.GetVenues();

			cmbVenueCode.DisplayMember = "VenueDescription";
			cmbVenueCode.ValueMember = "VenueCode";

			cmbModuleCode.DataSource = bll.LoadCMBModels();

			cmbModuleCode.DisplayMember = "ModuleDescription";
			cmbModuleCode.ValueMember = "ModuleCode";

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
				DAL.TutorRequestClass tutorRequest = new DAL.TutorRequestClass(int.Parse(cmbRequestCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), cmbStartTime.SelectedItem.ToString(), cmbEndTime.SelectedItem.ToString(), int.Parse(cmbModuleCode.SelectedValue.ToString()), int.Parse(cmbVenueCode.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());

				int x = bll.AddTutorRequest(tutorRequest);

				if (x > 0)
				{
					cmbRequestCode.Text = " ";
					dateRequest.ResetText();
					cmbStartTime.Text = " ";
					cmbEndTime.Text = " ";
					cmbRequestCode.Text = " ";
					cmbModuleCode.Text = " ";
					cmbVenueCode.Text = " ";
                    cmbStatus.Text = "";
				}
				else
				{
					MessageBox.Show("Please input valid data.");
				}
			}
#pragma warning disable CS0168 // The variable 'error' is declared but never used
			catch (Exception error)
#pragma warning restore CS0168 // The variable 'error' is declared but never used
			{
				MessageBox.Show("Please Enter a valid Time.");
			}



			dgvTutorRequest.DataSource = bll.GetTutorRequest();

		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
			dgvTutorRequest.DataSource = bll.GetTutorRequest();
			dgvTutorRequest.BackgroundColor = Color.White;

			try
			{
				DAL.TutorRequestClass tutorRequest = new DAL.TutorRequestClass(int.Parse(cmbRequestCode.SelectedValue.ToString()), Convert.ToDateTime(dateRequest.Text), cmbStartTime.SelectedItem.ToString(), cmbEndTime.SelectedItem.ToString(), int.Parse(cmbModuleCode.SelectedValue.ToString()), int.Parse(cmbVenueCode.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());

				int x = bll.UpdateTutorRequest(tutorRequest);

				if (x > 0)
				{
					cmbRequestCode.Text = "";
					dateRequest.ResetText();
					cmbStartTime.Text = "";
					cmbEndTime.Text = "";
					cmbRequestCode.Text = "";
					cmbModuleCode.Text = "";
					cmbVenueCode.Text = "";
                    cmbStatus.Text = "";
                }
				else
				{
					MessageBox.Show("Please input valid data.");
				}
			}
#pragma warning disable CS0168 // The variable 'error' is declared but never used
			catch (Exception error)
#pragma warning restore CS0168 // The variable 'error' is declared but never used
			{
				MessageBox.Show("Please Enter a valid Time.");
			}
			dgvTutorRequest.DataSource = bll.GetTutorRequest();
		}

		private void BtnViewList_Click(object sender, EventArgs e)
		{
			dgvTutorRequest.DataSource = bll.GetTutorRequest();
			dgvTutorRequest.BackgroundColor = Color.White;

		}

		private void dgvTutorRequest_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DAL.TutorRequestClass request = new DAL.TutorRequestClass(int.Parse(dgvTutorRequest.SelectedRows[0].Cells[0].Value.ToString()));

				var values = bll.SelectedForUpdateTutorRequest(request);

                cmbRequestCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[1];
                dateRequest.Value = Convert.ToDateTime(values.Rows[0].Table.Rows[0].ItemArray[2].ToString());
				cmbModuleCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[5];
				cmbVenueCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[6];
				cmbStartTime.SelectedItem = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
				cmbEndTime.SelectedItem = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();
                cmbStatus.SelectedItem = values.Rows[0].Table.Rows[0].ItemArray[7].ToString();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
			catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
			{

			}


		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void BtnExportToExcel_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "TutorRequest_Export.xls";
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
				dgvTutorRequest.ClearSelection();

				// Open the newly saved excel file
				if (System.IO.File.Exists(sfd.FileName))
					System.Diagnostics.Process.Start(sfd.FileName);
			}
		}

		private void copyAlltoClipboard()
		{
			dgvTutorRequest.SelectAll();
			DataObject dataObj = dgvTutorRequest.GetClipboardContent();
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
