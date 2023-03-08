using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class ActorRepository : GeneralRepository<int, Actor>
{
    public ActorRepository(MyContext context) : base(context)
    {
    }
}