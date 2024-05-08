using FlowerStore.Application.ViewModel;
using MediatR;

namespace FlowerStore.Application.Queries.GetCartProducts
{
    public class GetCartProductsQuery : IRequest<List<CartViewModel>>
    {
        public int UserId { get; private set; }

        public GetCartProductsQuery(int userId) 
        {
            UserId = userId;
        }      
    }
}