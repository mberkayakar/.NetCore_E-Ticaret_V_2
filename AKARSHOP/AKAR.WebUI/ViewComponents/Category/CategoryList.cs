using AKAR.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AKAR.WebUI.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryList(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        } 
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["category"] != null)
                ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(_categoryService.GetAll());
        }
    }
}
