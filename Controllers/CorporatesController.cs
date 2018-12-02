using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            //set-up datetime
            DateTime dt = DateTime.Now;
            String date;
            date = dt.ToString("D", DateTimeFormatInfo.InvariantInfo);

            //Bringing date to the Home page
            ViewData["toDayDate"] = date;



            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            //Sorting
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = sortOrder == "Name" ? "Name_desc" : "Name";
            ViewData["StatusSortParm"] = sortOrder == "Status" ? "Status_desc" : "Status";
            ViewData["PreparerSortParm"] = sortOrder == "Preparer" ? "Preparer_desc" : "Preparer";
            ViewData["NumberSortParm"] = sortOrder == "Number" ? "Number_desc" : "Number";
            var corporates = from c in _contextDB.Corporate
                          select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                corporates = corporates.Where(p => p.Name.Contains(searchString));

            }

            switch (sortOrder)
            {
                case "Name":
                    corporates = corporates.OrderBy(p => p.Name);
                    break;
                case "Name_desc":
                    corporates = corporates.OrderByDescending(p => p.Name);
                    break;
                case "Status":
                    corporates = corporates.OrderBy(p => p.Status);
                    break;
                case "Status_desc":
                    corporates = corporates.OrderByDescending(p => p.Status);
                    break;
                case "Preparer":
                    corporates = corporates.OrderBy(p => p.Preparer);
                    break;
                case "Preparer_desc":
                    corporates = corporates.OrderByDescending(p => p.Preparer);
                    break;
                case "Number":
                    corporates = corporates.OrderBy(p => p.Number);
                    break;
                case "Number_desc":
                    corporates = corporates.OrderByDescending(p => p.Number);
                    break;
                default:
                    corporates = corporates.OrderBy(p => p.Number);
                    break;
            }

            //Number of items on on page
            int pageSize = 30;
            int pageNumber = (page ?? 1);

            return View(await PaginatedList<Corporate>.CreateAsync(corporates.AsNoTracking(), page ?? 1, pageSize));
        }

        public ActionResult AllDetails()
        {


            //Get current Corporates in DB ordered by number, pads the Number with 0's to make sure they are the same length when sorted
            Corporate[] CorporatesList = _contextDB.Corporate.OrderBy(m => m.Number.PadLeft(_contextDB.Corporate.Count(), '0')).ToArray();

            //Bringing current Corporates to details page
            ViewData["corporatesArray"] = CorporatesList;

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

        /* */
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

                //remove that person
                _contextDB.Corporate.Remove(corporate);
                _contextDB.SaveChanges();


                //Bringing current Person to details page to edit
               // ViewData["corporateToDelete"] = person;



                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
