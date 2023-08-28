using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger.Models.ViewModels
{
	public class CartViewModel
	{

		public User User { get; set; }
		public Product Product { get; set; }
		public Menu Menu { get; set; }
		public ICollection<Product>? Products { get; set; }
		public ICollection<Menu>? Menus { get; set; }
	}
}
