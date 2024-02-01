using Formularios.Models;
using Microsoft.AspNetCore.Mvc;

namespace Formularios.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[Route("Home/Detalles")]
		public IActionResult Detalles(Usuario usuario)
		{
			if (!ModelState.IsValid)
			{
				return View("Index", usuario);
			}
			else
			{

			}
			return View(usuario);

		}
	}
}
