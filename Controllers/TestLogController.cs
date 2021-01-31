using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddingStuffAndChecking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLogController : ControllerBase
    {
        private readonly ICezLog _logger;
        public TestLogController(ICezLog logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.Info("Here is info message from the controller.");
            _logger.Debug("Here is debug message from the controller.");
            _logger.Warn("Here is warn message from the controller.");

            try
            {
                int b = 0;
                int a = 100 / b;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }

            return new string[] { "aaa", "bbb" };
        }
    }
}
