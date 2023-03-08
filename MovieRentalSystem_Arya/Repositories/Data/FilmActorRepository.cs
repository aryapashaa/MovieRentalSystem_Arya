using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class FilmActorRepository : GeneralRepository<int, FilmActor>
{
    public FilmActorRepository(MyContext context) : base(context)
    {
    }
}
