using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using YT.Authorization.Permissions.Dto;

namespace YT.Authorization.Permissions
{
    /// <summary>
    /// Ȩ��service
    /// </summary>
    public class PermissionAppService : YtAppServiceBase, IPermissionAppService
    {
        /// <summary>
        /// ��ȡ���е�Ȩ��
        /// </summary>
        /// <returns></returns>
        public ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions()
        {
            var permissions = PermissionManager.GetAllPermissions();
            var rootPermissions = permissions.Where(p => p.Parent == null);

            var result = new List<FlatPermissionWithLevelDto>();
            foreach (var rootPermission in rootPermissions)
            {
                var level = 0;
                AddPermission(rootPermission, permissions, result, level);
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
        /// <param name="allPermissions"></param>
        /// <param name="result"></param>
        /// <param name="level"></param>
        private void AddPermission(Permission permission, IReadOnlyList<Permission> allPermissions, List<FlatPermissionWithLevelDto> result, int level)
        {
            var flatPermission = permission.MapTo<FlatPermissionWithLevelDto>();
            flatPermission.Level = level;
            result.Add(flatPermission);

            if (permission.Children == null)
            {
                return;
            }

            var children = allPermissions.Where(p => p.Parent != null && p.Parent.Name == permission.Name).ToList();

            foreach (var childPermission in children)
            {
                AddPermission(childPermission, allPermissions, result, level + 1);
            }
        }
    }
}