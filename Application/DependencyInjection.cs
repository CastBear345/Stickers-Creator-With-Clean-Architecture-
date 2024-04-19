using Application.Interfaces;
using Application.Mapping;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddTransient<IStickerService, StickerService>();

        services.AddAutoMapper(typeof(StickerMapping));

        return services;
    }
}