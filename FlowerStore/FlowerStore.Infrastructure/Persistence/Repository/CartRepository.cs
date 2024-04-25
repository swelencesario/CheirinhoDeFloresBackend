using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowerStore.Core;
using FlowerStore.Core.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FlowerStore.Infrastructure.Persistence.Repository
{
    public class CartRepository : ICart
    {
        private readonly FlowerStoreDbContext _dbContext;

        public CartRepository(FlowerStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Cart cart)
        {
            await _dbContext.Cart.AddAsync(cart);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Cart>> GetCartProducts()
        {
            return await _dbContext.Cart.ToListAsync();
        }
    }
}