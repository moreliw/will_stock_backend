using Microsoft.AspNetCore.Mvc;

namespace will_stock_backend.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TestController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("William");
        }
    }
}
