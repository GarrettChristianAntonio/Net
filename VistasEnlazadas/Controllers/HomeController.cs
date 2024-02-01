using Microsoft.AspNetCore.Mvc;
using VistasEnlazadas.Models;

namespace VistasEnlazadas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Restaurant r = new Restaurant() { Id = 1, Nombre = "La vaca Loca", Direccion= "Nazca 2100", Especialidad = "Parrilla", Abierto= true, Review = 5 };
            return View(r);
        }

        [Route("Home/Display")]
        public IActionResult OtraFormaDeVer()
        {
			Restaurant r = new Restaurant() { Id = 2, Nombre = "Que rico", Direccion = "Viva 2100", Especialidad = "Empanada", Abierto = true, Review = 7 };
			return View(r);
		}
    }
}
