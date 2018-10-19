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
    }
}
