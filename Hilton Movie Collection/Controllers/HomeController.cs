using Hilton_Movie_Collection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hilton_Movie_Collection.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _daContext { get; set; }

        //Constructor
        public HomeController(MovieContext somename)
        {
            _daContext = somename;
        }

        //Home
        public IActionResult Index()
        {
            return View();
        }

        //Podcasts
        public IActionResult Podcasts()
        {
            return View();
        }

        //AddMovie
        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _daContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddedMovie am)
        {
            if (ModelState.IsValid)
            {
                _daContext.Add(am);
                _daContext.SaveChanges();
                return View("Confirmation", am);
            }
            else //If Invalid
            {
                ViewBag.Categories = _daContext.Categories.ToList();
                return View();
            }
        }
    }
}
