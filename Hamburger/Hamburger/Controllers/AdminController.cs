using Hamburger.DAL;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Hamburger.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly Context _context;

        public AdminController(Context context, MenuProductVM menuProductVM)
        {
            _context = context;
        }
        public IActionResult AdminPanel()
        {
            return View();
        }

        #region LIST

        public IActionResult ListCategories()
        {
            ICollection<Category> categoryList = _context.Categories.ToList();
            return View(categoryList);
        }

        private List<SelectListItem> Dropdown()
        {
            return _context.Categories.Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.ID.ToString() }).ToList();
        }



        public IActionResult ListProducts()
        {
            var productList = _context.Products.Include(x => x.Category).OrderBy(y => y.CategoryID).ToList();
            return View(productList);
        }

        public IActionResult ListMenus()
        {
            var menuList = _context.Menus.ToList();
            return View(menuList);
        }
        #endregion

        #region DELETE
        public IActionResult DeleteCategory(int id)
        {
            _context.Categories.Remove(_context.Categories.Find(id));
            _context.SaveChanges();
            return RedirectToAction("ListCategories");
        }
        public IActionResult DeleteProduct(int id)
        {
            _context.Products.Remove(_context.Products.Find(id));
            _context.SaveChanges();
            return RedirectToAction("ListProducts");
        }
        public ActionResult DeleteMenu(int id)
        {
            _context.Menus.Remove(_context.Menus.Find(id));
            _context.SaveChanges();
            return RedirectToAction("ListMenus");
        }
        #endregion

        #region CREATE/UPDATE
        public ActionResult EditCategory(int id = 0)
        {
            Category category = id == 0 ? new Category() : _context.Categories.FirstOrDefault(category => category.ID == id);
            return PartialView("CategoryPartialView", category);
        }

        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            if (category.ID == 0)
            {
                // Create category
                _context.Categories.Add(category);
            }
            else
            {
                // Update category
                var existingCategory = _context.Categories.Find(category.ID);
                if (existingCategory != null)
                {
                    existingCategory.CategoryName = category.CategoryName;
                }
            }

            _context.SaveChanges();

            return RedirectToAction("ListCategories");
        }

        public IActionResult EditProduct(int id = 0)
        {
            MenuProductVM menuProductVM = new MenuProductVM
            {
                Dropdown = Dropdown(),
                Categories = _context.Categories.ToList(),
                Product = id == 0 ? new Product() : _context.Products.FirstOrDefault(p => p.ID == id)
            };

            return PartialView("ProductPartialView", menuProductVM);
        }

        [HttpPost]
        public IActionResult EditProduct(MenuProductVM model)
        {
            if (model.Product.ID == 0)
            {
                // Create product
                Product product = new Product()
                {
                    ProductName = model.Product.ProductName,
                    Price = model.Product.Price,
                    Description = model.Product.Description,
                    CategoryID = model.Product.CategoryID
                };
                _context.Products.Add(product);
            }
            else
            {
                // Update product
                var existingProduct = _context.Products.Find(model.Product.ID);
                if (existingProduct != null)
                {
                    existingProduct.ProductName = model.Product.ProductName;
                    existingProduct.Price = model.Product.Price;
                    existingProduct.Description = model.Product.Description;
                    existingProduct.CategoryID = model.Product.CategoryID;
                }
            }

            _context.SaveChanges();
            return RedirectToAction("ListProducts");
        }

<<<<<<< HEAD
=======


        public IActionResult EditMenu(int id = 0)
        {
            MenuProductVM menuProductVM = new MenuProductVM
            {
                DropdownHamburgers = _context.Products.Where(x => x.CategoryID == 1).Select(x => new SelectListItem() { Text = x.ProductName, Value = x.ID.ToString() }).ToList(),
                DropdownBeverages = _context.Products.Where(x => x.CategoryID == 3).Select(x => new SelectListItem() { Text = x.ProductName, Value = x.ID.ToString() }).ToList(),
                DropdownSides = _context.Products.Where(x => x.CategoryID == 2).Select(x => new SelectListItem() { Text = x.ProductName, Value = x.ID.ToString() }).ToList(),
                Menus = _context.Menus.ToList(),
                Menu = id == 0 ? new Menu() : _context.Menus.FirstOrDefault(m => m.ID == id)
            };
            if (id != 0)
            {
                var menuProductsList = _context.MenuProducts.Include(x => x.Product).Where(x => x.MenuID == id).ToList();
                foreach (MenuProduct menuProduct in menuProductsList)
                {
                    if (menuProduct.Product.CategoryID == 1)
                    {
                        menuProductVM.SelectedHamburgerID = menuProduct.ProductID;
                    }
                    else if (menuProduct.Product.CategoryID == 2)
                    {
                        menuProductVM.SelectedSideID = menuProduct.ProductID;

                    }
                    else if (menuProduct.Product.CategoryID == 3)
                    {
                        menuProductVM.SelectedBeverageID = menuProduct.ProductID;

                    }
                }
            }

            return PartialView("MenuPartialView", menuProductVM);
        }

        [HttpPost]
        public IActionResult EditMenu(MenuProductVM model)
        {
            Product Hamburger = new Product();
            Product Side = new Product();
            Product Beverage = new Product();
            Hamburger = _context.Products.FirstOrDefault(x => x.ID == model.SelectedHamburgerID);
            Side = _context.Products.FirstOrDefault(x => x.ID == model.SelectedSideID);
            Beverage = _context.Products.FirstOrDefault(x => x.ID == model.SelectedBeverageID);

            if (model.Menu.ID == 0)
            {
                //Create menu
                Menu menu = new Menu()
                {
                    MenuName = model.Menu.MenuName,
                    Price = model.Menu.Price,
                    Description = model.Menu.Description,
                };

                _context.Menus.Add(menu);
                _context.SaveChanges();

                if (menu.ID > 0)
                {
                    MenuProduct menuProduct1 = new MenuProduct()
                    {
                        MenuID = menu.ID,
                        ProductID = Hamburger.ID,
                    };
                    MenuProduct menuProduct2 = new MenuProduct()
                    {
                        MenuID = menu.ID,
                        ProductID = Side.ID,
                    };
                    MenuProduct menuProduct3 = new MenuProduct()
                    {
                        MenuID = menu.ID,
                        ProductID = Beverage.ID,
                    };
                    _context.MenuProducts.AddRange(menuProduct1, menuProduct2, menuProduct3);
                }
            }
            else
            {
                //Update menu
                var existingMenu = _context.Menus.Find(model.Menu.ID);

                if (existingMenu != null)
                {
                    existingMenu.MenuName = model.Menu.MenuName;
                    existingMenu.Price = model.Menu.Price;
                    existingMenu.Description = model.Menu.Description;
                }
                var menuProductsList = _context.MenuProducts.Include(x => x.Product).Where(x => x.MenuID == existingMenu.ID).ToList();
                foreach (MenuProduct menuProduct in menuProductsList)
                {
                    if (menuProduct.Product.CategoryID == 1)
                    {
                        menuProduct.ProductID = model.SelectedHamburgerID;
                    }
                    else if (menuProduct.Product.CategoryID == 2)
                    {
                        menuProduct.ProductID = model.SelectedSideID;

                    }
                    else if (menuProduct.Product.CategoryID == 3)
                    {
                        menuProduct.ProductID = model.SelectedBeverageID;

                    }
                }
            }

            _context.SaveChanges();
            return RedirectToAction("ListMenus");
        }
>>>>>>> a2332d740eccba117ce541d613019f079ef0a1ee
        #endregion


    }
}
