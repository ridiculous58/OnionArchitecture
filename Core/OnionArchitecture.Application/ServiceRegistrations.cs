using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Abstractions.Repositories;
using MediatR;
using System.Reflection;

namespace OnionArchitecture.Application
{
    public static class ServiceRegistrations
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
