using Microsoft.AspNetCore.Mvc;

namespace HTMLHelper.Controllers
{
	public class EmpleadoController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.EmpleadosNombres = new string[] {"Michael","Christian","Gabriela","Walter","Roberto" };
			return View();
		}

		public IActionResult Detalles(string empleadoNombre)
		{
			ViewBag.EmpleadoSeleccionado = empleadoNombre;
			return View();
		}
		public IActionResult GetImagen(string empleadoNombre)
		{
			return File($@"\Images\{empleadoNombre}.jpg", "image/jpg");
		}


	}
}
