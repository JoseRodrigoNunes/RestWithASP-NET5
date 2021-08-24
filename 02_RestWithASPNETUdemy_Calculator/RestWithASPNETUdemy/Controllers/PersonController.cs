using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class personController : ControllerBase
    {

        private readonly ILogger<personController> _logger;

        public personController(ILogger<personController> logger)
        {
            _logger = logger;
        }

        [HttpGet ("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            
        }

    }
}
