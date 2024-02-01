using Microsoft.AspNetCore.Mvc;

namespace IndentityExample.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
