using System.Linq;
using Abp;
using Abp.Authorization;
using YT.Authorization;
using YT.Tenants.Dashboard.Dto;

namespace YT.Tenants.Dashboard
{/// <summary>
 /// 
 /// </summary>
    public class TenantDashboardAppService : YtAppServiceBase, ITenantDashboardAppService
    {/// <summary>
     /// 
     /// </summary>
        public GetMemberActivityOutput GetMemberActivity()
        {
            //Generating some random data. We could get numbers from database...
            return new GetMemberActivityOutput
                   {
                       TotalMembers = Enumerable.Range(0, 13).Select(i => RandomHelper.GetRandom(15, 40)).ToList(),
                       NewMembers = Enumerable.Range(0, 13).Select(i => RandomHelper.GetRandom(3, 15)).ToList()
                   };
        }
    }
}