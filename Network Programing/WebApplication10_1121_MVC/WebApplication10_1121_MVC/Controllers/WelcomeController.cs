using Microsoft.AspNetCore.Mvc;

namespace WebApplication10_1121_MVC.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] //attribute
        public IActionResult PostData(string value1, string value2)
        {
            //value1 = HttpContext.Request.Form["Value1"]
            //value2 = HttpContext.Request.Form["Value2"]
            ViewData["Result"] = int.Parse(value1) + int.Parse(value2);
            return View();
        }
    }
}
