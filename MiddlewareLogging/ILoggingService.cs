namespace MiddlewareLogging
{
    public interface ILoggingService
    {
        public void Loguear(LogLevel nivel,string message);
    }
}
