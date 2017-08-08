using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Localization;

namespace YT.Localization.Dto
{ /// <summary>
  /// 
  /// </summary>
    public class UpdateLanguageTextInput
    { /// <summary>
      /// 
      /// </summary>
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public string LanguageName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(ApplicationLanguageText.MaxSourceNameLength)]
        public string SourceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(ApplicationLanguageText.MaxKeyLength)]
        public string Key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(ApplicationLanguageText.MaxValueLength)]
        public string Value { get; set; }
    }
}