using Formularios.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Formularios.Models
{
	public class Usuario
	{
		public int Id { get; set; }
		[Display(Name ="Nombre completo")]
		[Required(ErrorMessage = "error ingreso obligatorio")]
		public string Nombre { get; set; }

		[Display(Name = "Correo electrónico")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Display(Name = "Fecha de nacimiento")]
		[DataType(DataType.DateTime)]
		public DateTime Nacimiento { get; set; }

		[Display(Name = "Contraseña")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[AttributoValidacionRegular]
		public bool Vive {  get; set; }

	}
}
