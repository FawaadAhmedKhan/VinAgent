using Microsoft.AspNetCore.Mvc;

namespace VinAgentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VinController : ControllerBase
    {

        private readonly ILogger<VinController> _logger;

        public VinController(ILogger<VinController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetVin")]
        public string Get()
        {
            return "This is VINs data to be displayed. Added docker image scan. Slot deployment.";
        }
    }
}
