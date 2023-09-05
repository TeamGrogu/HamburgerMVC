using Hamburger.DAL;
using Hamburger.Models;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using MailKit.Search;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace Hamburger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;
        MenuProductVM menuProductVM = new MenuProductVM();
        private readonly UserManager<User> _userManager;

        public HomeController(ILogger<HomeController> logger, Context context, UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            menuProductVM.Products = _context.Products.Where(x => x.isActive == true).ToList();
            menuProductVM.Menus = _context.Menus.Where(x => x.isActive == true).ToList();
            menuProductVM.Categories = _context.Categories.Where(x => x.isActive == true).ToList();
            if(User.Identity.IsAuthenticated)
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                menuProductVM.Orders = _context.Orders.Where(o => o.UserID == userId).ToList();
                if (menuProductVM.DropdownOrder != null)
                {
                    menuProductVM.DropdownOrder.Clear();
                }
                if (userId != null)
                {
                    menuProductVM.DropdownOrder = _context.Orders.Where(x => x.UserID == userId).Select(x => new SelectListItem() { Text = $"{x.ID} - Price={x.TotalPrice} - OrderDate={x.UpdateDate.Day}/{x.UpdateDate.Month}/{x.UpdateDate.Year}", Value = x.ID.ToString() }).ToList();
                }
            }
            return View(menuProductVM);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(MenuProductVM model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            UserMessage message = new UserMessage()
            {
                UserID = int.Parse(userId),
                MessageOfUser = model.message
            };
            _ = model.OrderID != 0 ? message.OrderID = model.OrderID : message.OrderID = null ;
            _context.Messages.Add(message); //Burası Yapılacak...
            _context.SaveChanges();

            return RedirectToAction("Index");
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
            else if (statusCode == 403) { return View("Error403"); }
            return View();
        }
    
        //404 page bitiş
    }
}