using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class CountryRepository : GeneralRepository<int, Country>
{
    public CountryRepository(MyContext context) : base(context)
    {
    }
}
