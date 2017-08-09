using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Features;
using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;
using Castle.Components.DictionaryAdapter;

namespace YT.Authorizations
{
    public class PermissionDefinition
    {
        public PermissionDefinition() { }
        public PermissionDefinition(string name, string displayName = null, string description = null, PermissionType type = PermissionType.Common)
        {
            Name = name;
            PermissionType = type;
            DisplayName = displayName;
            Description = description;
            Children = new EditableList<PermissionDefinition>();
        }

        //
        // 摘要:
        //     List of child permissions. A child permission can be granted only if parent is
        //     granted.
        public List<PermissionDefinition> Children { get; set; }
        //
        // 摘要:
        //     A brief description for this permission.
        public string Description { get; set; }
        //
        // 摘要:
        //     Display name of the permission. This can be used to show permission to the user.
        public string DisplayName { get; set; }

        //
        // 摘要:
        //     Which side can use this permission.
        public PermissionType PermissionType { get; set; }
        /// <summary>
        /// 唯一名称
        /// </summary>
        public string Name { get; set; }
        public int? ParentId { get; set; }
        /// <summary>
        /// 是否系统
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool IsActive { get; set; }

    }
    /// <summary>
    /// 权限类型
    /// </summary>
    public enum PermissionType
    {
        /// <summary>
        /// 普通
        /// </summary>
        Common = 0,
        /// <summary>
        /// 管理权限
        /// </summary>
        Control = 1,
        /// <summary>
        /// 业务权限
        /// </summary>
        Operation = 2
    }
}
