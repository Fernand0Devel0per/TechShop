﻿using TechShop.Domain;

namespace TechShop.DAL.Interface
{
    public interface IProductOrderDao
    {
        Task<bool> AddProductToOrderAsync(ProductOrder productOrder);
        Task<bool> UpdateProductQuantityInOrderAsync(Guid orderId, Guid productId, int newQuantity);
        Task<bool> RemoveProductFromOrderAsync(Guid orderId, Guid productId);
        Task<IEnumerable<ProductOrder>> GetAllProductsInOrderAsync(Guid orderId);
        Task<ProductOrder> GetProductOrderAsync(Guid orderId, Guid productId);

    }
}
