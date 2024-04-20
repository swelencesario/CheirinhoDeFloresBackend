using FlowerStore.Application.Queries.Flower;
using FlowerStore.Application.ViewModel;
using FlowerStore.Core.IRepository;
using MediatR;

namespace FlowerStore.Application.Queries.GetFlowers
{
    public class GetFlowersQueryHandler : IRequestHandler<GetFlowersQuery, List<FlowerViewModel>>
    {
        private readonly IFlower _flowerRepository;

        public GetFlowersQueryHandler(IFlower flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }

        public async Task<List<FlowerViewModel>> Handle(GetFlowersQuery request, CancellationToken cancellationToken)
        {
            var flowers = await _flowerRepository.GetFlowers();

            var flowerViewModel = flowers
                .Select(f => new FlowerViewModel(f.Id, f.Description, f.Price, f.ImageUrl))
                .ToList();

            return flowerViewModel;
        }
    }
}

