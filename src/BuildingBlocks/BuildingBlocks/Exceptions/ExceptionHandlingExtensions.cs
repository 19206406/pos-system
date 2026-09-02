using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.Exceptions
{
    public static class ExceptionHandlingExtensions
    {
        public static IServiceCollection AddSharedExceptionHandling(this IServiceCollection services)
        {
            services.AddExceptionHandler<GlobalExceptionHandler>();
            services.AddProblemDetails(options =>
            {
                options.CustomizeProblemDetails = context =>
                {
                    context.ProblemDetails.Extensions["traceId"] = context.HttpContext.TraceIdentifier;
                };
            });

            return services; 
        }
    }
}
