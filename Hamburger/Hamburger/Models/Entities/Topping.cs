namespace Hamburger.Models.Entities
{
	public class Topping
	{
        public int ID { get; set; }
        public string ToppingName { get; set; }
        public ICollection<ProductTopping> ProductToppings { get; set; }
    }
}
