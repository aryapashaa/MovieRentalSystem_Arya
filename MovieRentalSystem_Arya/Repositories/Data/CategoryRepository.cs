using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class CategoryRepository : GeneralRepository<int, Category>
{
    public CategoryRepository(MyContext context) : base(context)
    {
    }
}
