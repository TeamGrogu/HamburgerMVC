using Hamburger.DAL;
using Hamburger.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>
	(x => x.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));

builder.Services.AddIdentity<User, Role>
	(x =>
	{
		x.SignIn.RequireConfirmedEmail = false;
		x.Password.RequiredLength = 6;
	}).AddRoles<Role>().AddEntityFrameworkStores<Context>();
builder.Services.ConfigureApplicationCookie(
                 option =>
                 {
                     //option.LoginPath = "/Register/Login";
                     option.Cookie.Name = "UserCookie";
                     option.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                     option.SlidingExpiration = true;
                 }
             );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();
app.MapAreaControllerRoute(
    name: "User",
    areaName: "UserArea",
    pattern: "UserArea/{controller=User}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "AdminArea",
    pattern: "AdminArea/{controller=Admin}/{action=Index}/{id?}");

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
