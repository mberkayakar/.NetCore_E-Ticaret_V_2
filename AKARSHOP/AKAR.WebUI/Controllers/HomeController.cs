using AKAR.Business.Abstract;
using AKAR.DataAccess.Abstract;
using AKAR.DataAccess.Concrete;
using AKAR.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductServices _IProductServices; // _productRepository olarak yaz
        public HomeController(IProductServices productRepository)
        {
            _IProductServices = productRepository;
        }


        public IActionResult Index(string category)
        {

            ProductViewModel producviewmodel = new ProductViewModel()
            { 
                Products = _IProductServices.GetProductByCategory(category)
            };
            return View(producviewmodel);
        }

        public IActionResult Ekleme() // ingilizce olarak kullan
        {
            return View();
        }
    }
}
