using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Abstractions.Repositories;
using OnionArchitecture.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence
{
    public static class ServiceRegistrations
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<ICustomerService, CustomerService>();
        }
    }
}
