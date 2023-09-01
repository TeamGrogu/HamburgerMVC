using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger.Models.ViewModels
{
    public class MenuProductVM
    {
        public ICollection<SelectListItem> Dropdown { get; set; }
        public Product Product { get; set; }
        public Menu Menu { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Menu>? Menus { get; set; }
        public ICollection<Category>? Categories { get; set; }
    }
}
