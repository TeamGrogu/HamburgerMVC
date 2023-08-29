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
                    FirstName = vm.RegisterVM.FirstName,
                    LastName = vm.RegisterVM.LastName,
                    UserName = vm.RegisterVM.UserName,
                    Email = vm.RegisterVM.Email,
                    Address = vm.RegisterVM.Address,
                    PhoneNumber = vm.RegisterVM.PhoneNumber,
                };
				IdentityResult identityResult = await userManager.CreateAsync(appUser, vm.RegisterVM.Password);
                await userManager.AddToRoleAsync(appUser, "Standard");
                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Register");
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
        public async Task<IActionResult> Login()
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserVM vm)
        {              
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByEmailAsync(vm.LoginVM.Email);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, vm.LoginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["login"] = "Credentials are incorrect.";
                        return RedirectToAction("Register",vm);
                    }
                }
            }
            return NoContent();
        }
    }
}
