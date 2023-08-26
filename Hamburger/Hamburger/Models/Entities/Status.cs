namespace Hamburger.Models.Entities
{
	public class Status
	{
        public int StatusID { get; set; }
        public string StatusDescription { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
