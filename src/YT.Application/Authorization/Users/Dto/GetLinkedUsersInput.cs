using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace YT.Authorization.Users.Dto
{/// <summary>
/// 
/// </summary>
    public class GetLinkedUsersInput : IPagedResultRequest, ISortedResultRequest, IShouldNormalize
    {/// <summary>
    /// 
    /// </summary>
        public int MaxResultCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SkipCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sorting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Username";
            }
        }
    }
}