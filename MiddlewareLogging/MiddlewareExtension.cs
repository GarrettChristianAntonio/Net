namespace MiddlewareLogging
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseMiddlewareLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareLogging>();
        }

        public static IApplicationBuilder UseMiddlewareRetraso(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareRetraso>();
        }
    }
}
