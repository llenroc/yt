using System.Threading.Tasks;
using Abp.Application.Services;
using YT.Sessions.Dto;

namespace YT.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
