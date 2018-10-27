using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaxWebApp.Models
{
    public class Person
    {
        //ID for database
        public long Id { get; set; }


        //All Columns from Personals  excel sheet
        //All are type string for right now

        public string Number { get; set;}

        public string Name { get; set; }

        public string New { get; set; }

        public string ReferedBy { get; set; }

        public string In { get; set; }

        public string Scanned { get; set; }

        public string Notes { get; set; }

        public string Preparer { get; set; }

        public string Status { get; set; }


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
