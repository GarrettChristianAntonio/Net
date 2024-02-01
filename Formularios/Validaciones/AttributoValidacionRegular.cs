using Formularios.Models;
using System.ComponentModel.DataAnnotations;

namespace Formularios.Validaciones
{
	public class AttributoValidacionRegular: ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			Usuario a = (Usuario)validationContext.ObjectInstance;
			if (!a.Vive)
			{
				return new ValidationResult("error de valor regular");
			}
			else
			{
				return ValidationResult.Success;
			}
		}
	}
}
