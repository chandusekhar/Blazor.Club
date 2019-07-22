using Abp.Application.Services.Dto;

namespace Blazor.Club.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

