using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Blazor.WA.API.Three_tierA.AAD.UI.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APITestController : ControllerBase
    {
        private readonly ILogger<APITestController> _logger;

        public APITestController(ILogger<APITestController> logger)
        {
            _logger = logger;
        }

        // GET: api/APITest
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
        }
    }
}