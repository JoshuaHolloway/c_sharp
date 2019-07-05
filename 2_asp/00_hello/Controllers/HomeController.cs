using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
    {
        //---------------------------------------------------------------------
        // Requests
        // localhost:5000
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Example = "Hello World!";
            ViewResult  myView = View("Home");
            return myView;
        }
        //---------------------------------------------------------------------
        // localhost:5000/projects
        // [Route("projects")]
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            // return "These are my projects";
            ViewResult myView = View("Projects");
            return myView;
        }
        //---------------------------------------------------------------------
        // localhost:5000/hello
        // [Route("contacts")]
        [HttpGet("contact")]
        public ViewResult Contacts()
        {
            // return "This is my Contact!";
            ViewResult myView = View("Contact");
            return myView;
        }
        //---------------------------------------------------------------------
        [HttpPost]
        [Route("method")]
        public IActionResult Method(string TextField, int NumberField)
        {
            ViewBag.josh_text = TextField;
            ViewBag.josh_num = NumberField;
            ViewResult myView = View("TestForm");
            return myView;
        }
    }
}