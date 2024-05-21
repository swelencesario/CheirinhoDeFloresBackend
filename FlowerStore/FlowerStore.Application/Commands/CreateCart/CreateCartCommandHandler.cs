using FlowerStore.Core;
using FlowerStore.Infrastructure.Persistence;
using MediatR;

namespace FlowerStore.Application.Commands.CreateCart
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, int>
    {
        private readonly FlowerStoreDbContext _dbContext;

        public CreateCartCommandHandler(FlowerStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {
            var cart = new Cart(request.UserId, request.ProductId,request.ProductName, request.Url, request.Quantity, request.TotalPrice, request.UnitPrice);

            await _dbContext.Cart.AddAsync(cart);
            await _dbContext.SaveChangesAsync();

            return cart.Id;
        }
    }
}