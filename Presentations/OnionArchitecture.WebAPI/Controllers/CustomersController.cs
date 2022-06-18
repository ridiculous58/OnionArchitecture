using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Abstractions.Repositories;
using OnionArchitecture.Application.Command.CreateCustomer;
using OnionArchitecture.Application.Queries.GetAllCustomer;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(CreateCustomerCommand createCustomer)
        {
            return Ok(await _mediator.Send(createCustomer));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var query = new GetAllCustomerQuery();
            return Ok(await _mediator.Send(query));
        }
    }
}
