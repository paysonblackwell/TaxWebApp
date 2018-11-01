using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxWebApp.Models;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using TaxWebApp.Data;
using System.Globalization;

namespace TaxWebApp.Controllers
{
    public class HomeController : Controller
    {

        //DB STUFF
        private readonly TaxDataContext _contextDB;
        public HomeController(TaxDataContext context)
        {
            _contextDB = context;
        }


        public IActionResult Index(string sortOrder)
        {
            //set-up datetime
            DateTime dt = DateTime.Now;
            String date;
            date = dt.ToString("D", DateTimeFormatInfo.InvariantInfo);

            //Bringing date to the Home page
            ViewData["toDayDate"] = date;

            Person[] peopleList = _contextDB.Person.OrderBy(m => m.Number.PadLeft(_contextDB.Person.Count(), '0')).ToArray();
            //Bringing current People to the Home page
            ViewData["peopleArray"] = peopleList;

            //Sorting
            ViewBag.NameSortParm = sortOrder == "Name" ? "Name_desc" : "Name";
            ViewBag.StatusSortParm = sortOrder == "Status" ? "Status_desc" : "Status";
            ViewBag.PreparerSortParm = sortOrder == "Preparer" ? "Preparer_desc" : "Preparer";
            var person = from p in _contextDB.Person
                           select p;
                switch (sortOrder)
                {
                    case "Name":
                    person = person.OrderBy(p => p.Name);
                        break;
                    case "Name_desc":
                    person = person.OrderByDescending(p => p.Name);
                        break;
                    case "Status":
                    person = person.OrderBy(p => p.Status);
                        break;
                    case "Status_desc":
                    person = person.OrderByDescending(p => p.Status);
                        break;
                    case "Preparer":
                    person = person.OrderBy(p => p.Preparer);
                        break;
                    case "Preparer_desc":
                    person = person.OrderByDescending(p => p.Preparer);
                        break;
                    default:
                    person = person.OrderBy(p => p.Number);
                        break;
                }
            
            return View(person.ToList());
        }


        public IActionResult Display()
        {
            Person[] peopleList = _contextDB.Person.OrderBy(m => m.Number.PadLeft(_contextDB.Person.Count(), '0')).ToArray();
            ViewData["peopleArray"] = peopleList;
            return View();
        }






        // DEFAULT STUFF
        /*************************************************************************/
        /*************************************************************************/

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
