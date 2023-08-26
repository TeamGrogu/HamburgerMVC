using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hamburger.DAL
{
    public class Context:IdentityDbContext<User,Role,int>
	{
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }

        DbSet<Category> Categories { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetails> OrderDetails { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Size> Sizes { get; set; }
        DbSet<Status> Statuses { get; set; }
        DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			
		}
	}
}
