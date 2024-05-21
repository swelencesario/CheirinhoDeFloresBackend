
using FlowerStore.Application.Commands.CreateCart;
using FlowerStore.Application.Queries.GetCartProducts;
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

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetCartProducts(int userId)
        {
            var getProducts = new GetCartProductsQuery(userId);
            var products = await _mediator.Send(getProducts);

            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCartCommand command)
        {
            var id = await _mediator.Send(command);

            return Ok(id);
        }
    }
}