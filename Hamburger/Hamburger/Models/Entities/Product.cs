namespace Hamburger.Models.Entities
{
	public class Product:BaseEntity
	{
        public Product()
        {
            if (ID < 10)
                ID = int.Parse(CategoryID.ToString() + "0" + ID);
            else
				ID = int.Parse(CategoryID.ToString() + ID);
		}
		public string ProductName { get; set; }
        public int? CategoryID { get; set; }
        public decimal Price { get; set; }
        public string? ProductImage { get; set; }
		public string? Description { get; set; }
		public Category? Category { get; set; }
        public ICollection<OrderDetails>? OrderDetails { get; set; }
        public ICollection<MenuProduct> MenuProducts { get; set; }
    }
}
