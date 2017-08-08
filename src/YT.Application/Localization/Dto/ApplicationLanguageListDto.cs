using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Localization;

namespace YT.Localization.Dto
{/// <summary>
/// 
/// </summary>
    [AutoMapFrom(typeof(ApplicationLanguage))]
    public class ApplicationLanguageListDto : FullAuditedEntityDto
    {/// <summary>
    /// 
    /// </summary>
        public virtual int? TenantId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Icon { get; set; }
    }
}