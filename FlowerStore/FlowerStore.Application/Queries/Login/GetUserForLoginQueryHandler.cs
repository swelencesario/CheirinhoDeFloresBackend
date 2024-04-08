using System;
using FlowerStore.Application.ViewModel;
using FlowerStore.Core.IRepository;
using FlowerStore.Infrastructure.Persistence.Repository;
using MediatR;

namespace FlowerStore.Application.Queries.GetUser
{
    public class GetUserForLoginQueryHandler : IRequestHandler<GetUserForLoginQuery, UserViewModel>
    {
        private readonly IUser _userRepository;

        public GetUserForLoginQueryHandler(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> Handle(GetUserForLoginQuery request, CancellationToken cancellationToken)
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

