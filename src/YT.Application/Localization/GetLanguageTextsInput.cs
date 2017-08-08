using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.Localization;
using Abp.Runtime.Validation;

namespace YT.Localization
{ /// <summary>
  /// 
  /// </summary>
    public class GetLanguageTextsInput :IPagedResultRequest, ISortedResultRequest, IShouldNormalize
    { /// <summary>
      /// 
      /// </summary>
        [Range(0, int.MaxValue)]
        public int MaxResultCount { get; set; } //0: Unlimited.
                                                /// <summary>
                                                /// 
                                                /// </summary>
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sorting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(ApplicationLanguageText.MaxSourceNameLength)]
        public string SourceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public string BaseLanguageName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength, MinimumLength = 2)]
        public string TargetLanguageName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TargetValueFilter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FilterText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void Normalize()
        {
            if (TargetValueFilter.IsNullOrEmpty())
            {
                TargetValueFilter = "ALL";
            }
        }
    }
}