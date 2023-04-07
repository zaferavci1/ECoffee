﻿using ECoffee.Application.Features.Customers.DTOs;
using ECoffee.Application.Utilities.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoffee.Application.Features.Customers.Commands.Update
{
    public class UpdateCustomerCommandRequest:IRequest<IDataResult<CustomerDTO>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
