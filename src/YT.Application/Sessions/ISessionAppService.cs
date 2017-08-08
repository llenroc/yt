using System.Threading.Tasks;
using Abp.Application.Services;
using YT.Sessions.Dto;

namespace YT.Sessions
{ /// <summary>
  /// 
  /// </summary>
    public interface ISessionAppService : IApplicationService
    { /// <summary>
      /// 
      /// </summary>
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
