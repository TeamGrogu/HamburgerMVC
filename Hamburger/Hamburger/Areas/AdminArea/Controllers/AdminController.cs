using Microsoft.AspNetCore.Mvc;

namespace Hamburger.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
