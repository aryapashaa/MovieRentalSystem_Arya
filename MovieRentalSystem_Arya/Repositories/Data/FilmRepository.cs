using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class FilmRepository : GeneralRepository<int, Film>
{
    public FilmRepository(MyContext context) : base(context)
    {
    }
}
