using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class CityRepository : GeneralRepository<int, City>
{
    public CityRepository(MyContext context) : base(context)
    {
    }
}
