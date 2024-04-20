using FlowerStore.Application.ViewModel;
using FlowerStore.Core.IRepository;
using MediatR;

namespace FlowerStore.Application.Queries.GetUser
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, UserViewModel>
    {
        private readonly IUser _userRepository;

        public LoginQueryHandler(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByUsernameAndPassword(request.Username, request.Password);

            if (user == null)
            {
                return null;
            }

            return new UserViewModel(user.Id, user.FullName, user.UserName, user.Email, user.PhoneNumber);
        }
    }
}

