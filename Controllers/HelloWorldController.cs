using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApps.Controllers
{
    public class HelloWorldController:Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Khoi Nguyen Tan is coming!!!!";
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Hello, World";
            return View();
        }
    }
}