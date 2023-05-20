﻿using CheckoutCart.Domain;
using CheckoutCart.Dtos.Common;
using CheckoutCart.Dtos.Order;
using CheckoutCart.Helpers.Enums;

namespace CheckoutCart.BLL.Interface
{
    public interface IOrderService
    {
        Task<OrderCreateResponse> CreateAsync(Guid userId);
        Task<bool> UpdateStatusAsync(Guid id, StatusCode code);
        Task<OrderSearchResponse> GetOrderByIdAsync(Guid id)
        Task<PagedResult<Order>> GetOrdersByUserAsync(Guid userId, int page = 1, int pageSize = 10);
    }
}
