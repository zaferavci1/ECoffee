﻿namespace ECoffee.Application.Features.Orders.DTOs
{
    public class GetByIdOrderDTO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<string> ProductNames { get; set; }
    }
}