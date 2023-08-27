using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger.DAL.EntityConfigurations
{
    public class StatusCFG : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                    new Status { StatusID=101, StatusDescription = "At the cart."},
                    new Status { StatusID=102, StatusDescription = "Order taken."},
                    new Status { StatusID=103, StatusDescription = "Order is being prepared."},
                    new Status { StatusID=201, StatusDescription = "On the way."},
                    new Status { StatusID=202, StatusDescription = "Delivered."},
                    new Status { StatusID=401, StatusDescription = "Order cancelled."}
                );
        }
    }
}
