using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Localization;

namespace YT.Localization.Dto
{ /// <summary>
  /// 
  /// </summary>
    public class SetDefaultLanguageInput
    { /// <summary>
      /// 
      /// </summary>
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public virtual string Name { get; set; }
    }
}