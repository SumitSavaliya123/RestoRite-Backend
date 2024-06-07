using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestoRite_Api.Areas.Common.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        [HttpGet("test")]
        public async Task<IActionResult> TestApi()
        {
            return Ok();
        }
    }
}