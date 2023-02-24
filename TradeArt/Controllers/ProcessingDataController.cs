using Microsoft.AspNetCore.Mvc;
using TradeArt.Services;

namespace TradeArt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessingDataController : ControllerBase
    {
        private readonly IProcessingData _processingData;

        public ProcessingDataController(IProcessingData processingData)
        {
            _processingData = processingData;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync(int count)
        {
            List<Task> tasks = new List<Task>();

            await foreach (var task in _processingData.FunctionAAsync(count))
            {
                tasks.Add(task);
            }

            await Task.WhenAll(tasks);

            return Ok(tasks);
        }
    }
}
