using Microsoft.AspNetCore.Mvc;

namespace Rutas.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Producto2(int num)
		{
			int resultado = 2 * num;
			return Content(resultado.ToString());
		}


		[Route("Calculadorar/Multiplicacion/{n1}/{n2}")]
		public IActionResult Producto(int n1, int n2)
		{
			int resultado = n1 * n2;
			return Content(resultado.ToString());
		}

		[HttpGet("Divide/{num?}")]
		public IActionResult Division2(int num)
		{
			int resultado = num / 2;
			return Content(resultado.ToString());
		}

		public IActionResult Index(int paramId = 45)
		{
			return Content($"Controlador home con parametro default: {paramId}");
		}

		[Route("Hola/{paramNombre}/{paramApellido}")]
		public IActionResult Bienvenida(string paramNombre, string paramApellido)
		{
			return Content($"Bienvenido {paramNombre} {paramApellido}");
		}
	}
}
