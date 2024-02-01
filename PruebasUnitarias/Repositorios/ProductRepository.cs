using PruebasUnitarias.Data;
using PruebasUnitarias.Models;

namespace PruebasUnitarias.Repositorios
{
	public class ProductRepository : IProductRepository
	{
		private ProductContext _context;
		public ProductRepository(ProductContext context)
		{
			_context = context;
		}
		public IEnumerable<Product> GetProducts() 
		{
			return _context.Products.ToList();
		}
	}
}
