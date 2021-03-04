using Abp.Authorization;
using ABP.Test.Authorization.Roles;
using ABP.Test.Authorization.Users;

namespace ABP.Test.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
