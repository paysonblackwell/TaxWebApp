using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        //public async ActionResult Details(int id) //Needs to be return type void
        public ActionResult AllDetails()
        {

            //Get current People in DB
            //var peopleList = await _contextDB.Person.ToListAsync(); //async version
            Person[] peopleList = _contextDB.Person.ToArray();
            

            //Bringing current People to details page
             ViewData["peopleArray"] = peopleList;
      

            return View();

            /*OLD EXAMPLE of making a person and adding them to the DB

            //Making temp data to upload to DB
            Person examplePerson = new Person()
            {
                Number = "18000",
                Name = "Payson Blackwell",
                New = "",
                ReferedBy = "Brooke Welch",
                In = "1/1/2018",
                Scanned = "1/1/2018",
                Notes = "2018",
                Preparer = "Dave",
                Status = "Waiting on Documents"
            };

            //Checking to see if the example is already a part of it
            bool doesExist = false;
            foreach (Person p in _contextDB.Person.ToArray())
            {
                if (p.Number == "18000")
                {
                    doesExist = true;
                    break;
                }
            }

            //If Example hasn't been added, then add it and save the change
            if (doesExist == false)
            {
                //Adding the example to the DB
                _contextDB.Person.Add(examplePerson); //Other way: _context.Entry(examplePerson).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                //Save Changes
                _contextDB.SaveChanges();
            }
            */



            /*Upload to DB using OLD person properties
            //Making temp data to upload to DB
            Person examplePerson = new Person()
            {
                FirstName = "Payson",
                LastName = "Blackwell",
                Id = 1
            };


            //Checking to see if the example is already a part of it
            bool doesExist = false;
            foreach(Person p in _contextDB.Person.ToArray())
            {
                if(p.Id == 1)
                {
                    doesExist = true;
                    break;
                }
            }

            //If Example hasn't been added, then add it and save the change
            if (doesExist == false)
            {
                //Adding the example to the DB
                _contextDB.Person.Add(examplePerson); //Other way: _context.Entry(examplePerson).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                //To fix Identity Issue, Have to use a Try block and turn IDENTITY_INSERT On and then Off when saving
                //https://docs.microsoft.com/en-us/ef/core/saving/explicit-values-generated-properties#explicit-values-into-sql-server-identity-columns
                _contextDB.Database.OpenConnection();
                try
                {
                    _contextDB.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Person ON");
                    _contextDB.SaveChanges();
                    _contextDB.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Person OFF");
                }
                finally
                {
                    _contextDB.Database.CloseConnection();
                }
            }
            */
        }
    

        public ActionResult Index()
        {

            return View();
        }





        // DEFAULT STUFF
        /*************************************************************************/
        /*************************************************************************/

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person newPerson)
        {
            try
            {
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
                return RedirectToAction(nameof(Details), new { id=id});
            }
            catch
            {
                return View();
            }
        }
        
        /*
        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}
