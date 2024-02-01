using Microsoft.AspNetCore.Mvc;

namespace HTMLHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
