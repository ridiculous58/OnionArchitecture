﻿using MediatR;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Queries.GetAllCustomer
{
    public class GetAllCustomerQuery : IRequest<IList<Customer>>
    {

    }
}
