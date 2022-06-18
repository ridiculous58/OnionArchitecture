using MediatR;
using OnionArchitecture.Application.Abstractions.Repositories;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Queries.GetAllCustomer
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, IList<Customer>>
    {
        private readonly ICustomerService _customerService;

        public GetAllCustomerQueryHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public Task<IList<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            return _customerService.GetAllAsync();
        }
    }
}
