using ErrorHandling.Models;
using ErrorHandling.Servicios;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;


namespace ErrorHandling.Controllers
{
	
	public class HomeController : Controller
	{
		IDivisionCalculator _numberCalculator;
		ICounter _counter;
		public HomeController(IDivisionCalculator numberCalculator, ICounter counter)
		{
			_counter = counter;
			_numberCalculator = numberCalculator;
		}
		public IActionResult Index()
		{
			ViewBag.NumberOfViews = _counter.UrlCounter[HttpContext.Request.GetDisplayUrl()];
			return View();
		}
		public IActionResult GetDividedNumber(int id)
		{
			ViewBag.NumberOfViews = _counter.UrlCounter[HttpContext.Request.GetDisplayUrl()];
			DivisionResult divisionResult = _numberCalculator.GetDividedNumbers(id);
			return View(divisionResult);
		}

	}
}
