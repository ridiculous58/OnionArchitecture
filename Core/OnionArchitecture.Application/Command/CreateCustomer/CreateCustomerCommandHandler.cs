using MediatR;
using OnionArchitecture.Application.Abstractions.Repositories;

namespace OnionArchitecture.Application.Command.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        private readonly ICustomerService _customerService;

        public CreateCustomerCommandHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<bool> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _customerService.AddAsync(new Domain.Entities.Customer
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
            });
            return true;
        }
    }
}
