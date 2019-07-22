using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Blazor.Club.Configuration.Dto;

namespace Blazor.Club.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ClubAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
