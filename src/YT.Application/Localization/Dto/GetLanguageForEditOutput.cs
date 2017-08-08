using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace YT.Localization.Dto
{/// <summary>
/// 
/// </summary>
    public class GetLanguageForEditOutput
    {/// <summary>
    /// 
    /// </summary>
        public ApplicationLanguageEditDto Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ComboboxItemDto> LanguageNames { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ComboboxItemDto> Flags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GetLanguageForEditOutput()
        {
            LanguageNames = new List<ComboboxItemDto>();
            Flags = new List<ComboboxItemDto>();
        }
    }
}