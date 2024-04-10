using System;
using FlowerStore.Application.Queries.Flower;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FlowerStore.API.Controllers
{
    [Route("api/flowers")]
    public class FlowerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FlowerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetFlowers(string query)
        {
            var getFlowers = new GetFlowersQuery(query);
            var flowers = await _mediator.Send(getFlowers);

            return Ok(flowers);
        }
    }
}

