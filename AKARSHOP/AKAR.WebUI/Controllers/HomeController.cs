using AKAR.DataAccess.Abstract;
using AKAR.DataAccess.Concrete;
using AKAR.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public IActionResult Index()
        {

            var producviewmodel = new ProductViewModel()
            { Products = _productRepository.GetAll() };

            return View(producviewmodel);
        }
    }
}
