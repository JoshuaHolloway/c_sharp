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
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            Person somePerson = new Person()
            {
                FirstName = "josh",
                LastName = "holloway"
            };

            ViewBag.User = somePerson;

            return View("Index", somePerson);
        }
    }
}