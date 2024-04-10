using FlowerStore.Application.ViewModel;
using MediatR;

namespace FlowerStore.Application.Queries.GetUserById
{
    public class GetUserByIdQuery: IRequest<UserViewModel>
    {
        public int Id { get; private set; }

        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}

