using System;
using System.Collections.Generic;
using TeachingLoadCore;
using Excel = Microsoft.Office.Interop.Excel;


namespace TeachingLoadCore.ExcelIntegration
{
    public class ExcelReader
    {
        private int sheet = 1;
        Excel.Application excelApp = new Excel.Application();
        Excel.Workbook excelWorkBook;
        Excel._Worksheet excelWorkSheet;

        public ExcelReader()
        {
            
        }

        public List<Disciplines> ReadDisciplinesSheet()
        {
            excelWorkBook = excelApp.Workbooks.Open(ExcelPaths.DisciplinesPath);
            excelWorkSheet = (Excel.Worksheet)excelWorkBook.Sheets[sheet];
            Excel.Range excelRange = excelWorkSheet.UsedRange;

            excelRange = (Excel.Range)excelWorkSheet.Cells[61, 2];

            excelRange = excelWorkSheet.UsedRange;
            int rows = excelRange.Rows.Count;
            int columns = excelRange.Columns.Count;

            List<Disciplines> disciplines = new List<Disciplines>();

            for (int i = 1; i < rows + 1; i++)
            {
                if (excelRange.Cells[i, 1] != null && (excelRange.Cells[i, 1] as Excel.Range).Value2 != null)
                {
                    disciplines.Add(new Disciplines((string)(excelRange.Cells[i, 1] as Excel.Range).Value2,
                     (string)(excelRange.Cells[i, 2] as Excel.Range).Value2));
                }
            }
            excelWorkBook.Close(true, null, null);
            excelApp.Quit();
            return disciplines;
        }

        public List<Teachers> ReadTeachersSheet()
        {
            excelWorkBook = excelApp.Workbooks.Open(ExcelPaths.TeachersPath);
            excelWorkSheet = (Excel.Worksheet)excelWorkBook.Sheets[sheet];
            Excel.Range excelRange = excelWorkSheet.UsedRange;

            excelRange = (Excel.Range)excelWorkSheet.Cells[25, 6];

            excelRange = excelWorkSheet.UsedRange;
            int rows = excelRange.Rows.Count;
            int columns = excelRange.Columns.Count;

            List<Teachers> teachers = new List<Teachers>();

            for (int i = 1; i < rows + 1; i++)
            {
                if (excelRange.Cells[i, 1] != null && (excelRange.Cells[i, 1] as Excel.Range).Value2 != null)
                {
                    //teachers.Add(new Teacher((string)(excelRange.Cells[i, 1] as Excel.Range).Value2,
                    // (string)(excelRange.Cells[i, 3] as Excel.Range).Value2,
                    //(string)(excelRange.Cells[i, 4] as Excel.Range).Value2,
                    //(string)(excelRange.Cells[i, 5] as Excel.Range).Value2,
                    //(string)(excelRange.Cells[i, 6] as Excel.Range).Value2));
                }
        }
        excelWorkBook.Close(true, null, null);
            excelApp.Quit();
            return teachers;
        }


        //        public List<Groups> ReadGroupsSheet()
        //        {
        //            excelWorkBook = excelApp.Workbooks.Open(path);
        //            excelWorkSheet = (Excel.Worksheet)excelWorkBook.Sheets[sheet];
        //            Excel.Range excelRange = excelWorkSheet.UsedRange;

        //            excelRange = (Excel.Range)excelWorkSheet.Cells[28, 7];

        //            excelRange = excelWorkSheet.UsedRange;
        //            int rows = excelRange.Rows.Count;
        //            int columns = excelRange.Columns.Count;

        //            List<Groups> teachers = new List<Groups>();

        //            for (int i = 1; i < rows + 1; i++)
        //            {
        //                if (excelRange.Cells[i, 1] != null && (excelRange.Cells[i, 1] as Excel.Range).Value2 != null)
        //                {
        //                    teachers.Add(new Groups((string)(excelRange.Cells[i, 1] as Excel.Range).Value2,
        //                     (string)(excelRange.Cells[i, 2] as Excel.Range).Value2,
        //                    (string)(excelRange.Cells[i, 3] as Excel.Range).Value2,
        //                    (string)(excelRange.Cells[i, 4] as Excel.Range).Value2,
        //                    (string)(excelRange.Cells[i, 5] as Excel.Range).Value2));
        //                }
        //            }
        //            excelWorkBook.Close(true, null, null);
        //            excelApp.Quit();
        //            return groups;
        //        }

    }
}
