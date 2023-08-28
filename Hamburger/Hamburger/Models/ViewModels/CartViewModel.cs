using Hamburger.Models.Entities;

namespace Hamburger.Models.ViewModels
{
	public class CartViewModel
	{
		public int UserID { get; set; }
		public int ProductID { get; set; }
		public int MenuID { get; set; }
		public User User { get; set; }
		public Product Product { get; set; }
		public Menu Menu { get; set; }
	}
}
