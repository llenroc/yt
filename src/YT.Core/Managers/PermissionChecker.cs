using Abp.Authorization;
using Microsoft.AspNet.Identity;
using YT.Authorization.Roles;
using YT.Authorization.Users;

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
