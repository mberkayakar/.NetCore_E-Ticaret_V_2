using AKAR.Business.Abstract;
using AKAR.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductServices _IProductServices;
        public ProductController(IProductServices productRepository)
        {
            _IProductServices = productRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            else
            {
                Product product =   _IProductServices.GetById((int)id);

                if (product == null)
                {
                    return NotFound();
                }
                return View(product);
            }
        }
    }
}
