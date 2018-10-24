using System;
using System.Collections.Generic;
using TeachingLoadCore.Entities;
using Excel = Microsoft.Office.Interop.Excel;


namespace TeachingLoadCore.ExcelIntegration
{
    public class ExcelReader
    {
        String path;

        private int sheet = 1;

        public ExcelReader(String path)
        {
            this.path = path;
        }

        public List<Discipline> ReadSheet()
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(path);
            Excel._Worksheet excelWorkSheet = (Excel.Worksheet)excelWorkBook.Sheets[sheet];
            Excel.Range excelRange = excelWorkSheet.UsedRange;

            //excelWorkSheet = (Excel.Worksheet)excelWorkBook.Worksheets[Sheet];

            //Worksheet excelSheet = workbook.ActiveSheet;
            excelRange = (Excel.Range)excelWorkSheet.Cells[61, 2];

            excelRange = excelWorkSheet.UsedRange;
            int rows = excelRange.Rows.Count;
            int columns = excelRange.Columns.Count;

            List<Discipline> disciplines = new List<Discipline>();

            for (int i = 1; i < rows + 1; i++)
            {
                if (excelRange.Cells[i, 1] != null && (excelRange.Cells[i, 1] as Excel.Range).Value2 != null)
                {
                    disciplines.Add(new Discipline((string)(excelRange.Cells[i, 1] as Excel.Range).Value2,
                     (string)(excelRange.Cells[i, 2] as Excel.Range).Value2));
                }

              
               
            }

            excelWorkBook.Close(true, null, null);
            excelApp.Quit();

            return disciplines;

            //i++;
            //j++;
            ////if (excelWorksheet.Cells[i][j] != null)
        }
    }
}
