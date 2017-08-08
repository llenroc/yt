using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YT.Authorization.Permissions.Dto;

namespace YT.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
