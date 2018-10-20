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

        public ActionResult Details(int id)
        {
            //Making temp data to upload to DB
            Person examplePerson = new Person()
            {
                FirstName = "Payson",
                LastName = "Blackwell",
                Id = 1
            };

            //Adding example to DB if it isn't already a part of it
            bool doesExist = false;
            foreach(Person p in _contextDB.Person.ToArray())
            {
                if(p.Id == 1)
                {
                    doesExist = true;
                    break;
                }
            }

           
            if(doesExist == false)
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


            

            //Get current People in DB
            Person[] peopleList = _contextDB.Person.ToArray();

            //Bringing current People to details page
            ViewData["peopleArray"] = peopleList;
            return View();
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

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
    }
}
