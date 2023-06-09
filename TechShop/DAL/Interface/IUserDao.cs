﻿using TechShop.Domain;

namespace TechShop.DAL.Interface
{
    public interface IUserDao
    {
        Task<User> FindByUsernameAsync(string username);
        Task<User> FindByIdAsync(Guid userId);
        Task<User> CreateAsync(User user);
        Task<bool> UpdateAsync(User user);
    }
}
