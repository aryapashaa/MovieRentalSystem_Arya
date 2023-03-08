using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class RentalRepository : GeneralRepository<int, Rental>
{
    public RentalRepository(MyContext context) : base(context)
    {
    }
}