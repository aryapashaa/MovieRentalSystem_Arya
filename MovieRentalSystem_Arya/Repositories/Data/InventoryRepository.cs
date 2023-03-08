using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class InventoryRepository : GeneralRepository<int, Inventory>
{
    public InventoryRepository(MyContext context) : base(context)
    {
    }
}
