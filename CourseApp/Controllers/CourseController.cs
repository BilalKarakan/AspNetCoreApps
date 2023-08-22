using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "Course");
            }
            var course = Repository.GetById(id);
            return View(course);
        }

        public IActionResult List()
        {
            return View("CourseList", Repository.Courses);
        }
    }
}
