﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalSystem_Arya.Base;
using MovieRentalSystem_Arya.Models;
using MovieRentalSystem_Arya.Repositories.Data;

namespace MovieRentalSystem_Arya.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CountriesController : BaseController<int, Country, CountryRepository>
{
    public CountriesController(CountryRepository repository) : base(repository)
    {
    }
}
