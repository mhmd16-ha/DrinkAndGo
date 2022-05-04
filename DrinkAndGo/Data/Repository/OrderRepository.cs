using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Repositores
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShopingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShopingCart shoppingCart)
        {
            _appDbContext = appDbContext ??
                throw new ArgumentNullException(nameof(appDbContext));
            _shoppingCart = shoppingCart ??
                throw new ArgumentNullException(nameof(shoppingCart));
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.UtcNow;
            _appDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    DrinkId = item.Drink.DrinkId,
                    OrderId = order.OrderId,
                    Price = item.Drink.Price
                };
            }
            _appDbContext.SaveChanges();
        }
    }
}
