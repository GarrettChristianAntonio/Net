using Microsoft.AspNetCore.Mvc;
using VistasParciales.Services;

namespace VistasParciales.Controllers
{
    public class HomeController : Controller
    {
        private IPersonaProvider _personaProvider;

        public HomeController(IPersonaProvider personaProvider)
        {
            _personaProvider = personaProvider;
        }
        public IActionResult Index()
        {
            ViewBag.Filas = 4;
            ViewBag.Columnas = 3;
            ViewBag.Alumnos = _personaProvider.PersonaList;
            return View();
        }
    }
}
