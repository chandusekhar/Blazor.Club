using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Blazor.Club.MultiTenancy.Dto;

namespace Blazor.Club.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

