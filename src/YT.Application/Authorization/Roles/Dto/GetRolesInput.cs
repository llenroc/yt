using Abp.Application.Services.Dto;

namespace YT.Authorization.Roles.Dto
{/// <summary>
/// 获取角色input
/// </summary>
    public class GetRolesInput 
    {/// <summary>
    /// 权限过滤条件
    /// </summary>
        public string Permission { get; set; }
    }
}
