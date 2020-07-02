using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test1WithApiController : ControllerBase
    {
        // GET: api/Test1WithApi
        [HttpGet]

        [EnableCors("PolicyAllowGet")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Test1", "WithApi" };
        }

        
    }
}
