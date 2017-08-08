using YT.Dto;

namespace YT.Common.Dto
{/// <summary>
/// 
/// </summary>
    public class FindUsersInput : PagedAndFilteredInputDto
    {/// <summary>
    /// 
    /// </summary>
        public int? TenantId { get; set; }
    }
}