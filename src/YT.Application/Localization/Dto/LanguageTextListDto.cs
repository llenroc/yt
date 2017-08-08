using Abp.Application.Services.Dto;

namespace YT.Localization.Dto
{ /// <summary>
  /// 
  /// </summary>
    public class LanguageTextListDto
    { /// <summary>
      /// 
      /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BaseValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TargetValue { get; set; }
    }
}