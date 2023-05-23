﻿namespace TechShop.Dtos.Product
{
    public class ProductOrderItemResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
