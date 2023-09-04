using Hamburger.DAL;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using Newtonsoft.Json;
using System.Data;
using System.Security.Claims;

namespace Hamburger.Controllers
{
    [Authorize(Roles = "Standard")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly Context _context;
        private readonly ShoppingCartVM _shoppingCartVM;
        public UserController(UserManager<User> userManager, Context context, ShoppingCartVM shoppingCartVM)
        {
            _userManager = userManager;
            _context = context;
            _shoppingCartVM = shoppingCartVM;
        }
        [HttpGet("/admin/adminpanel")]
        public IActionResult UnauthorizedAccess()
        {
            return RedirectToAction("403", "SenBuralaraNerdenGeldin");
        }
        [Route("{Action}")]
		public async Task<IActionResult> ShoppingCart()
        {
            User user = await _userManager.GetUserAsync(User);
            _shoppingCartVM.User = user;
            Order order = _context.Orders.FirstOrDefault(x => x.StatusID == 101 && x.UserID == user.Id);
            _shoppingCartVM.Order = order;
            _shoppingCartVM.Menus = new List<Menu>();
            _shoppingCartVM.Products = new List<Product>();       
            if (order != null)
            {
                _shoppingCartVM.OrderDetails = _context.OrderDetails.Where(x => x.OrderID == order.ID).ToList();
                foreach (var item in _shoppingCartVM.OrderDetails)
                {
                    if (item.MenuID != null)
                        _shoppingCartVM.Menus.Add(_context.Menus.Find(item.MenuID));
                    else
                        _shoppingCartVM.Products.Add(_context.Products.Find(item.ProductID));
                }
                _shoppingCartVM.MenusProducts = _context.MenuProducts.Include(m => m.Menu).Include(p => p.Product).ToList();
                _shoppingCartVM.MenusProducts.Clear();
                foreach (var item in _shoppingCartVM.Menus)
                {
                    foreach (var mp in _context.MenuProducts.Where(x => x.MenuID == item.ID))
                    {
                        _shoppingCartVM.MenusProducts.Add(mp);
                    }
                }
                _shoppingCartVM.Sizes = _context.Sizes.ToList();
                _shoppingCartVM.ProductToppings = _context.ProductToppings.Include(x => x.Topping).Include(y => y.Product).ToList();
                _shoppingCartVM.Toppings = _context.Toppings.ToList();

                _shoppingCartVM.Dropdown = _context.Sizes.Select(x => new SelectListItem() { Text = x.SizeName, Value = x.SizeID.ToString() }).ToList();                
            }
         
            return View(_shoppingCartVM);
        }

        [HttpPost]
        public async Task<IActionResult> CompleteOrder()
        {
            User user = await _userManager.GetUserAsync(User);
            Order order = _context.Orders.FirstOrDefault(x => x.StatusID == 101 && x.UserID == user.Id);
            order.StatusID = 102;
            _context.SaveChanges();
            return RedirectToAction("ShoppingCart");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveItem(int ID)
        {
            _context.OrderDetails.Remove(_context.OrderDetails.FirstOrDefault(o => o.ID == ID));
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            Order order = _context.Orders.FirstOrDefault(x => x.StatusID == 101 && x.UserID == userId);
            _context.SaveChanges();
            var orderDetailsList = _context.OrderDetails.Where(o => o.OrderID == order.ID).ToList();

                
            if (orderDetailsList != null)
            {
                decimal totalPrice = 0;
                foreach (OrderDetails od in orderDetailsList)
                {
                    totalPrice += od.Price;
                }
                order.TotalPrice = totalPrice;
            }
            if (order.TotalPrice == 0)
            {
                _context.Orders.Remove(order);
            }
            _context.SaveChanges();
            return RedirectToAction("ShoppingCart");
        }

        public async Task<IActionResult> CreateOrder(int id)
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
