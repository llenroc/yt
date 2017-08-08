using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YT.Authorization.Users.Dto;

namespace YT.Authorization.Users
{/// <summary>
/// 
/// </summary>
    public interface IUserLinkAppService : IApplicationService
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="linkToUserInput"></param>
    /// <returns></returns>
        Task LinkToUser(LinkToUserInput linkToUserInput);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<LinkedUserDto>> GetLinkedUsers(GetLinkedUsersInput input);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ListResultDto<LinkedUserDto>> GetRecentlyUsedLinkedUsers();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UnlinkUser(UnlinkUserInput input);
    }
}
