using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Blazor.Club.Controllers
{
    public abstract class ClubControllerBase: AbpController
    {
        protected ClubControllerBase()
        {
            LocalizationSourceName = ClubConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
