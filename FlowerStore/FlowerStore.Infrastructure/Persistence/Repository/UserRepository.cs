using FlowerStore.Core.Entities;
using FlowerStore.Core.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FlowerStore.Infrastructure.Persistence.Repository
{
    public class UserRepository : IUser
    {
        private readonly FlowerStoreDbContext _dbContext;

        public UserRepository(FlowerStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> GetUserByUsernameAndPassword(string username, string password)
        {
            return await _dbContext
                .Users
                .SingleOrDefaultAsync(u => u.UserName == username && u.Password == password);
        }

        public Task<List<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}

