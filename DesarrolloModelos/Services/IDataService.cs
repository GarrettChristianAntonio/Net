using DesarrolloModelos.Models;

namespace DesarrolloModelos.Services
{
	public interface IDataService
	{
		List<Butterfly> ButterfliesList { get; set; }
		List<Butterfly> ButterfliesInitializeData();
		Butterfly GetButterflyById(int id);
		void addButterfly(Butterfly butterfly);
	}
}
