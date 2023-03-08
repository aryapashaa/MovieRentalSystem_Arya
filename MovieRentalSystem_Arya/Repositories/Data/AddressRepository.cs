using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class AddressRepository : GeneralRepository<int, Address>
{
    public AddressRepository(MyContext context) : base(context)
    {
    }
}
