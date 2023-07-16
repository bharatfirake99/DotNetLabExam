using Microsoft.AspNetCore.Mvc;

namespace CollegeProject.Controllers
{
    public class CollegeHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
    }
}
