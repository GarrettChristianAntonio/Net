

namespace Middleware
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseMiddlewareRespuesta(this  IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareRespuesta>();
        }
    }
}
