using DrinkAndGo.Data.Models.Interfaces;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository drinkRepository;

        public HomeController(IDrinkRepository drinkRepository)
        {
            this.drinkRepository = drinkRepository;
        }
        public IActionResult Index()
        {
            var hVM = new HomeViewModel
            {
                PreferredDrinks = drinkRepository.PreferedDrink

            };
            return View(hVM);
        }
    }
}
