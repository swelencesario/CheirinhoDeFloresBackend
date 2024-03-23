namespace FlowerStore.Core.IRepository
{
    public interface ICategory
    {
        Task<List<Category>> GetCategories();
        Task AddAsync(Category category);
    }
}

