using Microsoft.AspNetCore.Mvc;
using Sql_Lite.Data;
using Sql_Lite.Models;

namespace Sql_Lite.Controllers
{
	public class PersonController : Controller
	{
		private readonly PersonContext _context;
		public PersonController(PersonContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View(_context.People.ToList());
		}
		
		public IActionResult Edit(int id)
		{
			var person= _context.People.SingleOrDefault(p=>p.PersonId==id);
			person.FirstName = "Juan Carlos";
			_context.Update(person);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		
		
		public IActionResult Create()
		{
			_context.Add(new Person{
				PersonId = 1,
				FirstName = "Juan",
				LastName = "Perez",
				City = "Buenos Aires",
				Address = "Cramer 1653"	}
			);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Delete(int id)
		{
			var person = _context.People.SingleOrDefault(p => p.PersonId == id);
			_context.Remove(person);
			return RedirectToAction("Index");
		}

	}
}
