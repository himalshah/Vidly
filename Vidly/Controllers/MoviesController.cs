﻿using System;
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
            // return View(movie);
            //return Content("Hey whats up!");    
            //return new HttpNotFoundResult();
        }
    }
}