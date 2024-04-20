using System;
using FlowerStore.Application.ViewModel;
using MediatR;

namespace FlowerStore.Application.Queries.GetFloweById
{
    public class GetFlowerByIdQuery: IRequest<FlowerViewModel>
    {
        public int Id { get; private set; }

        public GetFlowerByIdQuery(int id)
        {
            Id = id;
        }
    }
}

