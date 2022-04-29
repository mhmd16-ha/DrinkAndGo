using DrinkAndGo.Data.Models;
using DrinkAndGo.Data.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DrinkAndGo.Data.Repository
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _context;

        public DrinkRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Drink> Drinks => _context.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferedDrink => _context.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId)
        {
            return _context.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
        }
    }
}
