using FlowerStore.Application.ViewModel;
using FlowerStore.Core.IRepository;
using MediatR;

namespace FlowerStore.Application.Queries.GetFloweById
{
    public class GetFlowerByIdQueryHandler: IRequestHandler<GetFlowerByIdQuery, FlowerViewModel>
    {
        private readonly IFlower _flower;

        public GetFlowerByIdQueryHandler(IFlower flower)
        {
            _flower = flower;
        }

        public async Task<FlowerViewModel> Handle(GetFlowerByIdQuery request, CancellationToken cancellationToken)
        {
            var flower = await _flower.GetFlowerById(request.Id);

            if (flower == null)
            {
                return null;
            }

            return new FlowerViewModel(flower.Id, flower.Description, flower.Price, flower.ImageUrl);
        }
    }
}

