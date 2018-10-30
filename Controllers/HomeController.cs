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


        public IActionResult Index()
        {
            Person[] peopleList = _contextDB.Person.OrderBy(m => m.Number.PadLeft(_contextDB.Person.Count(), '0')).ToArray();
            //Bringing current People to details page
            ViewData["peopleArray"] = peopleList;
            return View();
        }

        public IActionResult Display()
        {
            Person[] peopleList = _contextDB.Person.OrderBy(m => m.Number.PadLeft(_contextDB.Person.Count(), '0')).ToArray();
            //Bringing current People to details page
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
