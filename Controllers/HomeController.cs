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
using System.Net.Http;
using Newtonsoft.Json;
using PagedList;
using Microsoft.EntityFrameworkCore;

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

        HttpClient client = new HttpClient();
        public async Task<IActionResult> Index(string sortOrder, string searchString, string searchString2, string currentFilter, int? page)
        {
            //get the current weather in seattle 
           var response = client.GetAsync("http://api.openweathermap.org/data/2.5/weather?q=seattle&APPID=00a7eaa5bbe4b48fe43e662611c50a3b").Result;
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            dynamic stuff = JsonConvert.DeserializeObject(result.ToString());

            string weather = stuff.weather[0].main;
            ViewData["Weather"] = weather;

            //set-up datetime
            DateTime dt = DateTime.Now;
            String date;
            date = dt.ToString("D", DateTimeFormatInfo.InvariantInfo);

            //Bringing date to the Home page
            ViewData["toDayDate"] = date;


            //Sorting and Search
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

           
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = sortOrder == "Name" ? "Name_desc" : "Name";
            ViewData["StatusSortParm"] = sortOrder == "Status" ? "Status_desc" : "Status";
            ViewData["PreparerSortParm"] = sortOrder == "Preparer" ? "Preparer_desc" : "Preparer";
            ViewData["NumberSortParm"] = sortOrder == "Number_desc" ? "Number" : "Number_desc";

            var persons = from p in _contextDB.Person
                          select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                persons = persons.Where(p => p.Number.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                persons = persons.Where(x => x.Name.Contains(searchString2));

            }

            switch (sortOrder)
            {
                case "Name":
                    persons = persons.OrderBy(p => p.Name);
                    break;
                case "Name_desc":
                    persons = persons.OrderByDescending(p => p.Name);
                    break;
                case "Status":
                    persons = persons.OrderBy(p => p.Status);
                    break;
                case "Status_desc":
                    persons = persons.OrderByDescending(p => p.Status);
                    break;
                case "Preparer":
                    persons = persons.OrderBy(p => p.Preparer);
                    break;
                case "Preparer_desc":
                    persons = persons.OrderByDescending(p => p.Preparer);
                    break;
                case "Number":
                    persons = persons.OrderBy(p => p.Number);
                    break;
                case "Number_desc":
                    persons = persons.OrderByDescending(p => p.Number);
                    break;
                default:
                    persons = persons.OrderBy(p => p.Number);
                    break;
            }

            //Number of items on on page
            int pageSize = 30;
            int pageNumber = (page ?? 1);

            return View(await PaginatedList<Person>.CreateAsync(persons.AsNoTracking(), page ?? 1, pageSize));
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
