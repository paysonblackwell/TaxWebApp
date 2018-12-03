using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxWebApp.Data;

namespace TaxWebApp.Models
{
    public class ExcelHolder
    {
        /*
         * This is a complex Data model that holds lists of people waiting to be uploaded to the DB from the Excel file
         * 
         * This model only runs if the DB is not made yet and the excelReading.cs file is called
         * 
         * 
         * Can test if excel uploading works by changing connection string to local DB verison and your TaxDB is empty
         */ 


        private List<Person> pList = new List<Person>();
        private List<Corporate> cList = new List<Corporate>();

        private TaxDataContext _contextDB;

        public ExcelHolder(TaxDataContext c)
        {
            _contextDB = c;
        }

        //adds to the list of People to add to the DB
        public void addPerson(Person p)
        {
            pList.Add(p);
        }

        //adds to the list of Corporates to add to the DB
        public void addCorporate(Corporate c)
        {
            cList.Add(c);
        }

        //returns true if they already exist in DB
        public  bool personInDB(string currentNumber)
        {
            return _contextDB.Person.Where(m => m.Number == currentNumber).FirstOrDefault() != null ? true : false;
        }
        public bool corporateInDB(string currentNumber)
        {
            return _contextDB.Corporate.Where(m => m.Number == currentNumber).FirstOrDefault() != null ? true : false;
        }

        //batch upload
        public void uploadLists()
        {
            foreach(Person p in pList)
            {
                _contextDB.Person.Add(p);
            }

            foreach (Corporate c in cList)
            {
                _contextDB.Corporate.Add(c);
            }
        }

    }
}
