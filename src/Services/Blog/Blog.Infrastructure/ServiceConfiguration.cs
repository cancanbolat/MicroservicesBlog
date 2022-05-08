using Blog.Application.Interfaces;
using Blog.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Infrastructure
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddConfigureInfrastructure(this IServiceCollection services)
        {

            services.AddScoped<IPostRepository, PostRepository>();

            return services;
        }
    }
}
