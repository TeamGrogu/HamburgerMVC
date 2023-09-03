using Hamburger.DAL;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
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
		[Route("{Action}")]
		public IActionResult AdminPanel()
        {
            return View();
        }

		#region LIST
		[Route("categoryList")]
		public IActionResult ListCategories()
        {
            ICollection<Category> categoryList = _context.Categories.Where(x=>x.isActive.Equals(true)).ToList();
            return View(categoryList);
        }

        private List<SelectListItem> Dropdown()
        {
            return _context.Categories.Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.ID.ToString() }).ToList();
        }
		[Route("productList")]
		public IActionResult ListProducts()
        {
            var productList = _context.Products.Where(x => x.isActive.Equals(true)).Include(x => x.Category).OrderBy(y => y.CategoryID).ToList();
            return View(productList);
        }
		[Route("menuList")]
		public IActionResult ListMenus()
        {
            var menuList = _context.Menus.Where(x => x.isActive.Equals(true)).ToList();
            return View(menuList);
        }
		[Route("toppingList")]
		public IActionResult ListToppings()
        {
            ICollection<Topping> toppingList = _context.Toppings.Where(x => x.isActive.Equals(true)).ToList();
            return View(toppingList);
        }
        #endregion

        #region DELETE
        public IActionResult DeleteCategory(int id)
        {
            _context.Categories.Find(id).isActive=false;
            _context.SaveChanges();
            return RedirectToAction("ListCategories");
        }
        public IActionResult DeleteProduct(int id)
        {
            _context.Products.Find(id).isActive=false;
            _context.SaveChanges();
            return RedirectToAction("ListProducts");
        }
        public ActionResult DeleteMenu(int id)
        {
            _context.Menus.Find(id).isActive = false;
            _context.SaveChanges();
            return RedirectToAction("ListMenus");
        }
        public ActionResult DeleteTopping(int id)
        {
            _context.Toppings.Find(id).isActive = false;
            _context.SaveChanges();
            return RedirectToAction("ListToppings");
        }
		#endregion

		#region CREATE/UPDATE
		[Route("{Action}")]
		public ActionResult EditCategory(int id = 0)
        {
            Category category = id == 0 ? new Category() : _context.Categories.FirstOrDefault(category => category.ID == id);
            return PartialView("CategoryPartialView", category);
        }

        [HttpPost]
		[Route("{Action}")]
		public ActionResult EditCategory(Category category)
        {
            bool categoryExists = _context.Categories.Any(c => c.CategoryName.Replace(" ", "").ToLower() == category.CategoryName.Replace(" ", "").ToLower());
           
            if (category.ID == 0)
            {
                // Create category
                if (categoryExists)
                {
                    _context.Categories.FirstOrDefault(c => c.CategoryName.Replace(" ", "").ToLower() == category.CategoryName.Replace(" ", "").ToLower()).isActive= true;

                }
                else
                {
                    _context.Categories.Add(category);
                }
                
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


		[Route("{Action}")]
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
		[Route("{Action}")]
		public IActionResult EditProduct(MenuProductVM model)
        {
            bool productExists = _context.Products.Any(c => c.ProductName.Replace(" ", "").ToLower() == model.Product.ProductName.Replace(" ", "").ToLower());
            if (model.Product.ID == 0)
            {
                // Create product
                if (productExists)
                {
                    var inactiveProduct = _context.Products.FirstOrDefault(c => c.ProductName.Replace(" ", "").ToLower() == model.Product.ProductName.Replace(" ", "").ToLower());
                    if (inactiveProduct != null)
                    {
                       // inactiveProduct.ProductName = model.Product.ProductName;
                        inactiveProduct.Price = model.Product.Price;
                        inactiveProduct.Description = model.Product.Description;
                        inactiveProduct.CategoryID = model.Product.CategoryID;
                        inactiveProduct.ProductImage = model.Product.ProductImage;
                    }
                    inactiveProduct.isActive = true;

                }
                else
                {
                    Product product = new Product()
                    {
                        ProductName = model.Product.ProductName,
                        Price = model.Product.Price,
                        Description = model.Product.Description,
                        CategoryID = model.Product.CategoryID,
                        ProductImage = model.Product.ProductImage
                    };
                    _context.Products.Add(product);
                }

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
                    existingProduct.ProductImage = model.Product.ProductImage;
                }
            }

            _context.SaveChanges();
            return RedirectToAction("ListProducts");
        }
		[Route("{Action}")]
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
		[Route("{Action}")]
		public IActionResult EditMenu(MenuProductVM model)
        {
            bool menuExists = _context.Menus.Any(c => c.MenuName.Replace(" ", "").ToLower() == model.Menu.MenuName.Replace(" ", "").ToLower());
            Product Hamburger = new Product();
            Product Side = new Product();
            Product Beverage = new Product();
            Hamburger = _context.Products.FirstOrDefault(x => x.ID == model.SelectedHamburgerID);
            Side = _context.Products.FirstOrDefault(x => x.ID == model.SelectedSideID);
            Beverage = _context.Products.FirstOrDefault(x => x.ID == model.SelectedBeverageID);

            if (model.Menu.ID == 0)
            {
                //Create menu
                if (menuExists)
                {
                    var inactiveMenu = _context.Menus.FirstOrDefault(c => c.MenuName.Replace(" ", "").ToLower() == model.Menu.MenuName.Replace(" ", "").ToLower());
                    if (inactiveMenu != null)
                    {
                       // inactiveMenu.MenuName = model.Menu.MenuName;
                        inactiveMenu.Price = model.Menu.Price;
                        inactiveMenu.Description = model.Menu.Description;
                        inactiveMenu.MenuImage = model.Menu.MenuImage;
                    }
                    var menuProductsList = _context.MenuProducts.Include(x => x.Product).Where(x => x.MenuID == inactiveMenu.ID).ToList();
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
                    inactiveMenu.isActive= true;
                }
                else
                {
                    Menu menu = new Menu()
                    {
                        MenuName = model.Menu.MenuName,
                        Price = model.Menu.Price,
                        Description = model.Menu.Description,
                        MenuImage = model.Menu.MenuImage
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
                    existingMenu.MenuImage = model.Menu.MenuImage;
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
		[Route("{Action}")]
		public ActionResult EditTopping(int id = 0)
        {
            Topping topping = id == 0 ? new Topping() : _context.Toppings.FirstOrDefault(topping => topping.ID == id);
            return PartialView("ToppingPartialView", topping);
        }


        [HttpPost]
		[Route("{Action}")]
		public ActionResult EditTopping(Topping topping)
        {
            bool toppingExists = _context.Toppings.Any(c => c.ToppingName.Replace(" ","").ToLower() == topping.ToppingName.Replace(" ", "").ToLower());

            if (topping.ID == 0)
            {
                // Create topping
                if (toppingExists)
                {
                   var inactiveTopping = _context.Toppings.FirstOrDefault(c => c.ToppingName.Replace(" ", "").ToLower() == topping.ToppingName.Replace(" ", "").ToLower());
                    if (inactiveTopping != null)
                    {
                        //inactiveTopping.ToppingName = topping.ToppingName;
                        inactiveTopping.Price = topping.Price;
                    }
                    inactiveTopping.isActive= true;
                }
                else
                {
                    _context.Toppings.Add(topping);
                }
                
            }
            else
            {
                // Update topping
                var existingTopping = _context.Toppings.Find(topping.ID);
                if (existingTopping != null)
                {
                    existingTopping.ToppingName = topping.ToppingName;
                    existingTopping.Price = topping.Price;
                }
            }

            _context.SaveChanges();

            return RedirectToAction("ListToppings");
        }
        #endregion






    }
}
