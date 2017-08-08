using Abp.Authorization;
using YT.Authorization.Roles;
using YT.Authorization.Users;
using YT.MultiTenancy;

namespace YT.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
