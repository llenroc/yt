using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using YT.Authorization.Permissions.Dto;
using YT.Authorizations;

namespace YT.Authorization.Permissions
{
    /// <summary>
    /// 权限service
    /// </summary>
    public class PermissionAppService : YtAppServiceBase, IPermissionAppService
    {
        private readonly IRepository<YtPermission> _permissionRepository;
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="permissionRepository"></param>
        public PermissionAppService(IRepository<YtPermission> permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        /// <summary>
        /// 获取所有的权限
        /// </summary>
        /// <returns></returns>
        public ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions()
        {
            var permissions = _permissionRepository.GetAllList();
            var rootPermissions = permissions.Where(p => p.Parent == null);

            var result = new List<FlatPermissionWithLevelDto>();
            foreach (var rootPermission in rootPermissions)
            {
                var level = 0;
                AddPermission(rootPermission, result, level);
            }
            return new ListResultDto<FlatPermissionWithLevelDto>
            {
                Items = result
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="result"></param>
        /// <param name="level"></param>
        private void AddPermission(YtPermission permission,
            List<FlatPermissionWithLevelDto> result, int level)
        {
            var flatPermission = permission.MapTo<FlatPermissionWithLevelDto>();
            flatPermission.Level = level;
            flatPermission.ParentName = permission.Parent?.DisplayName;
            result.Add(flatPermission);

            if (permission.Children == null)
            {
                return;
            }

          //  var children = allPermissions.Where(p => p.Parent != null && p.Parent.Name == permission.Name).ToList();

            foreach (var childPermission in permission.Children)
            {
                AddPermission(childPermission, result, level + 1);
            }
        }
    }
}