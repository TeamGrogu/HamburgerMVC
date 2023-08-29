using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger.DAL.EntityConfigurations
{
    public class CategoryCFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { ID=1,CategoryName="Hamburgers",isActive=true},
                new Category { ID=2,CategoryName="Sides",isActive=true},
                new Category { ID=3,CategoryName="Beverages",isActive=true},
                new Category { ID=4,CategoryName="Deserts",isActive=true},            
                new Category { ID=5,CategoryName="Sauces",isActive=true}
                );
        }
    }
}
