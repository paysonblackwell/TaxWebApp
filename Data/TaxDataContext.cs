using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TaxWebApp.Models;

namespace TaxWebApp.Data
{
    public class TaxDataContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        public TaxDataContext(DbContextOptions<TaxDataContext> options) : base(options)
        {
            ExcelReading test = new ExcelReading();
            Database.EnsureCreated();



        }


       

        /*
         * Additional steps that might needed to create and sync local DB if something is broken
         * https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/
         * 
         * Run in Package Mangager Console: 
         *      Add-Migration InitialCreate
         *      
         *      Update-Database //If major changes to migration code, call again
         *      //IF Major changes to Model, delete Database and run program again, will recreate it correctly

         */
    }
}
