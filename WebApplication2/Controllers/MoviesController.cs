using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        //Get: movies/random
        public IActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            return View(movie);
            //return Content("Hello World");
            //return new EmptyResult();
          // return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public IActionResult Edit(int id)
        { 
            return Content("id=" + id);
        }

        //movies
        public ActionResult index(int? PageIndex, string sortBy)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", PageIndex, sortBy));

        }
    }
}
