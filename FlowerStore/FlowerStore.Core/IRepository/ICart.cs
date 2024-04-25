using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Core.IRepository
{
    public interface ICart
    {
        Task<List<Cart>> GetCartProducts();
        Task AddAsync(Cart cart);
    }
}