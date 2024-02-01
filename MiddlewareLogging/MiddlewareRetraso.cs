namespace MiddlewareLogging
{
    public class MiddlewareRetraso
    {
        private readonly RequestDelegate _next;
        public MiddlewareRetraso(RequestDelegate next)
        {
            _next = next;
        }   
        public async Task InvokeAsync(HttpContext context)
        {
            await Task.Delay(2000);
            await _next(context);
            await Task.Delay(2000);
        }
    }
}
