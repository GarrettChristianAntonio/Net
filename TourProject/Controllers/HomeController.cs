using Microsoft.AspNetCore.Mvc;

namespace TourProject.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return RedirectToAction("Index", "Ciudad");
		}
	}
}
