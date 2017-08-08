using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YT.Authorization.Permissions.Dto;

namespace YT.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}