using Microsoft.AspNetCore.Mvc;

namespace TourProject.Controllers
{
	public class TuristaController : Controller
	{
		public IActionResult Index(string name)
		{
			ViewBag.TuristaNombre = name;
			return View();
		}
	}
}
