using Hamburger.Models.Entities;

namespace Hamburger.Models.ViewModels
{
    public class MenuProductVM
    {
        public ICollection<Product>? Products { get; set; }
        public ICollection<Menu>? Menus { get; set; }
    }
}
