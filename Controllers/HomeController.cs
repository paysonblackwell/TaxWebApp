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

namespace TaxWebApp.Controllers
{
    public class HomeController : Controller
    {
        

        




        public IActionResult Index()
        {
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
