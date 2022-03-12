using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
