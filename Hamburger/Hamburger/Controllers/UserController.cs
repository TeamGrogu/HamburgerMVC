using Hamburger.DAL;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Hamburger.Controllers
{
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
        public async Task<IActionResult> CompleteOrder(ShoppingCartVM model)
        {
            User user = await _userManager.GetUserAsync(User);
            Order order = _context.Orders.FirstOrDefault(x => x.StatusID == 101 && x.UserID == user.Id);
            ICollection<OrderDetails> orderDetails = _context.OrderDetails.Where(x => x.OrderID == model.Order.ID).ToList();
            return View();
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
