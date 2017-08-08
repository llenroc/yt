using Abp.Application.Services;
using YT.Dto;
using YT.Logging.Dto;

namespace YT.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
