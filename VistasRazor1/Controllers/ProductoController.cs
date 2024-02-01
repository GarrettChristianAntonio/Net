using Microsoft.AspNetCore.Mvc;

namespace VistasRazor1.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ProductoPrecio = new Dictionary<string, int>();
            ViewBag.ProductoPrecio.Add("Monitor", 25000);
            ViewBag.ProductoPrecio.Add("Gabinete", 55000);            
            return View();
        }
    }
}
