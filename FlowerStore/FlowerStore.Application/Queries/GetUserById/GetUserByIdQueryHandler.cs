using FlowerStore.Application.ViewModel;
using FlowerStore.Core.IRepository;
using MediatR;

namespace FlowerStore.Application.Queries.GetUserById
{
    public class GetUserByIdQueryHandler: IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly IUser _user;

        public GetUserByIdQueryHandler(IUser user)
        {
            _user = user;
        }

        public async Task<UserViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _user.GetUserById(request.Id);

            if (user == null)
            {
                return null;
            }

            return new UserViewModel(user.Id);
        }
    }
}

