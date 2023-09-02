namespace Hamburger.Models.Entities
{
    public class UserMessage:BaseEntity
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public string MessageOfUser { get; set; }
        public Order Order { get; set; }
        public User User { get; set; }
    }
}
