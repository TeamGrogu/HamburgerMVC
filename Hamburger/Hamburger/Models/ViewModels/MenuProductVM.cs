using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger.Models.ViewModels
{
    public class MenuProductVM
    {
        public ICollection<SelectListItem> Dropdown { get; set; }
        public ICollection<SelectListItem> DropdownHamburgers { get; set; }
        public ICollection<SelectListItem> DropdownBeverages { get; set; }
        public ICollection<SelectListItem> DropdownSides { get; set; }
        public Product Product { get; set; }
        public Menu Menu { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Menu>? Menus { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public int SelectedHamburgerID { get; set; }
        public int SelectedSideID { get; set; }
        public int SelectedBeverageID { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<SelectListItem> DropdownOrder { get; set; }
        public int OrderID { get; set; }
        public string message { get; set; }
    }
}
