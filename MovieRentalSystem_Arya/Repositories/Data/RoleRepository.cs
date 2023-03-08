using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class RoleRepository : GeneralRepository<int, Role>
{
    public RoleRepository(MyContext context) : base(context)
    {
    }
}
