using System.ComponentModel;

namespace Hamburger.Models.Entities
{
	public class Menu:BaseEntity
	{
        public int HamburgerID { get; set; }
		public int SideID { get; set; }
		public int DrinkID { get; set; }
		public Product? Hamburger { get; set; }
        public Product? Side { get; set; }
        public Product? Drink { get; set; }
        public string? MenuImage { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
