using FlowerStore.Application.Commands;
using FlowerStore.Application.Queries.GetUser;
using FlowerStore.Application.Queries.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlowerStore.API.Controllers
{
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetUserByIdQuery(id);

            var user = await _mediator.Send(query);

            if (user == null)
            {
                return NotFound();
            }
            Console.WriteLine(id);
            return Ok(user);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpGet("{username}/{password}")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var query = new LoginQuery(username, password);
            var user = await _mediator.Send(query);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}

