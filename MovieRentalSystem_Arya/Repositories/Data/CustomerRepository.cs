using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class CustomerRepository : GeneralRepository<int, Customer>
{
    public CustomerRepository(MyContext context) : base(context)
    {
    }
}

