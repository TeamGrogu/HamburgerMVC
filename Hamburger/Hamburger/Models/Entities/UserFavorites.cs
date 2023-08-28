namespace Hamburger.Models.Entities
{
	public class UserFavorites:BaseEntity
	{
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int MenuID { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public Menu Menu { get; set; }
    }
}
