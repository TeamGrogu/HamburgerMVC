namespace Hamburger.Models.Entities
{
	public class ProductTopping
	{
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int ToppingID { get; set; }
        public Product Product { get; set; }
        public Topping Topping { get; set; }
    }
}
