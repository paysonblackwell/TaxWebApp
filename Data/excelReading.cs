using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace TaxWebApp.Data
{
    public class ExcelReading
    {

        //Taken from SampleWebApp.Core example: https://github.com/JanKallman/EPPlus

        private const string XlsxContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        public ExcelReading()
        {

            //replace Personals with Corporate for other data
            string fileStuff = ReadFile("Tax_List_Sample.xlsx", "Personals "); //there is an annoying space in the Excel sheet's name

            //Writing Everything That was in the File to Console
            Debug.WriteLine(fileStuff);

            //TODO: Parse Data and upload to DataBase

        }



        public string ReadFile(string fileName, string sheetName)
        {
            var fileDownloadName = fileName;
            var taxFolder = "ExcelSheets";
            var fileInfo = new FileInfo(Path.Combine(taxFolder, fileDownloadName));

            
            return ReadExcelPackage(fileInfo, worksheetName: sheetName); 
        }

        private string ReadExcelPackage(FileInfo fileInfo, string worksheetName)
        {
            using (var package = new ExcelPackage(fileInfo))
            {
                return ReadExcelPackageToString(package, package.Workbook.Worksheets[worksheetName]);
            }
        }

        private string ReadExcelPackageToString(ExcelPackage package, ExcelWorksheet worksheet)
        {
            var rowCount = worksheet.Dimension?.Rows;
            var colCount = worksheet.Dimension?.Columns;

            if (!rowCount.HasValue || !colCount.HasValue)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            for (int row = 1; row <= rowCount.Value; row++)
            {
                for (int col = 1; col <= colCount.Value; col++)
                {
                    sb.AppendFormat("{0}\t", worksheet.Cells[row, col].Value);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }


    }
}
