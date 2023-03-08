using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class FilmCategoryRepository : GeneralRepository<int, FilmCategory>
{
    public FilmCategoryRepository(MyContext context) : base(context)
    {
    }
}
