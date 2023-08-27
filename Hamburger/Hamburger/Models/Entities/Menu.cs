using System.ComponentModel;

namespace Hamburger.Models.Entities
{
	public class Menu:BaseEntity
	{
<<<<<<< HEAD
        public Product Hamburger { get; set; }
        public Product Side { get; set; }
        public Product Drink { get; set; }
        public string? MenuImage { get; set; }
=======
        public Product? Hamburger { get; set; }
        public Product? Side { get; set; }
        public Product? Drink { get; set; }
>>>>>>> adbe343502aa110ea47799ac661478bf919f20e9
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
