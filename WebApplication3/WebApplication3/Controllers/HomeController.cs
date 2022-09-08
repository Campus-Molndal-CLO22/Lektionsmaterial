namespace WebApplication3.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using WebApplication3.Models;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "C# Rulez!!!";
            return View();
        }

        public IActionResult Name(string name)
        {
            ViewData["Message"] = "Hello " + name;
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}