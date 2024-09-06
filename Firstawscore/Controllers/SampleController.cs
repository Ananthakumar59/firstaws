using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Firstawscore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {



        public string Message()
        {

            return "Welcome to Aws";
        }
    }
}
