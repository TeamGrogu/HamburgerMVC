using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Hamburger.DAL.EntityConfigurations
{
	public class UserCFG : IEntityTypeConfiguration<User>
	{
		public async void Configure(EntityTypeBuilder<User> builder)
		{

		}
	}
}
