using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestTask.Controllers
{
    [Route("api/sort")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GetQuery(CancellationToken cancellationToken, [FromBody] List<int> array)
        {
            array.BubbleSort();
            return Ok(array);
        }
    }
}
