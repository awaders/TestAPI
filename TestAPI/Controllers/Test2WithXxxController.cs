using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace TestAPI.Controllers
{
    [Route("xxx/[controller]")]
    [ApiController]
    public class Test2WithXxxController : ControllerBase
    {
        // GET: ap/Test2WithXxx
        [HttpGet]
        [EnableCors("PolicyAllowGet")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Test2", "WithXxx" };
        }

    }
}
