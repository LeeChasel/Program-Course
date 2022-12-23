using Microsoft.AspNetCore.Mvc;
using HW2.Data;

namespace HW2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentData db = new StudentData();
            return View(db.GetStudents());
        }
        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(string id)
        {
            StudentData db = new StudentData();
            return View(db.GetStudentById(id));
        }
    }
}
