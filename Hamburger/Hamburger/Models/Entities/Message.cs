namespace Hamburger.Models.Entities
{
    public class Message:BaseEntity
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public string UserMessage { get; set; }
        public Order Order { get; set; }
        public User User { get; set; }
    }
}
