using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionPatternWithIConfigureOptions_Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigureOptionsController : ControllerBase
    {
        private readonly MailingSettings _mailingSettings;

        public ConfigureOptionsController(IOptions<MailingSettings> options)
        {
            _mailingSettings = options.Value;
        }

        [HttpGet]
        public ActionResult GetAllMailingSettings() => Ok(_mailingSettings);

        [HttpGet("GetPort")]
        public ActionResult GetPortMailingSettings() => Ok(_mailingSettings.Port);

    }
}