using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxWebApp.Data;
using TaxWebApp.Models;

namespace TaxWebApp.Controllers
{
    public class CorporatesController : Controller
    {
        //DB STUFF
        private readonly TaxDataContext _contextDB;
        public CorporatesController(TaxDataContext context)
        {
            _contextDB = context;
        }
        public ActionResult Details(int id)
        {

            //Get current Corporates in DB
            Corporate[] CorporatesList = _contextDB.Corporate.ToArray();

            //Bringing current Corporates to details page
            ViewData["corporatesArray"] = CorporatesList;

            return View();
        }
    }
}
