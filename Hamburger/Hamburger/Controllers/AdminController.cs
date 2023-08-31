using Hamburger.DAL;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Hamburger.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly Context _context;
        private readonly MenuProductVM menuProductVM;

        public AdminController(Context context, MenuProductVM menuProductVM)
        {
            _context = context;
            this.menuProductVM = menuProductVM;
        }
        public IActionResult AdminPanel()
        {
            return View();
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category model)
        {
            Category category = new Category()
            {
                CategoryName = model.CategoryName
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("AdminPanel");
        }

        public IActionResult ListCategories()
        {
            ICollection<Category> categoryList = _context.Categories.ToList();
            return View(categoryList);
        }

        private List<SelectListItem> Dropdown()
        {
            return _context.Categories.Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.ID.ToString() }).ToList();
        }

        public IActionResult CreateProduct()
        {
            menuProductVM.Dropdown = Dropdown();
            menuProductVM.Categories = _context.Categories.ToList();
            return View(menuProductVM);
        }
        [HttpPost]
        public IActionResult CreateProduct(MenuProductVM model)
        {
            Product product = new Product()
            {
                ProductName = model.Product.ProductName,
                Price = model.Product.Price,
                Description = model.Product.Description,
                CategoryID = model.Product.CategoryID
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("AdminPanel");
        }

        public IActionResult ListProducts()
        {
            var productList = _context.Products.Include(x => x.Category).OrderBy(y => y.CategoryID).ToList();
            return View(productList);
        }
    }
}
