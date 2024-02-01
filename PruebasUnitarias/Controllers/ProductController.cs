using Microsoft.AspNetCore.Mvc;
using PruebasUnitarias.Repositorios;

namespace PruebasUnitarias.Controllers
{
	public class ProductController : Controller
	{
		private IProductRepository _repository;
		public ProductController(IProductRepository repository)
		{
			_repository = repository;
		}
		public IActionResult Index()
		{
			var products = _repository.GetProducts();
			return View(products);
		}
		public IActionResult GetProducts(int id)
		{
			var product = _repository.GetProducts().Where(p => p.Id == id).FirstOrDefault();
			return View(product);
		}
		public IActionResult GetImage(string name)
		{
			return File($@"images\{name}.png", "image/png");
		}
	}
}
