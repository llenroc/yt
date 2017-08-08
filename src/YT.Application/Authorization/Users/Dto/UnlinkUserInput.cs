using Abp;
using Abp.Application.Services.Dto;

namespace YT.Authorization.Users.Dto
{/// <summary>
/// 
/// </summary>
    public class UnlinkUserInput
    {/// <summary>
    /// 
    /// </summary>
        public int? TenantId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UserIdentifier ToUserIdentifier()
        {
            return new UserIdentifier(TenantId, UserId);
        }
    }
}