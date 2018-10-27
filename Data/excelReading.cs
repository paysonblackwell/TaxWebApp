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

        //The Example is pretty cool, one of the buttons on the homepage allows you to pick an excel sheet from your computer to upload
         //Might make it a stretch goal to update current DB with a excel sheet given to us as long as it is in the right format



        private const string XlsxContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        public ExcelReading()
        {

            //replace Personals with Corporate for other data
            //Will probably change ReadFile() to UploadFile() once I have everything sorted out
            string fileStuff = ReadFile("Tax_List_Sample.xlsx", "Personals "); //there is an annoying space in the Excel sheet's name




            //Writing Everything That was in the File to Console for testing
            Debug.WriteLine(fileStuff);

            //TODO: Parse Data and upload to DataBase

        }


        //Getting everything ready to create an Excel Package to store data from file
        public string ReadFile(string fileName, string sheetName)
        {
            var fileDownloadName = fileName;
            var taxFolder = "ExcelSheets";
            var fileInfo = new FileInfo(Path.Combine(taxFolder, fileDownloadName));

            //Calling next function to fill in the Excel Package
            return ReadExcelPackage(fileInfo, worksheetName: sheetName); 
        }

        //Puts the Data from the Excel File into the object then calls function to turn it into a string
        private string ReadExcelPackage(FileInfo fileInfo, string worksheetName)
        {
            using (var package = new ExcelPackage(fileInfo))
            {

                //My method for uploading to Database
                ReadExcelPackageToDataBase(package, package.Workbook.Worksheets[worksheetName]);


                return ReadExcelPackageToString(package, package.Workbook.Worksheets[worksheetName]);
            }
        }

        //Takes the data and turns it into a readable string 
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



        //Work in Progress, Will Parse then upload Data to DB
        private void ReadExcelPackageToDataBase(ExcelPackage package, ExcelWorksheet worksheet)
        {
            var rowCount = worksheet.Dimension?.Rows;
            var colCount = worksheet.Dimension?.Columns;

            if (!rowCount.HasValue || !colCount.HasValue)
            {
                //return string.Empty;
            }



            //Will Disect this to upload Data to DB
            var sb = new StringBuilder();
            for (int row = 1; row <= rowCount.Value; row++)
            {
                for (int col = 1; col <= colCount.Value; col++)
                {
                    //This formats
                    sb.AppendFormat("{0}\t", worksheet.Cells[row, col].Value);


                    //What line by line output looks like
                    //Debug.WriteLine(worksheet.Cells[row, col].Value);

                    /*
                     * OUTPUT FOR LINE BY LINE:
                     * First Ten lines are column names
                     * Every Person starts with empty line for empty Column, also empty Column for every cell without data
                     * Any Data with Number and then no name should not be uploaded to DB
                     * 
                     * Example of every cell filled in for Person
                       EmptyLine:    
                       Number:       18004
                       Name:         Amara Burton
                       New:          X
                       ReferedBy:    Brooke Welch
                       In:           1/5/2018 12:00:00 AM
                       Scanned:      1/5/2018 12:00:00 AM
                       Notes:        2018
                       Preparer:     Alexandra 
                       Status:       Mailed 1/8/2018


                        
                     * Example of missing cells for Person
                       EmptyLine:    
                       Number:       18073
                       Name:         Londyn Gould
                       New:          
                       ReferedBy:    
                       In:           1/22/2018 12:00:00 AM
                       Scanned:      1/26/2018 12:00:00 AM
                       Notes:        2018
                       Preparer:     
                       Status:       
                     */


                }
                sb.Append(Environment.NewLine);
            }
            //return sb.ToString();
        }


    }
}
