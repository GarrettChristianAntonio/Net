using Microsoft.AspNetCore.Mvc;
using Filtros.Filters;

namespace Filtros.Controllers
{
	public class HomeController : Controller
	{
		[CustomActionFilter]
		public IActionResult Index()
		{
			return Content("Testeando Filtros de Acción");
		}
	}
}
