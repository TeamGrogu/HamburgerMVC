using System.ComponentModel;

namespace Hamburger.Models.Entities
{
	public class Menu:BaseEntity
	{
        public Menu()
        {
			// Tekrar incelensin...

			//decimal Price = 0;
			//foreach (var item in MenuProducts)
			//{
			//	Price += item.Product.Price;
			//}
			//Price *= 0.95m;
		}
        public string MenuName { get; set; }
		public ICollection<MenuProduct>? MenuProducts { get; set; }
        public string? MenuImage { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public ICollection<OrderDetails>? OrderDetails { get; set; }
        public ICollection<UserFavorites>? UserFavorites { get; set; }
    }
}
