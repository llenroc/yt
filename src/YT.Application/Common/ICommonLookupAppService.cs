using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YT.Common.Dto;

namespace YT.Common
{/// <summary>
/// 
/// </summary>
    public interface ICommonLookupAppService : IApplicationService
    {/// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
        Task<ListResultDto<ComboboxItemDto>> GetEditionsForCombobox();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetDefaultEditionName();
    }
}