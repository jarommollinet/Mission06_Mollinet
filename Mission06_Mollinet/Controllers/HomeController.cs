using Microsoft.AspNetCore.Mvc;
using Mission06_Mollinet.Models;
using System.Diagnostics;

namespace Mission06_Mollinet.Controllers
{
    public class HomeController : Controller
    {
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
            return View("Confirmation", response);
        }
    }
}
