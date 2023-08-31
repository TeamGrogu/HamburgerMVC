using Hamburger.DAL;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly Context _context;

        public UserController(UserManager<User> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> ShoppingCart()
        {
            User user = await _userManager.GetUserAsync(User);
            Order selectedOrder = _context.Orders.FirstOrDefault(x => x.StatusID == 101 && x.UserID == user.Id);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ShoppingCart(ShoppingCartVM scvm)
        {
            User user = await _userManager.GetUserAsync(User);
            Order order = _context.Orders.FirstOrDefault(x => x.StatusID == 101 && x.UserID == user.Id);
            return View();
        }
        public  async Task<IActionResult> CreateOrder(int id)
        {
            Order order;
            User user = await _userManager.GetUserAsync(User);
            Order selectedOrder = _context.Orders.FirstOrDefault(x => x.StatusID == 101 && x.UserID == user.Id);
            if (selectedOrder != null)
            {
                order = selectedOrder;
            }
            else
            {
                order = new Order()
                {
                    UserID = user.Id,
                    StatusID = 101
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            OrderDetails orderDetails = new OrderDetails()
            {
                OrderID = order.ID,
            };
            if (id < 100)
            {
                var menu = _context.Menus.FirstOrDefault(x=>x.ID == id);
                orderDetails.MenuID = menu.ID;
                orderDetails.Price = menu.Price;
            }
            else
            {
                var product = _context.Products.FirstOrDefault(x => x.ID == id);
                orderDetails.ProductID = product.ID;
                orderDetails.Price = product.Price;
            }
            _context.OrderDetails.Add(orderDetails);
            _context.SaveChanges();
            var orderDetailsList = _context.OrderDetails.Where(x => x.OrderID == order.ID).ToList();
            decimal totalPrice = 0;
            foreach (OrderDetails od in orderDetailsList)
            {
                totalPrice += od.Price;
            }
            order.TotalPrice = totalPrice;
            _context.SaveChanges();
            return RedirectToAction("ShoppingCart");
        }
    }
}
