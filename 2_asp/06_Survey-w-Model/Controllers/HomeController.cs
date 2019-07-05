using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _06_Survey_w_Model.Models;

namespace _06_Survey_w_Model.Controllers
{
    public class HomeController : Controller
    {
        //=====================================================================
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            Person somePerson = new Person()
            {
                Name = "josh holloway"
            };

            ViewBag.User = somePerson;

            return View("Index", somePerson);
        }
        //=====================================================================
        [HttpPost]
        [Route("show")]
        public IActionResult Show(string name, string location, string language, string comment)
        {

            Person somePerson = new Person()
            {
                Name = name,
                Location = location,
                Language = language,
                Comment = comment
            };

            return View("Show", somePerson);
        }
        //=====================================================================
    }
}