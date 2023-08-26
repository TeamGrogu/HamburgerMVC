namespace Hamburger.Models.Entities
{
	public class Order:BaseEntity
	{
		public int UserID { get; set; }
		public decimal TotalPrice { get; set; }
        public int Status { get; set; }
		public ICollection<OrderDetails> OrderDetails { get; set; }
	}
}
