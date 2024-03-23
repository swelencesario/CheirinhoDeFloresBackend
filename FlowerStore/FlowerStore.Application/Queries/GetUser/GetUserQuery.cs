using FlowerStore.Application.ViewModel;
using MediatR;

namespace FlowerStore.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public int Id { get; private set;  }

        public GetUserQuery(int id)
        {
            Id = id;
        }
    }
}

