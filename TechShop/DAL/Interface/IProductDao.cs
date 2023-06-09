﻿using TechShop.Domain;
using TechShop.Dtos.Common;

namespace TechShop.DAL.Interface
{
    public interface IProductDao
    {
        Task<Product> CreateAsync(Product product);
        Task<bool> UpdateAsync(Product product);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ToggleActiveStatusAsync(bool isActive, Guid id);
        Task<Product> GetProductByIdAsync(Guid id);
        Task<PagedResult<Product>> GetProductsAsync(int page = 1, int pageSize = 10, bool onlyActive = false);
        Task<PagedResult<Product>> GetProductsByCategoryAsync(Guid categoryId, int page = 1, int pageSize = 10, bool onlyActive = false);

    }
}
