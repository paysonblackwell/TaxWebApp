﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using TaxWebApp.Models;

namespace TaxWebApp.Data
{
    public class ExcelReading
    {

        //DB STUFF
        private readonly TaxDataContext _contextDB;
        public ExcelReading(TaxDataContext context)
        {
            _contextDB = context;
        }




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
                    //formats by adding tabs
                    sb.AppendFormat("{0}\t", worksheet.Cells[row, col].Value);
                }
                //creates the newline space
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
                //exit if there is no data
                return;
            }

            //Check if uploading to Personals 
            if (worksheet.Name == "Personals ")
            {
                bool outOfValidPeople = false;
                //skip the first row which are colomn names
                for (int row = 2; row <= rowCount.Value; row++)
                {
                    Person currentPerson = new Person();

                    if (!outOfValidPeople)
                    {

                        for (int col = 1; col <= colCount.Value; col++)
                        {
                            if (!outOfValidPeople)
                            {

                                //Either you can build an SQL statement to add all the values at once, or you can be lazy and use a switch statement
                                //https://www.thaicreate.com/asp.net/c-sharp-asp.net-excel-import-database.html

                                //upload data depending which column
                                switch (col)
                                {
                                    case 1:
                                        //empty column, ignore
                                        break;
                                    case 2:
                                        currentPerson.Number = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 3:
                                        currentPerson.Name = (worksheet.Cells[row, col].Value).ToString();
                                        if (currentPerson.Name == "")
                                        {
                                            outOfValidPeople = true;
                                        }
                                        break;
                                    case 4:
                                        currentPerson.New = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 5:
                                        currentPerson.ReferedBy = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 6:
                                        currentPerson.In = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 7:
                                        currentPerson.Scanned = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 8:
                                        currentPerson.Notes = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 9:
                                        currentPerson.Preparer = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 10:
                                        currentPerson.Status = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    default:
                                        //I don't think it can get here
                                        Debug.WriteLine("*********************************************************");
                                        Debug.WriteLine("*********************************************************");
                                        Debug.WriteLine("*********************************************************");
                                        Debug.WriteLine("*********************************************************");
                                        break;
                                }

                                //currentPerson should be fully made now

                                //Checking to see if the person is already a part of it
                                //It will throw exception if it is already in the DB, in that case update the person instead
                                try
                                {
                                    _contextDB.Person.Add(currentPerson);
                                }
                                catch
                                {
                                    _contextDB.Person.Update(currentPerson);
                                    throw new Exception("didn't save");
                                }
                            }
                            else
                            {
                                //break out of loop if out of valid people (People with at least a name)

                                //unlike java, there is no way to break out of two loops at once
                                break;
                            }
                        }
                    }
                    else
                    {
                        //again there is no way two break out of two loops at once, thus the bool check to see if we need to break out of it
                        break;
                    }
                }

                //Save Changes
                _contextDB.SaveChanges();

            }
            else if (worksheet.Name == "Corporate")//Check if uploading to Corporate 
            {

                bool outOfValidCorporate = false;
                for (int row = 2; row <= rowCount.Value; row++)
                {
                    Corporate currentCorporate = new Corporate();

                    if (!outOfValidCorporate)
                    {

                        for (int col = 1; col <= colCount.Value; col++)
                        {
                            if (!outOfValidCorporate)
                            {
                                switch (col)
                                {
                                    case 1:
                                        currentCorporate.Type = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 2:
                                        currentCorporate.Number = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 3:
                                        currentCorporate.Name = (worksheet.Cells[row, col].Value).ToString();
                                        if (currentCorporate.Name == "")
                                        {
                                            outOfValidCorporate = true;
                                        }
                                        break;
                                    case 4:
                                        currentCorporate.New = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 5:
                                        currentCorporate.In = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 6:
                                        currentCorporate.Notes = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 7:
                                        currentCorporate.Status = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 8:
                                        currentCorporate.Preparer = (worksheet.Cells[row, col].Value).ToString();
                                        break;
                                    case 9:
                                        //empty column
                                        break;
                                    case 10:
                                        //empty column
                                        break;
                                    case 11:
                                        //empty column
                                        break;
                                    default:
                                        //I don't think it can get here
                                        Debug.WriteLine("*********************************************************");
                                        Debug.WriteLine("*********************************************************");
                                        Debug.WriteLine("*********************************************************");
                                        Debug.WriteLine("*********************************************************");
                                        break;
                                }

                                //currentPerson should be fully made now

                                //Checking to see if the person is already a part of it
                                //It will throw exception if it is already in the DB, in that case update the person instead
                                try
                                {
                                    _contextDB.Corporate.Add(currentCorporate);
                                }
                                catch
                                {
                                    _contextDB.Corporate.Update(currentCorporate);
                                }
                            }
                            else
                            {
                                //break out of loop if out of valid people (People with at least a name)

                                //unlike java, there is no way to break out of two loops at once
                                break;
                            }
                        }
                    }
                    else
                    {
                        //again there is no way two break out of two loops at once, thus the bool check to see if we need to break out of it
                        break;
                    }
                }

                //Save Changes
                _contextDB.SaveChanges();
            }
                
                //What line by line output looks like
                //Debug.WriteLine(worksheet.Cells[row, col].Value);

                /*
                 * OUTPUT FOR LINE BY LINE for Personals  Excel Sheet:
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


    }
}
