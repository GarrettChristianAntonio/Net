namespace Middleware
{
    public class MiddlewareRespuesta
    {
        private readonly RequestDelegate _next;

        public MiddlewareRespuesta(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("middleware respuesta");
            _next.Invoke(context);
        }

    }
}
