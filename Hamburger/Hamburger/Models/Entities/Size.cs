namespace Hamburger.Models.Entities
{
	public class Size
	{
        public int SizeID { get; set; }
		public string SizeName { get; set; }
		public decimal Price { get; set; }
        public ICollection<OrderDetails>? OrderDetails { get; set; }
    }
}
