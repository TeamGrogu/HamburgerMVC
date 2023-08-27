using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger.DAL.EntityConfigurations
{
	public class UserCFG : IEntityTypeConfiguration<User>
	{
		public async void Configure(EntityTypeBuilder<User> builder)
		{

		}
	}
}
