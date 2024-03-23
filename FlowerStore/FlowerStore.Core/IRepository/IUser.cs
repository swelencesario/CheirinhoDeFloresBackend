﻿using FlowerStore.Core.Entities;

namespace FlowerStore.Core.IRepository
{
    public interface IUser
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserByUserNameAndPassword(string username, string password);
        Task<User> GetUserById(int id);
        Task AddAsync(User user);
    }
}

