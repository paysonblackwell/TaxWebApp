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
            Corporate Corporates = _contextDB.Corporate.Where(m => m.Id == id).FirstOrDefault();

            //Bringing current Corporates to details page
            ViewData["corporationById"] = Corporates;

            return View();
        }
        public ActionResult AllDetails()
        {

            //Get current Corporates in DB
            Corporate[] CorporatesList = _contextDB.Corporate.ToArray();

            //Bringing current Corporates to details page
            ViewData["corporatesArray"] = CorporatesList;

            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Corporate newCorporation)
        {
            try
            {
                // insert logic for adding a new corporate tax
                _contextDB.Add(newCorporation);
                _contextDB.SaveChanges();

                // returning the details page of the new corporate tax
                return RedirectToAction(nameof(Details), new { id = newCorporation.Id });
            }
            catch
            {
                return View();
            }
        }


        // GET: Person/Edit/5
        public ActionResult Edit(long id)
        {
            //retrieve the corporate tax to edit
            Corporate corporate = _contextDB.Corporate.Where(m => m.Id == id).FirstOrDefault();

            //Bringing current Corporates to details page
            ViewData["corporationToEdit"] = corporate;

            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Corporate editedCorporation)
        {
            if (editedCorporation == null)
            {
                throw new ArgumentNullException(nameof(editedCorporation));
            }

            try
            {
                // logic for updating an entry in the database
                Corporate corporation = _contextDB.Corporate.Where(m => m.Id == id).FirstOrDefault();
                corporation.Type = editedCorporation.Number;
                corporation.Number = editedCorporation.Number;
                corporation.Name = editedCorporation.Name;
                corporation.New = editedCorporation.New;
                corporation.In = editedCorporation.In;
                corporation.Notes = editedCorporation.Notes;
                corporation.Preparer = editedCorporation.Preparer;
                corporation.Status = editedCorporation.Status;
                _contextDB.SaveChanges();

                // returning the details page of the edited corporate tax
                return RedirectToAction(nameof(Details), new { id = id });
            }
            catch
            {
                return View();
            }
        }
    }
}
