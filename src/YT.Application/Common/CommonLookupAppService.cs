using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Extensions;
using Abp.Linq.Extensions;
using YT.Common.Dto;
using YT.Editions;

namespace YT.Common
{/// <summary>
/// 
/// </summary>
    [AbpAuthorize]
    public class CommonLookupAppService : YtAppServiceBase, ICommonLookupAppService
    {
        private readonly EditionManager _editionManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="editionManager"></param>
        public CommonLookupAppService(EditionManager editionManager)
        {
            _editionManager = editionManager;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ListResultDto<ComboboxItemDto>> GetEditionsForCombobox()
        {
            var editions = await _editionManager.Editions.ToListAsync();
            return new ListResultDto<ComboboxItemDto>(
                editions.Select(e => new ComboboxItemDto(e.Id.ToString(), e.DisplayName)).ToList()
                );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input)
        {
            if (AbpSession.TenantId != null)
            {
                //Prevent tenants to get other tenant's users.
                input.TenantId = AbpSession.TenantId;
            }

            using (CurrentUnitOfWork.SetTenantId(input.TenantId))
            {
                var query = UserManager.Users
                    .WhereIf(
                        !input.Filter.IsNullOrWhiteSpace(),
                        u =>
                            u.Name.Contains(input.Filter) ||
                            u.Surname.Contains(input.Filter) ||
                            u.UserName.Contains(input.Filter) ||
                            u.EmailAddress.Contains(input.Filter)
                    );

                var userCount = await query.CountAsync();
                var users = await query
                    .OrderBy(u => u.Name)
                    .ThenBy(u => u.Surname)
                    .PageBy(input)
                    .ToListAsync();

                return new PagedResultDto<NameValueDto>(
                    userCount,
                    users.Select(u =>
                        new NameValueDto(
                            u.FullName + " (" + u.EmailAddress + ")",
                            u.Id.ToString()
                            )
                        ).ToList()
                    );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetDefaultEditionName()
        {
            return EditionManager.DefaultEditionName;
        }
    }
}
