﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.MultiTenancy;
using YT.Handlers;

namespace YT.Authorizations
{
    /// <summary>
    /// 权限表
    /// </summary>
    [Table("yt_permission")]
    public class YtPermission : Entity, ITreeLevel
    {
        public YtPermission()
        {
            
        }

        public YtPermission(string name, string displayName = null, string description = null)
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
            MultiTenancySides = MultiTenancySides.Host;
        }
        /// <summary>
        /// 子集
        /// </summary>
        [ForeignKey("ParentId")]
        public virtual ICollection<YtPermission> Children { get; set; }
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
        //     Depended feature(s) of this permission.
        public string FeatureDependency { get; set; }
        //
        // 摘要:
        //     Which side can use this permission.
        public MultiTenancySides MultiTenancySides { get; set; }
        //
        // 摘要:
        //     Unique name of the permission. This is the key name to grant permissions.
        public string Name { get; set; }
        //
        // 摘要:
        //     Parent of this permission if one exists. If set, this permission can be granted
        //     only if parent is granted.
        public virtual YtPermission Parent { get; set; }

        public int? ParentId { get; set; }
        public string LevelCode { get; set; }
        public int Sort { get; set; }
        /// <summary>
        /// 是否系统
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool IsActive { get; set; }
    }
}
