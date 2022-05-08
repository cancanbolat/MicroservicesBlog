using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Blog.Application
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddConfigureApplication(this IServiceCollection services)
        {
            
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
