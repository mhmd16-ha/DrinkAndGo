using System.ComponentModel.DataAnnotations;

namespace DrinkAndGo.Data.Models
{
    public class ShopingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }
        public Drink Drink { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
