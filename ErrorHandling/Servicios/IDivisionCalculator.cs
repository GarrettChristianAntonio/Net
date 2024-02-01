using ErrorHandling.Models;

namespace ErrorHandling.Servicios
{
	public interface IDivisionCalculator
	{
		DivisionResult GetDividedNumbers(int number);
	}
}
