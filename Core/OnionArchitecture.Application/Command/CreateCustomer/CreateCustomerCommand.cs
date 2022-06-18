using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Command.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<bool>
    {
        public string Name { get; set; }
    }
}
