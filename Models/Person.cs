using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaxWebApp.Data;

namespace TaxWebApp.Models
{
    public class Person
    {
        //ID for database
        public long Id { get; set; }


        //All Columns from Personals  excel sheet
        //All are type string for right now

        //only used for excel sheet
        public static string LastNumber { get; set; }

        public string Number { get; set;}

        public string Name { get; set; }

        public string New { get; set; }

        public string ReferedBy { get; set; }

        public string In { get; set; }

        public string Scanned { get; set; }

        public string Notes { get; set; }

        public string Preparer { get; set; }

        public string Status { get; set; }

        public static Stack<string> AvailableNumbers = new Stack<string>();

        public static string getNextNumber(TaxDataContext contextDB)
        {

            if (AvailableNumbers.Count()>0)
            {
                return AvailableNumbers.Pop();
            }
            //Get current People in DB, sorted by Number, pads the Number with 0's to make sure they are the same length when sorted
            Person[] peopleList = contextDB.Person.OrderBy(m => m.Number.PadLeft(contextDB.Person.Count(), '0')).ToArray();

            //Gets the last number that was used, doesn't check for missing numbers that were deleted by user
            string currentNumber = peopleList[(peopleList.Length-1)].Number;


            //Increment the last Number entered by 1
            int lastNumber;
            Int32.TryParse(currentNumber, out lastNumber);
            lastNumber++;

            Person.LastNumber = lastNumber.ToString();
            //return next number
            return lastNumber.ToString();        
        }

        /* OLD WAY
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        */
    }
}
