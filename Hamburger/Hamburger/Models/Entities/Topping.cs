namespace Hamburger.Models.Entities
{
	public class Topping : BaseEntity
	{
        public int ID { get; set; }
        public string ToppingName { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductTopping> ProductToppings { get; set; }
    }
}
