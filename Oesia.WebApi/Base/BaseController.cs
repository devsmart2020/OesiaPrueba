using Microsoft.AspNetCore.Mvc;

namespace Oesia.WebApi.Base
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
    }
}
