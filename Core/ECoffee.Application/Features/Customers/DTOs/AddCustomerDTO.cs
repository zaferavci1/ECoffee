﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoffee.Application.Features.Customers.DTOs
{
    public class AddCustomerDTO
    {
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Email { get; set; }
    }
}
