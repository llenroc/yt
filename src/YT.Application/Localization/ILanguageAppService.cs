using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YT.Localization.Dto;

namespace YT.Localization
{ /// <summary>
  /// 
  /// </summary>
    public interface ILanguageAppService : IApplicationService
    { /// <summary>
      /// 
      /// </summary>
        Task<GetLanguagesOutput> GetLanguages();
        /// <summary>
        /// 
        /// </summary>
        Task<GetLanguageForEditOutput> GetLanguageForEdit(NullableIdDto input);
        /// <summary>
        /// 
        /// </summary>
        Task CreateOrUpdateLanguage(CreateOrUpdateLanguageInput input);
        /// <summary>
        /// 
        /// </summary>
        Task DeleteLanguage(EntityDto input);
        /// <summary>
        /// 
        /// </summary>
        Task SetDefaultLanguage(SetDefaultLanguageInput input);
        /// <summary>
        /// 
        /// </summary>
        Task<PagedResultDto<LanguageTextListDto>> GetLanguageTexts(GetLanguageTextsInput input);
        /// <summary>
        /// 
        /// </summary>
        Task UpdateLanguageText(UpdateLanguageTextInput input);
    }
}
