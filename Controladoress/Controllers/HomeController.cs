using Controladoress.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controladoress.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ModeloEjemplo model = new ModeloEjemplo() { Sentence = "Intro a Controladores" };
            //ModeloEjemplo m = new ModeloEjemplo();
            //m.Sentence = "Intro a Controladores";
            return View(model);            
        }

        public IActionResult EjemploParametro(string paramId)
        {
            return Content("El valor de el parámetro es: " + paramId);            
        }

        public IActionResult EjemploRouteData()
        {
            string controlador = (string)RouteData.Values["controller"];
            string accion = (string)RouteData.Values["action"];
            string id = (string)RouteData.Values["id"];

            return Content($"Información de la acción: la acción está en el controlador: {controlador}, la acción: {accion} y el id: {id}");
        }

        public IActionResult EjemploViewBag()
        {
            ViewBag.Message = "Ejemplo de ViewBag";
            return View();
        }

        public IActionResult EjemploViewData()
        {
            ViewData["Message"] = "Ejemplo de ViewData";
            return View();
        }

    }
}
