/// <summary>
/// Siemens Dresser-Rand Inventory Audit assistance program.
/// </summary>
/// <remarks>
/// Audit program created for Siemens Dresser-Rand to assist with inventory auditing. Data 1 is the physical data.
/// Data 2 is from a list to compare with Data 1.  Output will show if Data 1 is on Data 2 list and has the links to the
/// Asset webpage for its summary and details.
/// </remarks>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Office.Interop;

namespace projectAudit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun3_Click(object sender, EventArgs e)
        {
            btnExportExcel.Enabled = true;
            dgResults.Rows.Clear();
            CompareData();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void CompareData()
        {
            string txt = txtData1.Text;
            string[] arrData1 = txt.Split('\n');

            string txt2 = txtData2.Text;
            string[] arrData2 = txt2.Split('\n');
            string[] arrFound = new string[arrData1.Count()];

            for (int i = 0; i < arrData1.Count(); i++)
            {
                for (int c = 0; c < arrData2.Count(); c++)
                {
                    if (arrData1[i] == arrData2[c])
                    {
                        arrFound[i] = "x";
                    }
                }
            }

            for (int i = 0; i < arrData1.Count(); i++)
            {
                this.dgResults.Rows.Add(arrData1[i], arrFound[i], "http://amp.d-rco.com/portal/searchResults.aspx?type=serial&query=" + arrData1[i] +
                    "&available=false", "http://amp.d-rco.com/portal/assetSummary.aspx?type=hw&id=" + arrData1[i]);
            }
        }
        private void dgResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Click event for Links in DataGrid.
            if (this.dgResults.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                Process.Start(this.dgResults[e.ColumnIndex, e.RowIndex].Value.ToString());
            }
        }
    
        private void ExportToExcel()
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedFromAIS";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < dgResults.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgResults.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgResults.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgResults.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel 97-2003 (*.xls)|*.xls|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
