using Microsoft.AspNetCore.Mvc;
using WebApplication12_1205.Data;
using WebApplication12_1205.Models;

namespace WebApplication12_1205.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            MovieData db = new MovieData();
            return View(db.GetMovies());
        }
        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(string value1)
        {
            MovieData db = new MovieData();
            return View(db.GetMoviesByType(value1));
        }
    }
}
