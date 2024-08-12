using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionPattern_Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly MailingSettings _mailingSettings;

        public ConfigurationController(IOptions<MailingSettings> options)
        {
            _mailingSettings = options.Value;
        }

        [HttpGet]
        public ActionResult GetAllMailingSettings() => Ok(_mailingSettings);

        [HttpGet("GetPort")]
        public ActionResult GetPortMailingSettings() => Ok(_mailingSettings.Port);
    }
}