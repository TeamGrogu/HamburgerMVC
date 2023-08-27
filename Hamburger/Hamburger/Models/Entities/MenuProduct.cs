namespace Hamburger.Models.Entities
{
	public class MenuProduct
	{
		public int ID { get; set; }
		public int MenuID { get; set; }
		public int ProductID { get; set; }
		public Menu? Menu { get; set; }
		public Product? Product { get; set; }

	}
}