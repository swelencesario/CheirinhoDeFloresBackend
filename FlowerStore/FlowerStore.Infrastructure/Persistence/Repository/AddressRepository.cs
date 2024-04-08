using FlowerStore.Core.Entities;
using FlowerStore.Core.IRepository;

namespace FlowerStore.Infrastructure.Persistence.Repository
{
    public class AddressRepository : IAddress
    {
        private readonly FlowerStoreDbContext _dbContext;

        public AddressRepository(FlowerStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Address address)
        {
            await _dbContext.Addresses.AddAsync(address);
            await _dbContext.SaveChangesAsync();
        }
    }
}

