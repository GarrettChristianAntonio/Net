namespace TourProject.Models
{
	public interface IData
	{
		List<Ciudad> ListaCiudades { get; set; }

		List<Ciudad> InicializarDatos();
		Ciudad GetCiudadPorId(int? id);

	}
}
