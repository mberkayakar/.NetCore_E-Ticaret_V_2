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
        }// son yaptıgımdan sonra burası çalışmay başladı da layout u mu ne bulamıyo çözemedim ama db ye istek atıyo
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString() == "list")
                ViewBag.SelectedCategory = RouteData?.Values["id"];

            return View(_categoryService.GetAll());
        }
    }
}
