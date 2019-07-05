using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _05_ViewModel_Fun.Models;

namespace _05_ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        //=====================================================================
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        //=====================================================================
        [HttpPost]
        [Route("show")]
        public IActionResult Show(string name, string location, string language, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("Show");
        }
        //=====================================================================
    }
}