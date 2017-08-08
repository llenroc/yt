using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Localization;

namespace YT.Localization.Dto
{/// <summary>
/// 
/// </summary>
    [AutoMapFrom(typeof(ApplicationLanguage))]
    public class ApplicationLanguageEditDto
    {/// <summary>
    /// 
    /// </summary>
        public virtual int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [StringLength(ApplicationLanguage.MaxIconLength)]
        public virtual string Icon { get; set; }
    }
}