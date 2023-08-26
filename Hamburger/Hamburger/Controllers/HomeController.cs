using Hamburger.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hamburger.Controllers
{
    public class HomeController : Controller
    {//2. commitim
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Omer
        public IActionResult Index()
        {
            // yeni yorum
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}