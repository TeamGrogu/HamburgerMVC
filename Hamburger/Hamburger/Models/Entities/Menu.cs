using System.ComponentModel;

namespace Hamburger.Models.Entities
{
	public class Menu:BaseEntity
	{
		public ICollection<MenuProduct> MenuProducts { get; set; }
        public string? MenuImage { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
