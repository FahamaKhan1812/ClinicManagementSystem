using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult LoginPage()
        {
            return View();
        }
    }
}
