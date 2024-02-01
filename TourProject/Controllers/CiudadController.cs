using Microsoft.AspNetCore.Mvc;
using TourProject.Filtros;
using TourProject.Models;



namespace TourProject.Controllers
{
	public class CiudadController : Controller
	{
		private IData _data;
		private Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
		public CiudadController(IData data, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
		{

			_data = data;
			_environment = env;
			_data.InicializarDatos();
		}
		[ServiceFilter(typeof(LogActionFilterAttribute))]
		[Route("Tour")]
		public IActionResult Index()
		{
			ViewData["Page"] = "Buscar ciudad";
			return View();
		}
		[Route("DetallesCiudad/{id?}")]
		public IActionResult Detalles(int? id)
		{
			ViewData["Page"] = "Ciudad seleccionada";
			Ciudad ciudad = _data.GetCiudadPorId(id);
			if(ciudad == null)
			{
				return NotFound();
			}
			else
			{
				ViewBag.Titulo = ciudad.Nombre;
			}
			return View(ciudad);
		}


        [Route("ImagenCiudad/{id?}")]
        public IActionResult GetImagen(int? id)
        {
            ViewData["Mensaje"] = "Ver Imagen";
            Ciudad ciudadBuscada = _data.GetCiudadPorId(id);
            if (ciudadBuscada == null)
            {
                return NotFound();
            }
            else
            {
				string webRoothPath = _environment.WebRootPath;
				string folderPath = "\\images\\";
				string fullPath = webRoothPath + folderPath + ciudadBuscada.NombreImagen;
				FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);
				byte[] fileBytes;
				using (BinaryReader br = new BinaryReader(fileOnDisk))
				{
					fileBytes = br.ReadBytes((int)fileOnDisk.Length);
				}
				return File(fileBytes, ciudadBuscada.ImagenTipoMime);
            }            
        }


    }
}
