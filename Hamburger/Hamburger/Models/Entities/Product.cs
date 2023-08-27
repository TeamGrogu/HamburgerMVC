namespace Hamburger.Models.Entities
{
	public class Product:BaseEntity
	{
        public Product()
        {
            switch (ID)
            {
                case < 10:
                    ID = int.Parse(CategoryID.ToString() + "000" + ID.ToString());
                    break;
                case < 100:
                    ID = int.Parse(CategoryID.ToString() + "00" + ID.ToString());
                    break;
                case < 1000:
                    ID = int.Parse(CategoryID.ToString() + "0" + ID.ToString());
                    break;
                case < 10000:
                    ID = int.Parse(CategoryID.ToString() + ID.ToString());
                    break;
            }
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
