using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class AccountRoleRepository : GeneralRepository<int, AccountRole>
{
    public AccountRoleRepository(MyContext context) : base(context)
    {
    }
}
