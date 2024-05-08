using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Core.IRepository
{
    public interface ICart
    {
        Task<List<Cart>> GetCartProducts(int userId);
        Task AddAsync(Cart cart);
    }
}