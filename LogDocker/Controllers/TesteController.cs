using LogDocker.Constracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController:ControllerBase
    {
        private readonly ILoggerManager _logger;
        public TesteController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInfo("Xaxa informa.");
            _logger.LogDebug("Xaxa debuga.");
            _logger.LogWarn("Xaxa avisa.");
            _logger.LogError("Xaxa errou."); 
            return "Teste";
        }
    }
}
