using Hamburger.DAL;
using Hamburger.Models;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
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
            menuProductVM.Products = _context.Products.ToList();
            menuProductVM.Menus = _context.Menus.ToList();
            menuProductVM.Categories = _context.Categories.ToList();
            if(User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (menuProductVM.DropdownOrder != null)
                {
                    menuProductVM.DropdownOrder.Clear();
                }
                if (userId != null)
                {
                    menuProductVM.DropdownOrder = _context.Orders.Where(x => x.UserID == int.Parse(userId)).Select(x => new SelectListItem() { Text = $"{x.ID} - Price={x.TotalPrice} - OrderDate={x.UpdateDate.Day}/{x.UpdateDate.Month}/{x.UpdateDate.Year}", Value = x.ID.ToString() }).ToList();
                }
            }
            return View(menuProductVM);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(MenuProductVM model)
        {
            User user = await _context.Users.FindAsync(User);
            UserMessage message = new UserMessage()
            {
                UserID = user.Id,
                OrderID = model.OrderID,
                MessageOfUser = model.message
            };
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