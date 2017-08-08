using Abp.Application.Services;
using YT.Dto;
using YT.Logging.Dto;

namespace YT.Logging
{ /// <summary>
  /// 
  /// </summary>
    public interface IWebLogAppService : IApplicationService
    { /// <summary>
      /// 
      /// </summary>
        GetLatestWebLogsOutput GetLatestWebLogs();
        /// <summary>
        /// 
        /// </summary>
        FileDto DownloadWebLogs();
    }
}
