using ApiFirstProgramm.ConnectBase;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirstProgramm.Controllers
{
	[Route("api/[controller]")]
	public class HomeController : Controller
	{
		ApplicationConnect _db = new ApplicationConnect();
		[HttpGet]

		public IActionResult Index()
		{
			return Ok(_db.person.ToList());
		}
	}
}
