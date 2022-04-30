using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DrinkAndGo.ViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShopingCart _shoppingCart;

        public ShoppingCartSummary(ShopingCart shoppingCart)
        {
            _shoppingCart = shoppingCart ??
                throw new ArgumentNullException(nameof(shoppingCart));
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShopingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
    }
}
