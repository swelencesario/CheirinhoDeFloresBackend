using FlowerStore.Core.Entities;

namespace FlowerStore.Core.IRepository
{
    public interface IAddress
    {
        Task AddAsync(Address address);
    }
}

