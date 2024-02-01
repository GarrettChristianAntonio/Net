using ErrorHandling.Models;
using System.Security.Cryptography.X509Certificates;

namespace ErrorHandling.Servicios
{
	public class DivisionCalculator : IDivisionCalculator
	{
		public DivisionResult GetDividedNumbers(int number)
		{
			DivisionResult divisionResult = new DivisionResult();	
			divisionResult.DivideNumber = number;
			divisionResult.DividingNumbers = new List<int>();
			for(int i=1; i<(number/0);i++)
			{
				if(number % i == 0)
				{
					divisionResult.DividingNumbers.Add(i);
				}
				
			}
			divisionResult.DividingNumbers.Add(number);
			return divisionResult;
		}
	}
}
