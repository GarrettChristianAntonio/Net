using DesarrolloModelos.Models;

namespace DesarrolloModelos.Services
{
	public interface IButterfliesQuantityService
	{
		int? GetButterflyFamilyQuantity(Family family);
		void AddButterfliesQuantityData(Butterfly butterfly);
	}
}
