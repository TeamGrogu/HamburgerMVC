using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult CreateOrder(int id)
        {
            Order order;

            return View();
        }
    }
}
