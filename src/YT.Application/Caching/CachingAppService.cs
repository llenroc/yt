using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Runtime.Caching;
using YT.Authorization;
using YT.Caching.Dto;

namespace YT.Caching
{/// <summary>
 /// 
 /// </summary>
    public class CachingAppService : YtAppServiceBase, ICachingAppService
    {
        private readonly ICacheManager _cacheManager;
        /// <summary>
        /// 
        /// </summary>
        public CachingAppService(ICacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }
        /// <summary>
        /// 
        /// </summary>
        public ListResultDto<CacheDto> GetAllCaches()
        {
            var caches = _cacheManager.GetAllCaches()
                                        .Select(cache => new CacheDto
                                        {
                                            Name = cache.Name
                                        })
                                        .ToList();

            return new ListResultDto<CacheDto>(caches);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task ClearCache(EntityDto<string> input)
        {
            var cache = _cacheManager.GetCache(input.Id);
            await cache.ClearAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task ClearAllCaches()
        {
            var caches = _cacheManager.GetAllCaches();
            foreach (var cache in caches)
            {
                await cache.ClearAsync();
            }
        }
    }
}