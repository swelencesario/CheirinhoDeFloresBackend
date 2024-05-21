using FlowerStore.Application.Queries.GetCartProducts;
using FlowerStore.Application.ViewModel;
using FlowerStore.Core.IRepository;
using MediatR;


namespace FlowerStore.Application.Queries.GetCartProducts
{
    public class GetCartProductsQueryHandler : IRequestHandler<GetCartProductsQuery, List<CartViewModel>>
    {
        private readonly ICart _cartRepository;

        public GetCartProductsQueryHandler(ICart cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<List<CartViewModel>> Handle(GetCartProductsQuery request, CancellationToken cancellationToken)
        {
            var cartProducts = await _cartRepository.GetCartProducts(request.UserId);
            
            var cartViewModel = cartProducts
                .Select(p => new CartViewModel(p.UserId, p.ProductId,p.ProductName, p.Url, p.TotalPrice, p.Quantity, p.UnitPrice))
                .ToList();

            return cartViewModel;
        }
    }
}