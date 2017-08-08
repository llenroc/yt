using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace YT.Localization.Dto
{ /// <summary>
  /// 
  /// </summary>
    public class GetLanguagesOutput : ListResultDto<ApplicationLanguageListDto>
    { /// <summary>
      /// 
      /// </summary>
        public string DefaultLanguageName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GetLanguagesOutput()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        public GetLanguagesOutput(IReadOnlyList<ApplicationLanguageListDto> items, string defaultLanguageName)
            : base(items)
        {
            DefaultLanguageName = defaultLanguageName;
        }
    }
}