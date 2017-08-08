using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YT.Authorization.Permissions.Dto;

namespace YT.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}