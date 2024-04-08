using FlowerStore.Application.Commands;
using FlowerStore.Application.Commands.CreateAddress;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlowerStore.API.Controllers
{
    [Route("api/addresses")]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] CreateAddressCommand command)
        {
            var id = await _mediator.Send(command);

            return Ok(id);
        }
    }
}

