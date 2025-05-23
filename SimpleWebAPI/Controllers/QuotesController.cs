using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SimpleWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetQuotes()
        {
            var quotes = new List<string>
            {
                "Code is like humor. When you have to explain it, it’s bad.",
                "Fix the cause, not the symptom.",
                "Before software can be reusable it first has to be usable."
            };

            return Ok(quotes);
        }
    }
}
