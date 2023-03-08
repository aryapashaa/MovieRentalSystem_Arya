using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class StoreRepository : GeneralRepository<int, Store>
{
    public StoreRepository(MyContext context) : base(context)
    {
    }
}
