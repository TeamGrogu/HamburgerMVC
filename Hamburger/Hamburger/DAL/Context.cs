using Hamburger.DAL.EntityConfigurations;
using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Identity;
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
        DbSet<MenuProduct> MenuProducts { get; set; }
		protected override async void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration<User>(new UserCFG());
            builder.ApplyConfiguration<Role>(new RoleCFG());

            builder.ApplyConfiguration<Size>(new SizeCFG());

			base.OnModelCreating(builder);
		}
	}
}
