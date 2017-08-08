using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YT.Organizations.Dto;

namespace YT.Organizations
{ /// <summary>
  /// 
  /// </summary>
    public interface IOrganizationUnitAppService : IApplicationService
    { /// <summary>
      /// 
      /// </summary>
        Task<ListResultDto<OrganizationUnitDto>> GetOrganizationUnits();
        /// <summary>
        /// 
        /// </summary>
        Task<PagedResultDto<OrganizationUnitUserListDto>> GetOrganizationUnitUsers(GetOrganizationUnitUsersInput input);
        /// <summary>
        /// 
        /// </summary>
        Task<OrganizationUnitDto> CreateOrganizationUnit(CreateOrganizationUnitInput input);
        /// <summary>
        /// 
        /// </summary>
        Task<OrganizationUnitDto> UpdateOrganizationUnit(UpdateOrganizationUnitInput input);
        /// <summary>
        /// 
        /// </summary>
        Task<OrganizationUnitDto> MoveOrganizationUnit(MoveOrganizationUnitInput input);
        /// <summary>
        /// 
        /// </summary>
        Task DeleteOrganizationUnit(EntityDto<long> input);
        /// <summary>
        /// 
        /// </summary>
        Task AddUserToOrganizationUnit(UserToOrganizationUnitInput input);
        /// <summary>
        /// 
        /// </summary>
        Task RemoveUserFromOrganizationUnit(UserToOrganizationUnitInput input);
        /// <summary>
        /// 
        /// </summary>
        Task<bool> IsInOrganizationUnit(UserToOrganizationUnitInput input);
    }
}
