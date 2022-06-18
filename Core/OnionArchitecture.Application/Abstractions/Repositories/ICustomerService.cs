using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Abstractions.Repositories
{
    public interface ICustomerService : IRepository<Customer>
    {
    }

    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<IList<Customer>> GetAllAsync();
    }


}
