using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [HttpPost]
        async public Task<IActionResult> GetQuery(CancellationToken cancellationToken, [FromBody] AnArray array)
        {
            array.Array.BubbleSort();
            return Ok(array);
        }
    }
}
