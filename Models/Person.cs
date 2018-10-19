using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxWebApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
