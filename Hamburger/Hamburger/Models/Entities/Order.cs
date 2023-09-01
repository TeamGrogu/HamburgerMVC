namespace Hamburger.Models.Entities
{
	public class Order:BaseEntity
	{
		public int? UserID { get; set; }
		public decimal TotalPrice { get; set; }
		public string? OrderImage { get; set; }
        public int? StatusID { get; set; }
        public ICollection<OrderDetails>? OrderDetails { get; set; }
		public User? User { get; set; }
		public Status? Status { get; set; }
    }
}
