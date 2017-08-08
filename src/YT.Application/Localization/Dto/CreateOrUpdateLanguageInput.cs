using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace YT.Localization.Dto
{/// <summary>
/// 
/// </summary>
    public class CreateOrUpdateLanguageInput
    {/// <summary>
    /// 
    /// </summary>
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}