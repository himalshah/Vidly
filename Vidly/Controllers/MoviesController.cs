using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movie = new Movie { name = "Avengers" };
            return View(movie);
            //return Content("Hey whats up!");    
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
           
        }
        
        public ActionResult Edit(int id)
        {
            /*
             * passing parameters to action
             * parameter can be in URL like /home/edit/1 or in query string like /home/edit?id=1 or form data like id = 1
             */
            return Content("ID = " + id);
        }
    }
}