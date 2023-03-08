using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class PaymentRepository : GeneralRepository<int, Payment>
{
    public PaymentRepository(MyContext context) : base(context)
    {
    }
}
