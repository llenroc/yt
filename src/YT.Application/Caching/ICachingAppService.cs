using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YT.Caching.Dto;

namespace YT.Caching
{/// <summary>
/// �������
/// </summary>
    public interface ICachingAppService : IApplicationService
    {/// <summary>
    /// ��ȡ���л�����
    /// </summary>
    /// <returns></returns>
        ListResultDto<CacheDto> GetAllCaches();
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task ClearCache(EntityDto<string> input);
        /// <summary>
        /// ȫ�����
        /// </summary>
        /// <returns></returns>
        Task ClearAllCaches();
    }
}
