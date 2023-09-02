using Hamburger.DAL;
using Hamburger.Models;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Hamburger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;
        MenuProductVM menuProductVM = new MenuProductVM();

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

        //404 page başlangıç
        public IActionResult Error()
        {
            return View();
        }

        [Route("SenBuralaraNerdenGeldin/{statusCode}")]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404) { ViewBag.ErrorMessage = "Üzgünüm ama böyle bir sayfa yok..."; }
            return View();
        }
        //404 page bitiş
    }
}