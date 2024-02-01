using DesarrolloModelos.Models;

namespace DesarrolloModelos.Services
{
	public class DataService : IDataService
	{
		public List<Butterfly> ButterfliesList 
		{
			get;
			set;
		}

		public void addButterfly(Butterfly butterfly)
		{
			ButterfliesList.Add( butterfly );
		}

		public List<Butterfly> ButterfliesInitializeData()
		{
			ButterfliesList = new List<Butterfly>()
			{
				new Butterfly(){Id=1, CommonName = "Blue", ButterflyFamily = Family.Nymphalidae, Quantity = 5, Characteristics = "The blue morpho are aproximately 10 cm wide", CreateDate = DateTime.Now, ImageMimeType = "Image/jpg", ImageName ="BlueMorpho.jpg"},
				new Butterfly(){Id=2, CommonName = "Black", ButterflyFamily = Family.Grassland, Quantity = 2, Characteristics = "The black morpho is very beatiful", CreateDate = DateTime.Now, ImageMimeType = "Image/jpg", ImageName ="Black.jpg"},
				new Butterfly(){Id=3, CommonName = "Orange", ButterflyFamily = Family.Danaine, Quantity = 3, Characteristics = "The Orange morpho are rare 40 cm wide", CreateDate = DateTime.Now, ImageMimeType = "Image/jpg", ImageName ="Orange.jpg"},
				new Butterfly(){Id=4, CommonName = "Violet", ButterflyFamily = Family.Riodinidae, Quantity = 1, Characteristics = "The violet have arms", CreateDate = DateTime.Now, ImageMimeType = "Image/jpg", ImageName ="Violet.jpg"}
			};
			return ButterfliesList;
		}

		public Butterfly GetButterflyById(int id)
		{
			if (id== null)
			{
				return null;
			}
			else
			{
				return ButterfliesList.SingleOrDefault(b => b.Id == id);
			}
		}
	}
}
