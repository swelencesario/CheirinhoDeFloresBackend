using FlowerStore.Core.IRepository;
using FlowerStore.Entities;
using FlowerStore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FlowerStore.Infrastructure.Repository
{
    public class FlowerRepository : IFlower
    {
        private readonly FlowerStoreDbContext _dbContext;

        public FlowerRepository(FlowerStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Flower flower)
        {
            await _dbContext.Flowers.AddAsync(flower);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Flower>> GetFlowersByCategory(string category)
        {//implementar ViewModel na camada Application
            throw new NotImplementedException();
        }

        public async Task<Flower> GetFlowerById(int id)
        {
            return await _dbContext.Flowers.SingleOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<Flower>> GetFlowers()
        {
            return await _dbContext.Flowers.ToListAsync();
        }
    }
}

