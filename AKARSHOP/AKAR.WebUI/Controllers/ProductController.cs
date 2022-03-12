using AKAR.Business.Abstract;
using AKAR.Entities;
using AKAR.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
                Product product =   _IProductServices.GetProductDetails((int)id);

                if (product == null)
                {
                    return NotFound();
                }

                var model = new ProductDetailModel
                {
                    Product = product,
                    Categories = product.ProductCategory.Select(x => x.Category).ToList()
                };

                return View(model) ;
            }
        }
    }
}
