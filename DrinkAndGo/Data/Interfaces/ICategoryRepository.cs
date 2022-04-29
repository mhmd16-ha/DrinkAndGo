using System.Collections.Generic;

namespace DrinkAndGo.Data.Models.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
