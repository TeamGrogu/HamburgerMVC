namespace Hamburger.Models.Entities
{
	public class BaseEntity
	{
        public int ID { get; set; }
        public bool isActive { get; set; } = true;
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public DateTime UpdateDate { get; set; }=DateTime.Now;
    }
}
