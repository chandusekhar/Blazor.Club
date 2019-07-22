using Abp.Authorization;
using Blazor.Club.Authorization.Roles;
using Blazor.Club.Authorization.Users;

namespace Blazor.Club.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
