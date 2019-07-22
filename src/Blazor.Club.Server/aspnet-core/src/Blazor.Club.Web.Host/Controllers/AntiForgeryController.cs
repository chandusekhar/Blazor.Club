using Microsoft.AspNetCore.Antiforgery;
using Blazor.Club.Controllers;

namespace Blazor.Club.Web.Host.Controllers
{
    public class AntiForgeryController : ClubControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
