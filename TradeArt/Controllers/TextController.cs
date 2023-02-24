using Microsoft.AspNetCore.Mvc;
using TradeArt.Extensions;

namespace TradeArt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetInvertedText(string text)
        {
            string invertedText = text.Invert();
            return Ok(invertedText);
        }
    }
}
