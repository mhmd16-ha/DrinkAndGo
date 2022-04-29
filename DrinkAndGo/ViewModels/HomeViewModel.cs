using DrinkAndGo.Data.Models;
using System.Collections.Generic;

namespace DrinkAndGo.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> PreferredDrinks { get; set; }

    }
}
