﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace HateksPasswordGenerator
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {

            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];

        }

        public string ReadCell(int row, int column)
        {

            row++;
            column++;

            if (ws.Cells[row, column].Value2 != null)
            {
                return ws.Cells[row, column].Value2;
            }
            else return "HATA";


        }

        public void WriteToCell(int row, int column, string data)
        {

            row++;
            column++;
            ws.Cells[row, column].Value2 = data;

        }
        public void Save()
        {

            wb.Save();
        }
        public void SaveAs(string path)
        {

            wb.SaveAs(path);
        }
        public void Close()
        {
            wb.Close();
        }

        public int GetColumsNumber()
        {
            return ws.UsedRange.Rows.Count;

        }
    }
}
