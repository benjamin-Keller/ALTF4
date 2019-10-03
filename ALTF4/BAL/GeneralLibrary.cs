using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace DAL
{
	class GeneralLibrary
	{
		
		//This is where we add any Methods that we need
		/**Export to Excel**/
		private void ExportToExcel_Click(string defaultSaveName, DataGridView dgvName)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = defaultSaveName;
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				// Copy DataGridView results to clipboard
				copyAlltoClipboard(dgvName);

				object misValue = System.Reflection.Missing.Value;
				Excel.Application xlexcel = new Excel.Application();

				xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
				Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
				Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

				// Format column D as text before pasting results, this was required for my data
				Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
				rng.NumberFormat = "@";

				// Paste clipboard results to worksheet range
				Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
				CR.Select();
				xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

				// For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
				// Delete blank column A and select cell A1
				Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
				delRng.Delete(Type.Missing);
				xlWorkSheet.get_Range("A1").Select();

				// Save the excel file under the captured location from the SaveFileDialog
				xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
				xlexcel.DisplayAlerts = true;
				xlWorkBook.Close(true, misValue, misValue);
				xlexcel.Quit();

				releaseObject(xlWorkSheet);
				releaseObject(xlWorkBook);
				releaseObject(xlexcel);

				// Clear Clipboard and DataGridView selection
				Clipboard.Clear();
				dgvName.ClearSelection();

				// Open the newly saved excel file
				if (System.IO.File.Exists(sfd.FileName))
					System.Diagnostics.Process.Start(sfd.FileName);
			}
		}

		private void copyAlltoClipboard(DataGridView dgvName)
		{
			dgvName.SelectAll();
			DataObject dataObj = dgvName.GetClipboardContent();
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


		/**Export to Word**/
		private void ExportToWord_Click(string defaultSaveName, DataGridView dgvName)
		{
			SaveFileDialog sfd = new SaveFileDialog();

			sfd.Filter = "Word Documents (*.docx)|*.docx";
			sfd.FileName = defaultSaveName;

			if (sfd.ShowDialog() == DialogResult.OK)
			{

				if (dgvName.Rows.Count != 0)
				{
					int RowCount = dgvName.Rows.Count;
					int ColumnCount = dgvName.Columns.Count;
					Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

					//add rows
					int r = 0;
					for (int c = 0; c <= ColumnCount - 1; c++)
					{
						for (r = 0; r <= RowCount - 1; r++)
						{
							DataArray[r, c] = dgvName.Rows[r].Cells[c].Value;
						} //end row loop
					} //end column loop

					Word.Document oDoc = new Word.Document();
					oDoc.Application.Visible = true;

					//page orintation
					oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


					dynamic oRange = oDoc.Content.Application.Selection.Range;
					string oTemp = "";
					for (r = 0; r <= RowCount - 1; r++)
					{
						for (int c = 0; c <= ColumnCount - 1; c++)
						{
							oTemp = oTemp + DataArray[r, c] + "\t";

						}
					}

					//table format
					oRange.Text = oTemp;

					object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
					object ApplyBorders = true;
					object AutoFit = true;
					object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

					oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
										  Type.Missing, Type.Missing, ref ApplyBorders,
										  Type.Missing, Type.Missing, Type.Missing,
										  Type.Missing, Type.Missing, Type.Missing,
										  Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

					oRange.Select();

					oDoc.Application.Selection.Tables[1].Select();
					oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
					oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
					oDoc.Application.Selection.Tables[1].Rows[1].Select();
					oDoc.Application.Selection.InsertRowsAbove(1);
					oDoc.Application.Selection.Tables[1].Rows[1].Select();

					//header row style
					oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
					oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
					oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

					//add header row manually
					for (int c = 0; c <= ColumnCount - 1; c++)
					{
						oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dgvName.Columns[c].HeaderText;
					}

					//table style 
					oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
					oDoc.Application.Selection.Tables[1].Rows[1].Select();
					oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

					//header text
					foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
					{
						Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
						headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
						headerRange.Text = "your header text";
						headerRange.Font.Size = 16;
						headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
					}

					//save the file
					oDoc.SaveAs2(defaultSaveName);

					//NASSIM LOUCHANI
				}
			}
		}
	}
}
