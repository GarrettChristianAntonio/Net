using System.Runtime.CompilerServices;

namespace MiddlewareLogging
{
    public class MiddlewareLogging
    {
        private readonly RequestDelegate _next;
        private readonly ILoggingService _logger;

        public MiddlewareLogging(RequestDelegate next, ILoggingService logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            //logueamos el path del request entrante
            _logger.Loguear(LogLevel.Information, context.Request.Path);

            //Invocamos el proximo mw en el pipeline
            await _next.Invoke(context);

            //obtengo encabezados de respuesta
            var encabezadoUnicos = context.Response.Headers.Select(x => x.Key).Distinct();

            //logear esos headers 
            _logger.Loguear(LogLevel.Information, string.Join(", ", encabezadoUnicos));
        }
    }
}
