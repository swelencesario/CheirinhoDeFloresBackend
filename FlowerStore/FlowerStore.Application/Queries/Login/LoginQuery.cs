using FlowerStore.Application.ViewModel;
using MediatR;

namespace FlowerStore.Application.Queries.GetUser
{
    public class LoginQuery : IRequest<UserViewModel>
    {
        public string Username { get; private set;  }
        public string Password { get; private set; }

        public LoginQuery(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
