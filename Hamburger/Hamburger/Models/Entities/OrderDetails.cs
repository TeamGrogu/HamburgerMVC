namespace Hamburger.Models.Entities
{
	public class OrderDetails
	{
        public int ID { get; set; }
		public int? OrderID { get; set; }
		public int? MenuID { get; set; }
		public int? ProductID { get; set; }
		public int Quantity { get; set; } = 1;
		public int? SizeID { get; set; } = 1;
		public decimal Price { get; set; }
		public Order? Order { get; set; }
		public Size? Size { get; set; }
        public Product? Products { get; set; }
		public Menu? Menu { get; set; }
    }
}