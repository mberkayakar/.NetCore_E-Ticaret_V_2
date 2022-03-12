using AKAR.Business.Abstract;
using AKAR.DataAccess.Abstract;
using AKAR.DataAccess.Concrete;
using AKAR.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductServices _IProductServices;
        public HomeController(IProductServices productRepository)
        {
            _IProductServices = productRepository;
        }


        public IActionResult Index()
        {

            ProductViewModel producviewmodel = new ProductViewModel()
            { 
                Products = _IProductServices.GetAll()
            };


            return View(producviewmodel);
        }

        public IActionResult Ekleme()
        {

            

            return View();
        }
    }
}
