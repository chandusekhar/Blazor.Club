using System.Threading.Tasks;
using Abp.Application.Services;
using Blazor.Club.Sessions.Dto;

namespace Blazor.Club.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
