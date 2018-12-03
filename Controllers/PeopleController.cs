using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TaxWebApp.Data;
using TaxWebApp.Models;

namespace TaxWebApp.Controllers
{
    public class PeopleController : Controller
    {
        //DB STUFF
        private readonly TaxDataContext _contextDB;
        public PeopleController(TaxDataContext context)
        {
            _contextDB = context;
        }



        public ActionResult Details(long id)
        {
            //get person at with the given id
            Person person = _contextDB.Person.Where(m => m.Id == id).FirstOrDefault();

            //Bringing current Person to details page
            ViewData["personById"] = person;

            return View();
        }

        public ViewResult Index()
        {
            return View(_contextDB.Person.ToList());
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
        public ActionResult Create(Person newPerson)
        {
            try
            {

                //Need to check to make sure it is a valid number and it isn't already taken

                //Get the next Number
                string lastNum = Person.getNextNumber(_contextDB);
                Person.LastNumber = lastNum;

                newPerson.Number = lastNum;


                //Insert new person into database               
                _contextDB.Add(newPerson);
                _contextDB.SaveChanges();

                //return to the details page of the person we just entered
                return RedirectToAction(nameof(Details), new { id = newPerson.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(long id)
        {
            //retrieve the person with the given is 
            Person person = _contextDB.Person.Where(m => m.Id == id).FirstOrDefault();

            //Bringing current Person to details page to edit
            ViewData["personToEdit"] = person;

            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Person editedPerson)
        {
            if (editedPerson == null)
            {
                throw new ArgumentNullException(nameof(editedPerson));
            }

            try
            {
                // logic for updating an entry in the database
                Person person = _contextDB.Person.Where(m => m.Id == id).FirstOrDefault();
                person.Number = editedPerson.Number;
                person.Name = editedPerson.Name;
                person.New = editedPerson.New;
                person.ReferedBy = editedPerson.ReferedBy;
                person.In = editedPerson.In;
                person.Scanned = editedPerson.Scanned;
                person.Notes = editedPerson.Notes;
                person.Preparer = editedPerson.Preparer;
                person.Status = editedPerson.Status;
                _contextDB.SaveChanges();

                //return the details of the edited person 
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
            //get person at with the given id
            Person person = _contextDB.Person.Where(m => m.Id == id).FirstOrDefault();

            //Bringing current Person to details page
            ViewData["personById"] = person;

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
                Person person = _contextDB.Person.Where(m => m.Id == id).FirstOrDefault();

                //save the number for re-use
                string number = person.Number;
                Person.AvailableNumbers.Push(number);

                //remove that person
                _contextDB.Person.Remove(person);
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
