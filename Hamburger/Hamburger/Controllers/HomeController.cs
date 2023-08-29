using Hamburger.DAL;
using Hamburger.Models;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Hamburger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;
        MenuProductVM menuProductVM = new MenuProductVM();
        CartViewModel cartVM = new CartViewModel();

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
            
        }

        public IActionResult Index()
        {
            menuProductVM.Products = _context.Products.ToList();
            menuProductVM.Menus = _context.Menus.ToList();
            menuProductVM.Categories = _context.Categories.ToList();
            return View(menuProductVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}