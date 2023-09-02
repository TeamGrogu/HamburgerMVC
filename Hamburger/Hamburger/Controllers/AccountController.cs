using Hamburger.Models.Entities;
using Hamburger.Models.ViewModels;
using Hamburger.Validations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IPasswordHasher<User> passwordHasher;
        private readonly SignInManager<User> signInManager;
		private readonly IUserService _userService;


		public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, IPasswordHasher<User> passwordHasher, IUserService userService)
        {
            this.signInManager = signInManager;
            this.passwordHasher = passwordHasher;
            this.userManager = userManager;
            this._userService = userService;
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
                    FirstName = vm.FirstName,
                    LastName = vm.LastName,
                    UserName = vm.UserName,
                    Email = vm.Email,
                    Address = vm.Address,
                    PhoneNumber = vm.PhoneNumber,
                };
                bool EmailInUse = _userService.IsEmailInUse(appUser.Email);
                IdentityResult identityResult = await userManager.CreateAsync(appUser, vm.Password);              
                if (identityResult.Succeeded && EmailInUse == false)
                {
                    await userManager.AddToRoleAsync(appUser, "Standard");
                    return RedirectToAction("Register");
                }
            }
			TempData["error"] = "An error occurred.";
			return View(vm);
        }
        public async Task<IActionResult> Login()
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserVM vm)
        {
            if (string.IsNullOrWhiteSpace(vm.Email) || string.IsNullOrWhiteSpace(vm.Password))
            {
                return View("Register",vm);
            }
            if (!ModelState.IsValid)
            {
                User user = await userManager.FindByEmailAsync(vm.Email);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, vm.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
               
            }
            return RedirectToAction("Login");
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
