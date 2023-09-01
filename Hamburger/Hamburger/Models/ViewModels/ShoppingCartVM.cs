using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger.Models.ViewModels
{
    public class ShoppingCartVM
    {
        public User User { get; set; }
        public Order Order { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<MenuProduct> MenusProducts { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Size> Sizes  { get; set; }
        public ICollection<SelectListItem> Dropdown { get; set; }
    }
}
