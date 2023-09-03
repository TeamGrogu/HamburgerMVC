namespace Hamburger.Models.Entities
{
	public class Topping : BaseEntity
	{
        public string ToppingName { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductTopping> ProductToppings { get; set; }
    }
}
