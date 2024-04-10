using FlowerStore.Application.ViewModel;
using MediatR;

namespace FlowerStore.Application.Queries.Flower
{
    public class GetFlowersQuery : IRequest<List<FlowerViewModel>>
    {
        public string Query { get; private set; }

        public GetFlowersQuery(string query)
        {
            Query = query;
        }
    }
}

