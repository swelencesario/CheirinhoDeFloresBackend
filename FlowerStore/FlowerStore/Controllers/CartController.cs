
using FlowerStore.Application.Commands.CreateCart;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FlowerStore.Controllers
{
    [Route("api/cart")]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CartController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCartCommand command)
        {
            var id = await _mediator.Send(command);

            return Ok(id);
        }
    }
}