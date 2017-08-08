using System.Threading.Tasks;
using Abp.Application.Services;
using YT.Configuration.Host.Dto;

namespace YT.Configuration.Host
{/// <summary>
/// 
/// </summary>
    public interface IHostSettingsAppService : IApplicationService
    {/// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
        Task<HostSettingsEditDto> GetAllSettings();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateAllSettings(HostSettingsEditDto input);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task SendTestEmail(SendTestEmailInput input);
    }
}
