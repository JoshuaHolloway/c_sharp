using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        [Route("")]
        [HttpGet]
        public string Index()
        {
            return "This is my index";
        }

        // localhost:5000/projects
        [Route("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        // localhost:5000/hello
        [Route("contacts")]
        public string Contacts()
        {
            return "This is my Contact!";
        }
    }
}