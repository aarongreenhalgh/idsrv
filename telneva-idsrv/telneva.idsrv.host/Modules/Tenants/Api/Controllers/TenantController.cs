using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace telneva.idsrv.host.Modules.Tenants.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status400BadRequest)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class TenantController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Add()
        {
            return Ok();
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }

        [HttpGet("List")]
        public async Task<ActionResult> List()
        {
            return Ok();
        }

        [HttpPatch("{id}/Rename")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Rename(Guid id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok();
        }
    }
}
