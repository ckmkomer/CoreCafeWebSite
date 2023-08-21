using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
