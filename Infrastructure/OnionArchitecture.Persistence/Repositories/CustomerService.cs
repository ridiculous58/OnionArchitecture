using OnionArchitecture.Application.Abstractions.Repositories;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence.Repositories
{
    public class CustomerService : ICustomerService
    {
        public IList<Customer> Customers { get; set; }

        public CustomerService()
        {
            Customers = new List<Customer>();
        }

        public async Task AddAsync(Customer entity)
        {
            Customers.Add(entity);
            await Task.CompletedTask;
        }

        public async Task<IList<Customer>> GetAllAsync()
        {
            return await Task.Run(() => Customers);
        }
    }
}
