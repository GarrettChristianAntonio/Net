using Microsoft.AspNetCore.Mvc;

namespace Rutas.Controllers
{
	public class CalculadoraController : Controller
	{
		[Route("Calc/Multiplicacion/{num1}/{num2}")]
		public IActionResult Multiplicacion(int num1, int num2)
		{
			int result = num1 * num2;
			return Content("el resultado es: "+result.ToString());
		}
	}
}
