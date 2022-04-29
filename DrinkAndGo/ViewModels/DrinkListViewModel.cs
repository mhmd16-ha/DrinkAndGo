using DrinkAndGo.Data.Models;
using System.Collections.Generic;

namespace DrinkAndGo.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
