namespace ErrorHandling.Servicios
{
	public interface ICounter
	{
		Dictionary<string, int> UrlCounter { get;}
		void IncrementRequestPathCount(string requestPath);
	}
}
