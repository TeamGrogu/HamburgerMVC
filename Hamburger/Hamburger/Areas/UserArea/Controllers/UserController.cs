using Microsoft.AspNetCore.Mvc;

namespace Hamburger.Areas.UserArea.Controllers
{
    public class UserController : Controller
    {
        [Area("UserArea")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCart()
        {

            return View();
        }
    }
}
