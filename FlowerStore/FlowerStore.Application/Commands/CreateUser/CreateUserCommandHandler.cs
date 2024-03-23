using FlowerStore.Core.Entities;
using FlowerStore.Infrastructure.Persistence;
using MediatR;

namespace FlowerStore.Application.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly FlowerStoreDbContext _dbContext;

        public CreateUserCommandHandler(FlowerStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName, request.Username, request.Email, request.Password, request.PhoneNumber);

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user.Id;
        }
    }
}

