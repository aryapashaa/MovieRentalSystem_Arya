using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalSystem_Arya.Base;
using MovieRentalSystem_Arya.Models;
using MovieRentalSystem_Arya.Repositories.Data;

namespace MovieRentalSystem_Arya.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class AddressesController : BaseController<int, Address, AddressRepository>
{
	public AddressesController(AddressRepository repository) : base(repository)
	{

	}
}
