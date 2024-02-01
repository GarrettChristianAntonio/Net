using PruebasUnitarias.Models;

namespace PruebasUnitarias.Repositorios
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetProducts();
	}
}
