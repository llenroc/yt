using Abp.Application.Services;
using YT.Tenants.Dashboard.Dto;

namespace YT.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
