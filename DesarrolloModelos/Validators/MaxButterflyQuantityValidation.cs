using DesarrolloModelos.Models;
using DesarrolloModelos.Services;
using System.ComponentModel.DataAnnotations;

namespace DesarrolloModelos.Validators
{
	public class MaxButterflyQuantityValidation : ValidationAttribute
	{
		private int _maxAmount;
		public MaxButterflyQuantityValidation(int maxAmount)
		{
			_maxAmount = maxAmount;
		}
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			var service = (IButterfliesQuantityService)validationContext.GetService(typeof(IButterfliesQuantityService));
			Butterfly butterfly = (Butterfly)validationContext.ObjectInstance;
			if(butterfly.ButterflyFamily != null)
			{
				int? quantity = service.GetButterflyFamilyQuantity(butterfly.ButterflyFamily.Value);
				int? sumQuantity = quantity + butterfly.Quantity;
				if (sumQuantity>_maxAmount)
				{
					return new ValidationResult(string.Format("Limit for quantity family is {0} butterflies. Currently the are {1}", _maxAmount, quantity));
				}
				return ValidationResult.Success;
			}
			return ValidationResult.Success;
		}
	}
}
