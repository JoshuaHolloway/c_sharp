using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quoting_Dojo.Models;
using DbConnection;	//if you changed the namespace of DbConnector to your own namespace, you don't need this line

namespace Quoting_Dojo.Controllers
{
    public class HomeController : Controller
    {
        // Get All Users
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
                List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
                // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
                ViewBag.Users = AllUsers;
                return View("Index");
        }
        //=====================================================================
        // step 1: add new route called "add" that grabs values from form and places in database.
        // step 2: redirect to /show route that retrieve values from database and copy into viewmodel to be passed into show.cshtml
        //=====================================================================
        [HttpPost]
        [Route("add")]
        // public IActionResult Add(string name_, string location_, string language_, string comment_)
        public IActionResult Add(Person user)
        {
            // -Add row to database (currently just add name)
            //               INSERT INTO users (name) VALUES ("steve");
            //               INSERT INTO users (name)                VALUES ('{user.FirstName}');
            string query = $"INSERT INTO users (name, location, language, comment) VALUES ('{user.Name}', '{user.Location}', '{user.Language}', '{user.Comment}')";
            DbConnector.Execute(query);
            //return RedirectToAction("Show", new { name = name_, location = location_, language = language_, comment = comment_});
            
    	    List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
            ViewBag.Users = AllUsers;

            return View("Show", user);
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