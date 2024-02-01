
namespace TourProject.Models
{
	public class Data : IData
	{
		public List<Ciudad> ListaCiudades { get; set; }
			

		public Ciudad GetCiudadPorId(int? id)
		{
			if(id == null)
			{
				return null;
			}
			else
			{
				return ListaCiudades.SingleOrDefault(c => c.Id == id);
			}

		}

		public List<Ciudad> InicializarDatos()
		{
			ListaCiudades = new List<Ciudad>()
			{
				new Ciudad() {Id=1, Nombre="New York", NombreImagen ="New_york.jpg", ImagenTipoMime="image/jpg"},
				new Ciudad() {Id=2, Nombre="London", NombreImagen ="Londonjpg", ImagenTipoMime="image/jpg"},
				new Ciudad() {Id=3, Nombre="Chicago", NombreImagen ="Chicago.jpg", ImagenTipoMime="image/jpg"}
			};
			return ListaCiudades;
		}
	}
}
