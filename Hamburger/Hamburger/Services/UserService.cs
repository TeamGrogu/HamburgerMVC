using Hamburger.DAL;
using Microsoft.EntityFrameworkCore;

namespace Hamburger.Services
{
    public class UserService : IUserService
    {
        private readonly Context db;

        public UserService(Context db)
        {
            this.db = db;
        }

        public bool IsEmailInUse(string email)
        {
            return db.Users.Any(u => u.Email == email);
        }
    }
}
