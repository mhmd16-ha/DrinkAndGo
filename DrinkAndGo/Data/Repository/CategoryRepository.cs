using DrinkAndGo.Data.Models;
using DrinkAndGo.Data.Models.Interfaces;
using System.Collections.Generic;

namespace DrinkAndGo.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Categories => _context.Categories;
    }
}
