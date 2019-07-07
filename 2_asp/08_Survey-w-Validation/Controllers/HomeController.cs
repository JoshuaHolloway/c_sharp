using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _08_Survey_w_Validation.Models;

namespace _08_Survey_w_Validation.Controllers
{
    public class HomeController : Controller
    {
        //=====================================================================
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        //=====================================================================
        //=====================================================================
        //=====================================================================
        //=====================================================================
        [HttpGet]
        [Route("display")]
        public IActionResult Display(Person somePerson)
        {
            return View("show", somePerson);
        }
        //=====================================================================
        [HttpPost]
        [Route("show")]
        // public IActionResult Show(string name, string location, string language, string comment)
        public IActionResult Show(Person somePerson)
        {
            // Person somePerson = new Person()
            // {
            //     Name = name,
            //     Location = location,
            //     Language = language,
            //     Comment = comment
            // };

            if (ModelState.IsValid)
            {
                return RedirectToAction("Display", somePerson);
            }
            else
            {
                // If model is not valid then render view.html again
                return View("index");
            }
        }
        //=====================================================================
    }
}
