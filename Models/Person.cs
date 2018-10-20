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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
