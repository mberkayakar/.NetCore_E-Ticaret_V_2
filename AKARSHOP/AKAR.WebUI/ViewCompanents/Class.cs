using AKAR.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.ViewCompanents
{
    public class CategoryViewComponent:ViewComponent
    {

        private ICategoryService _categoryService;
        public CategoryViewComponent(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString() == "list")
                ViewBag.SelectedCategory = RouteData?.Values["id"];

            return View(_categoryService.GetAll());
        }
    }
}
