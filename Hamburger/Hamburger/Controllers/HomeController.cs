﻿using Hamburger.DAL;
using Hamburger.Models;
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
        CartViewModel cartVM = new CartViewModel();

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            menuProductVM.Categories=_context.Categories.ToList();
            menuProductVM.Products = _context.Products.ToList();
            menuProductVM.Menus = _context.Menus.ToList();
            return View(menuProductVM);
        }


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
        
    }
}