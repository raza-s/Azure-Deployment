using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task23AzureConfig.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _config;
        public string ApiKeyValue { get; set; }
        public string FeatureFlagValue { get; set; }

        public IndexModel(IConfiguration config)
        {
            _config = config;
        }

        public void OnGet()
        {
            ApiKeyValue = _config["MySettings:ApiKey"];
            FeatureFlagValue = _config["MySettings:FeatureFlag"];
        }
    }
}
