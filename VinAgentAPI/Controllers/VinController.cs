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

        [HttpGet]
        public string Get()
        {
            return "Deploy to QA slot";
        }

        [HttpGet("DetailsByVIN")]
        public string DetailsByVIN(string vin)
        {
            return "This is the VIN ok: " + vin;
        }

        [HttpGet("Valuation")]
        public string Valuation()
        {
            return "Valuation is: aed 4200";
        }
    }
}
