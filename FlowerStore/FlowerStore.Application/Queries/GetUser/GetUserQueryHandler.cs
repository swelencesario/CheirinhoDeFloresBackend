using System;
using FlowerStore.Application.ViewModel;
using FlowerStore.Core.IRepository;
using FlowerStore.Infrastructure.Persistence.Repository;
using MediatR;

namespace FlowerStore.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserViewModel>
    {
        private readonly IUser _userRepository;

        public GetUserQueryHandler(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserById(request.Id);

            if (user == null)
            {
                return null;
            }

            return new UserViewModel(user.Id, user.FullName, user.UserName, user.Email, user.PhoneNumber);
        }
    }
}

