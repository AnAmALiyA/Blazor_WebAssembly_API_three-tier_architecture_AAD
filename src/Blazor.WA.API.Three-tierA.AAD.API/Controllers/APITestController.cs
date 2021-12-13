using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blazor.WA.API.Three_tierA.AAD.API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class APITestController : ControllerBase
    {
        public APITestController()
        {
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