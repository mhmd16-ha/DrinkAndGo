using System.Collections.Generic;

namespace DrinkAndGo.Data.Models.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferedDrink { get; }
        Drink GetDrinkById(int drinkId);
       
    }
}
