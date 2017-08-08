using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YT.Caching.Dto;

namespace YT.Caching
{/// <summary>
/// 缓存管理
/// </summary>
    public interface ICachingAppService : IApplicationService
    {/// <summary>
    /// 获取所有缓存名
    /// </summary>
    /// <returns></returns>
        ListResultDto<CacheDto> GetAllCaches();
        /// <summary>
        /// 清除缓存
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task ClearCache(EntityDto<string> input);
        /// <summary>
        /// 全部清除
        /// </summary>
        /// <returns></returns>
        Task ClearAllCaches();
    }
}
