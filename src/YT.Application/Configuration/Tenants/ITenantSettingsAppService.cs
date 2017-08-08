using System.Threading.Tasks;
using Abp.Application.Services;
using YT.Configuration.Tenants.Dto;

namespace YT.Configuration.Tenants
{/// <summary>
/// 
/// </summary>
    public interface ITenantSettingsAppService : IApplicationService
    {/// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
        Task<TenantSettingsEditDto> GetAllSettings();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateAllSettings(TenantSettingsEditDto input);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task ClearLogo();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task ClearCustomCss();
    }
}
