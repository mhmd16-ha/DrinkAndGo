using DrinkAndGo.Data;
using DrinkAndGo.Data.Models;
using DrinkAndGo.Data.Models.Interfaces;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DrinkAndGo.Controllers
{
    public class ShoppingCartController : Controller
    {
       
        private readonly ShopingCart _shopingCart;
        private readonly IDrinkRepository _drinkRepository;

        public ShoppingCartController(ShopingCart shopingCart, IDrinkRepository drinkRepository)
        {
           _shopingCart = shopingCart;
           _drinkRepository = drinkRepository;           
        } 
        public IActionResult Index()
        {
            var items= _shopingCart.GetShoppingCartItems();
            _shopingCart.ShoppingCartItems=items;
            var sCVM = new ShoppingCartViewModel
            {
                ShopingCart = _shopingCart,
                ShoppingCartTotal = _shopingCart.GetShoppingCartTotal(),
            };
            return View(sCVM);
        }
        public RedirectToActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrink=_drinkRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink != null)
            {
                _shopingCart.AddToCart(selectedDrink, 1);
            }
            return RedirectToAction("Index");

        }
        public RedirectToActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink != null)
            {
                _shopingCart.RemoveFromCart(selectedDrink);
            }
            return RedirectToAction("Index");
        }
    }
}
