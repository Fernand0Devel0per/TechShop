﻿using CheckoutCart.Helpers.Enums;

namespace CheckoutCart.Dtos.Order
{
    public class OrderCreateResponse
    {
        public Guid Id { get; set; }
        public string OrderDate { get; set; }
        public StatusCode Status { get; set; }
    }
}
