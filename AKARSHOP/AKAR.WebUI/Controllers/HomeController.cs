using AKAR.Business.Abstract;
using AKAR.DataAccess.Abstract;
using AKAR.DataAccess.Concrete;
using AKAR.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductServices _productRepository;
        public HomeController(IProductServices productRepository)
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
