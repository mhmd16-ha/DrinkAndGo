using DrinkAndGo.Data.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DrinkAndGo.Component
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _category;

        public CategoryMenu(ICategoryRepository category)
        {
            _category = category;
        }
        public IViewComponentResult Invoke()
        {
            var category = _category.Categories.OrderBy(x => x.CategoryName);
        
            return View(category);
        }
        }
}
