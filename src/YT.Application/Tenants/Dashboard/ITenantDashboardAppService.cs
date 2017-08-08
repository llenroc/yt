using Abp.Application.Services;
using YT.Tenants.Dashboard.Dto;

namespace YT.Tenants.Dashboard
{ /// <summary>
  /// 
  /// </summary>
    public interface ITenantDashboardAppService : IApplicationService
    { /// <summary>
      /// 
      /// </summary>
        GetMemberActivityOutput GetMemberActivity();
    }
}
