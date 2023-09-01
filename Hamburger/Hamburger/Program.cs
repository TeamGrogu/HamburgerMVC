using Hamburger.DAL;
using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ShoppingCartVM>();
builder.Services.AddScoped<MenuProductVM>();
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
//404 page başlangıç
if (app.Environment.IsDevelopment())
{
    DeveloperExceptionPageOptions options = new DeveloperExceptionPageOptions();
    options.SourceCodeLineCount = 1;
    app.UseDeveloperExceptionPage(options);

}
else { app.UseExceptionHandler("/Home/Error"); }


app.UseStatusCodePagesWithRedirects("SenBuralaraNerdenGeldin/{0}");
//404 bitiş
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
