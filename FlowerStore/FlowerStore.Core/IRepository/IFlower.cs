using FlowerStore.Entities;

namespace FlowerStore.Core.IRepository
{
    public interface IFlower
    {
        Task<List<Flower>> GetFlowers();
        Task<Flower> GetFlowerById(int id);
        Task<List<Flower>> GetFlowersByCategory(string category);
        Task AddAsync(Flower flower);
    }
}

