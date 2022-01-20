using IdentityServer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CoffeeShopController : ControllerBase
	{
		private readonly ICoffeeShopService coffeeShopService;

		public CoffeeShopController(ICoffeeShopService coffeeShopService)
		{
			this.coffeeShopService = coffeeShopService;
		}

		[HttpGet]
		public async Task<IActionResult> List()
		{
			var coffeeShops = await coffeeShopService.List();
			return Ok(coffeeShops);
		}
	}
}
