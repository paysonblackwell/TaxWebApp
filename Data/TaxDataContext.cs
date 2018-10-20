using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            Database.EnsureCreated();
        }

        /*
         * Additional steps needed to create and sync local DB
         * https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/
         * 
         * Run in Package Mangager Console: 
         *      Add-Migration InitialCreate
         *      
         *      Update-Database //If major changes to migration code, call again

         */
    }
}
