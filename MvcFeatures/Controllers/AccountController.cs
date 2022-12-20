using Microsoft.AspNetCore.Mvc;

namespace MvcFeatures.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
