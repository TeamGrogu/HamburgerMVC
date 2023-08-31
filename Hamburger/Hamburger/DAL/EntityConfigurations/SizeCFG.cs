using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger.DAL.EntityConfigurations
{
	public class SizeCFG : IEntityTypeConfiguration<Size>
	{
		public void Configure(EntityTypeBuilder<Size> builder)
		{
			builder.HasData(
				new Size { SizeID=1,SizeName="Küçük Boy"},
				new Size { SizeID=2,SizeName="Orta Boy", Price = 8 },
				new Size { SizeID=3,SizeName="Büyük Boy", Price = 12 }
				);
		}
	}
}
