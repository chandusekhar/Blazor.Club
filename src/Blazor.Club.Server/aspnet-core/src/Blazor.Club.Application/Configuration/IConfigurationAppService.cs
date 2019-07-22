using System.Threading.Tasks;
using Blazor.Club.Configuration.Dto;

namespace Blazor.Club.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
