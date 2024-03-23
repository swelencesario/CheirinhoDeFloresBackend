using FlowerStore.Core.Entities;
using FlowerStore.Infrastructure.Persistence;
using MediatR;

namespace FlowerStore.Application.Commands.CreateAddress
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
    {
        private readonly FlowerStoreDbContext _dbContext;

        public CreateAddressCommandHandler(FlowerStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.UserId, request.ZipCode, request.Street, request.Number, request.Complement, request.Neighborhood, request.City, request.State);

            await _dbContext.Addresses.AddAsync(address);
            await _dbContext.SaveChangesAsync();

            return address.Id;
        }
    }
}

