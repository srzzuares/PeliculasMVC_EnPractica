using Microsoft.AspNetCore.Mvc;

namespace Peliculas.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Movies/Welcome?name=CrystianSuar&numtimes=4
        public IActionResult Welcome(string name, int numTimes = 12)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
