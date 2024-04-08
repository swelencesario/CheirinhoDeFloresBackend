using FlowerStore.Application.ViewModel;
using MediatR;

namespace FlowerStore.Application.Queries.GetUser
{
    public class GetUserForLoginQuery : IRequest<UserViewModel>
    {
        public string Username { get; private set;  }
        public string Password { get; private set; }

        public GetUserForLoginQuery(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
