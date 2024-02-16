using Microsoft.AspNetCore.Mvc;
using Mission06_Mollinet.Models;
using System.Diagnostics;

namespace Mission06_Mollinet.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryApplicationContext _context;
        public HomeController(MovieEntryApplicationContext temp) //Constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(Application response)
        {
            _context.Applications.Add(response); //Add record to database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
