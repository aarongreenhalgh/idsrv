using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using telneva.idsrv.host.Modules.SMS.Application.UseCases.Send;

namespace telneva.idsrv.host.Modules.SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status400BadRequest)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status429TooManyRequests)]
    public class SMSController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(type: typeof(SendSMSResponse), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> Send()
        {
            return Created("", "");
        }

        [HttpPost("template")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> AddTemplate()
        {
            return Created("", "");
        }

        [HttpGet("template/{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> GetTemplate()
        {
            return Created("", "");
        }

        [HttpGet("template/list")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> GetTemplateList()
        {
            return Created("", "");
        }

        [HttpDelete("template/{id}")]
        [ProducesResponseType(type: typeof(string), statusCode: StatusCodes.Status201Created)]
        public async Task<ActionResult> DeleteTemplate()
        {
            return Created("", "");
        }
    }
}
