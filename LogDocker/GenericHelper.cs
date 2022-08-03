using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDocker
{
    public class GenericHelper
    {
        private readonly ILogger<GenericHelper> _logger;
        public GenericHelper(ILogger<GenericHelper> logger)
        {
            _logger = logger;
            _logger.LogInformation(1, "GenericHelper has been constructed");
        }
        public void JustADumbFunctionCall()
        {
            _logger.LogInformation("JustADumbFunctionCall has been called");
        }
    }
}
