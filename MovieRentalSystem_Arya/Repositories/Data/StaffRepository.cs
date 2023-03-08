﻿using MovieRentalSystem_Arya.Contexts;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Repositories.Data;

public class StaffRepository : GeneralRepository<int, Staff>
{
    public StaffRepository(MyContext context) : base(context)
    {
    }
}
