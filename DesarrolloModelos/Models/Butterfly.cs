using DesarrolloModelos.Validators;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
namespace DesarrolloModelos.Models
{
	public class Butterfly
	{

        public  int  Id { get; set; }


		[Display(Name = "Common Name")]
		[Required(ErrorMessage = "Please enter the butterfly Name")]
		public string CommonName {  get; set; }


		[Display(Name = "ButterflyFamily")]
		[Required(ErrorMessage = "Please eselect the butterfly ButterflyFamily")]
		public Family? ButterflyFamily {  get; set; }


		[Display(Name = "Quantity")]
		[Required(ErrorMessage = "Please select the butterfly Quantity")]
		[MaxButterflyQuantityValidation(50)]
		public int? Quantity {  get; set; }


		[Display(Name = "Characteristics")]
		[Required(ErrorMessage = "Please enter the butterfly Characteristics")]
		[StringLength(50)]
		public string Characteristics { get; set; }


		[DataType(DataType.DateTime)]
		[Display(Name = "Updated on: ")]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
		[Required(ErrorMessage = "Please enter the butterfly DateTime")]
		public DateTime CreateDate { get; set; }


		[Display(Name = "Butterfly: picture")]	
		[Required(ErrorMessage = "Please enter the butterfly PhotoAvatar")]
		public IFormFile PhotoAvatar { get; set; }


		public string ImageName { get; set; }
		public byte[] PhotoFile { get; set; }
		public string ImageMimeType { get; set; }
    }
}
