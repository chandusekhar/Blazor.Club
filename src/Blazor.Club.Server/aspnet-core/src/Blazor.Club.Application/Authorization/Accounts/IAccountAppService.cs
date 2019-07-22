using System.Threading.Tasks;
using Abp.Application.Services;
using Blazor.Club.Authorization.Accounts.Dto;

namespace Blazor.Club.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
