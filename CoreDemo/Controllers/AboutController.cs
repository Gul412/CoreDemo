using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    [Area("Admin,Moderator,Member,Writer")]
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
