using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IPasswordHasher<User> passwordHasher;
        private readonly SignInManager<User> signInManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, IPasswordHasher<User> passwordHasher)
        {
            this.signInManager = signInManager;
            this.passwordHasher = passwordHasher;
            this.userManager = userManager;
        }
        public IActionResult AccessDenied(string returnUrl)
        {
            returnUrl = returnUrl is null ? "/Home/Index" : returnUrl;
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserVM vm)
        {
            if (ModelState.IsValid)
            {
                User appUser = new User()
                {
                    UserName = vm.UserName,
                    Email = vm.Email,
                };
                IdentityResult identityResult = await userManager.CreateAsync(appUser, vm.Password);
                await userManager.AddToRoleAsync(appUser, "Standart");
                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (IdentityError error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(vm);
        }
    }
}
