using Microsoft.AspNetCore.Mvc;
using telneva.idsrv.host.Modules.Token.Application.UseCases.Create;

namespace telneva.idsrv.host.Modules.Token.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status400BadRequest)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class TokenController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(type: typeof(CreateTokenResponse), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> Get()
        {
            return Created("", "");
        }
    }
}
