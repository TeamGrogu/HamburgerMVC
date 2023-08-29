using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Hamburger.Models.Entities
{
    public class User:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public ICollection<Order>? Orders { get; set; }
		public ICollection<UserFavorites> UserFavorites { get; set; }

    }
}
