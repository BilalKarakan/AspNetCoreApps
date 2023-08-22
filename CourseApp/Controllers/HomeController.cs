using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Courses);
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}