using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucVenue : UserControl
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		public ucVenue()
		{
			InitializeComponent();
		}

		private void UcVenue_Load(object sender, EventArgs e)
		{
			cmbBuilding.DataSource = bll.LoadCMBBuilding();

			cmbBuilding.DisplayMember = "BuildingName";
			cmbBuilding.ValueMember = "BuildingID";

			cmbBuildingBlock.DataSource = bll.LoadCMBBuildingBlock();

			cmbBuildingBlock.DisplayMember = "BuildingBlock";
			cmbBuildingBlock.ValueMember = "BuildingBlockID";

			dgvVenue.DataSource = bll.GetVenues();
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


				//Error for input string not found
				DAL.VenueClass venue = new DAL.VenueClass(txtDescription.Text, int.Parse(txtCapacity.Text), int.Parse(txtDoorNo.Text), int.Parse(cmbBuildingBlock.SelectedValue.ToString()), int.Parse(cmbBuilding.SelectedValue.ToString()));
				int x = bll.AddVenue(venue);

				if (x > 0)
				{
					txtDescription.Clear();
					txtCapacity.Clear();
					txtDoorNo.Clear();
					cmbBuildingBlock.Text = "";
					cmbBuilding.Text = "";
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

			dgvVenue.DataSource = bll.GetVenues();
		}

		private void BtnManageUpdate_Click(object sender, EventArgs e)
		{
			dgvVenue.DataSource = bll.GetVenues();
			dgvVenue.BackgroundColor = Color.White;

			try
			{

				//Error for input string not found
				DAL.VenueClass venue = new DAL.VenueClass(DAL.VenueClass.VenueCode, txtDescription.Text, int.Parse(txtCapacity.Text), int.Parse(txtDoorNo.Text), int.Parse(cmbBuildingBlock.SelectedValue.ToString()), int.Parse(cmbBuilding.SelectedValue.ToString()));
				int x = bll.UpdateVenue(venue);

				if (x > 0)
				{
					txtDescription.Clear();
					txtCapacity.Clear();
					txtDoorNo.Clear();
					cmbBuildingBlock.Text = "";
					cmbBuilding.Text = "";
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

			dgvVenue.DataSource = bll.GetVenues();

		}

		private void BtnManageDelete_Click(object sender, EventArgs e)
		{
            try
            {
                //Error for input string not found
                DAL.VenueClass venue = new DAL.VenueClass(DAL.VenueClass.VenueCode);
                int x = bll.DeleteVenue(venue);

                if (x > 0)
                {
                    txtDescription.Clear();
                    txtCapacity.Clear();
                    txtDoorNo.Clear();
                    cmbBuildingBlock.Text = "";
                    cmbBuilding.Text = "";
                }
                else
                {
                    MessageBox.Show("Please input valid data.");
                }

                dgvVenue.DataSource = bll.GetVenues();
            }
#pragma warning disable CS0168 // The variable 'b' is declared but never used
            catch (Exception b)
#pragma warning restore CS0168 // The variable 'b' is declared but never used
            {
                MessageBox.Show("Please input valid data.");
            }
        }

		private void dgvVenue_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DAL.VenueClass venueClass = new DAL.VenueClass(int.Parse(dgvVenue.SelectedRows[0].Cells[0].Value.ToString()));

				var values = bll.SelectedForUpdateVenue(venueClass);

				txtDescription.Text = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
				txtCapacity.Text = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
				txtDoorNo.Text = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();

				cmbBuildingBlock.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[4];
				cmbBuilding.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[5];
			}
			catch
			{ }

		}

		private void BtnExportToExcel_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "Venue_Export.xls";
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
				dgvVenue.ClearSelection();

				// Open the newly saved excel file
				if (System.IO.File.Exists(sfd.FileName))
					System.Diagnostics.Process.Start(sfd.FileName);
			}
		}

		private void copyAlltoClipboard()
		{
			dgvVenue.SelectAll();
			DataObject dataObj = dgvVenue.GetClipboardContent();
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
