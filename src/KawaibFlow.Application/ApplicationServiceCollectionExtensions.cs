using Microsoft.Extensions.DependencyInjection;

namespace KawaibFlow.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        return services;
    }
}
