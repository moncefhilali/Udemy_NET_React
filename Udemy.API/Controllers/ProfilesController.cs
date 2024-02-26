using Microsoft.AspNetCore.Mvc;
using Udemy.Application.Profiles;

namespace Udemy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : BaseApiController
    {
        [HttpGet("{username}")]
        public async Task<IActionResult> GetProfile(string username)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Username = username}));

        }
    }
}
