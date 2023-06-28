using MediatR;
using Microsoft.AspNetCore.Mvc;
using telneva.idsrv.host.Modules.Users.Application.UseCases.Create;
using telneva.idsrv.host.Modules.Users.Domain;

namespace telneva.idsrv.host.Modules.Users.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator) => _mediator = mediator;

        [HttpPost("register")]
        [ProducesResponseType(type: typeof(CreateUserResponse), statusCode: StatusCodes.Status201Created)]
        [ProducesResponseType(type: typeof(CreateUserResponse), statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> AddUser([FromBody] Register register)
        {
            var result = await _mediator.Send(new CreateUserRequest(register));

            if(result.IsSuccess)
            {
                return Created(result.UserId, result);
            }

            return BadRequest(result);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetUser()
        {
            return Ok();
        }

        [HttpGet("List")]
        public async Task<ActionResult> ListUsers()
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> EditUser(Guid id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteUser(Guid id)
        {
            return Ok();
        }

        [HttpPatch("{id:Guid}/password/reset")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ResetPassword(Guid id)
        {
            return Ok();
        }
    }
}
