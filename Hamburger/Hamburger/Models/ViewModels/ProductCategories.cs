using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger.Models.ViewModels
{
    public class ProductCategories
    {
        public Menu Menu { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<SelectListItem> DropdownH { get; set; }
        public ICollection<SelectListItem> DropdownS { get; set; }
        public ICollection<SelectListItem> DropdownB { get; set; }
        public ICollection<Category> Categories { get; set; }
        public Product Hamburger { get; set; }
        public Product Side { get; set; }
        public Product Beverage { get; set; }
        
    }
}
