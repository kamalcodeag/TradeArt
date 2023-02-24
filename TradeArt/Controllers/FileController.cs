using Microsoft.AspNetCore.Mvc;
using TradeArt.Services;

namespace TradeArt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost]
        public ActionResult Post(string filePath, int chunkSize)
        {
            byte[] result = _fileService.CalculateHashedFile(filePath, chunkSize);
            return Ok(result);
        }
    }
}
