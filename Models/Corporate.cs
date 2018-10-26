using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxWebApp.Models
{
    public class Corporate
    {
        //ID for database
        public long Id { get; set; }


        //All Columns from Corporate excel sheet

        //All are type string for right now

        public string Type { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public string In { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }

        public string Preparer { get; set; }






    }
}
