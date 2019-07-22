using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Blazor.Club.Data.Dto.Authorize;

namespace Blazor.Club.Data.Service.Authorize
{
    public class ClubAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;

        public ClubAuthenticationStateProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync(AuthenticateModel model)
        {
            var userInfo = await _httpClient.GetJsonAsync<AuthenticateResultModel>("http://localhost:21021/api/TokenAuth/Authenticate", model);

            // var identity = userInfo.IsAuthenticated
            //     ? new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, userInfo.Name) }, "serverauth")
            //     : new ClaimsIdentity();

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
    }
}