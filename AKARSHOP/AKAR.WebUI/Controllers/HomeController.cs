using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
