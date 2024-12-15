using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieReviews1.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public string GetRequestId()
        {
            return requestId;
        }

        public void SetRequestId(string value)
        {
            requestId = value;
        }

        public bool ShowRequestId => !string.IsNullOrEmpty(GetRequestId());

        private readonly ILogger<ErrorModel> _logger;
        private string requestId;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            SetRequestId(Activity.Current?.Id ?? HttpContext.TraceIdentifier);
        }
    }

}
