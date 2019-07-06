using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _00_hello.Models;
using DbConnection;	//if you changed the namespace of DbConnector to your own namespace, you don't need this line

namespace _00_hello.Controllers
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
                return View();
        }

    }
}
