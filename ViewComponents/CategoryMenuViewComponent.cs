using Microsoft.AspNetCore.Mvc;
using MovieWeb.Data;

namespace MovieWeb.Models.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        //{controller}{action}{id}
        ///home/index/3
        //RouteData.Values["Controller"] => home
        //RouteData.Values["action"] => index
        //RouteData.Values["id"] => 3

        public IViewComponentResult Invoke()
        {
            if(RouteData.Values["action"].ToString() == "Index")
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}