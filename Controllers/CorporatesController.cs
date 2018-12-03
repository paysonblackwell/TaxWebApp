using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        // GET: Person/Create
        public ActionResult Create()
        {
            DateTime dt = DateTime.Now;
            String date = dt.ToString("MM/dd/yyyy", DateTimeFormatInfo.InvariantInfo);

            //Bringing date to the Home page
            ViewData["toDayDate"] = date;


            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Corporate newCorporation)
        {
            try
            {
                //Get the next Number
                string lastNum = Corporate.getNextNumber(_contextDB); ;
                Person.LastNumber = lastNum;

                Corporate.LastNumber = lastNum;

                newCorporation.Number = lastNum;

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
        
        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            //retrieve the person with the given id to be removed 
            Corporate corporate = _contextDB.Corporate.Where(m => m.Id == id).FirstOrDefault();

            //Bringing current corparation to details page
            ViewData["corporateToDelete"] = corporate;

            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                //retrieve the person with the given id to be removed 
                Corporate corporate = _contextDB.Corporate.Where(m => m.Id == id).FirstOrDefault();

                //save the number for re-use
                string number = corporate.Number;
                Corporate.AvailableNumbers.Push(number);

                //remove that person
                _contextDB.Corporate.Remove(corporate);
                _contextDB.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
