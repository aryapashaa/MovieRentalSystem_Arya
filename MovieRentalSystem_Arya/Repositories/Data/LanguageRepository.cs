using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class LanguageRepository : GeneralRepository<int, Language>
{
    public LanguageRepository(MyContext context) : base(context)
    {
    }
}
