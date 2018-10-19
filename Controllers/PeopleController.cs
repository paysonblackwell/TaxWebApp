using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxWebApp.Data;
using TaxWebApp.Models;

namespace TaxWebApp.Controllers
{
    public class PeopleController : Controller
    {
        //DB STUFF
        private readonly TaxDataContext _context;

        public PeopleController(TaxDataContext context)
        {
            _context = context;
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

            /*

            _context.Add(examplePerson); //_context.Person.Add(examplePerson)
            //_context.Entry(examplePerson).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _context.SaveChanges();
            */

            ViewData["examplePerson"] = examplePerson;

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
