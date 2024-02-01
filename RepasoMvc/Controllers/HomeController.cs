using Microsoft.AspNetCore.Mvc;

namespace RepasoMvc.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult _Information()
		{
			return PartialView();
		}
		public IActionResult _OtroDiv()
		{
			return PartialView();
		}
		public IActionResult _Ayuda()
		{
			return PartialView();
		}
	}
}
