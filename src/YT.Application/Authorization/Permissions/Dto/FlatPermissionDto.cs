using Abp.AutoMapper;
using YT.Authorizations;

namespace YT.Authorization.Permissions.Dto
{
    /// <summary>
    /// 权限dto
    /// </summary>
    [AutoMapFrom(typeof(YtPermission))]
    public class FlatPermissionDto
    { 
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
       /// <summary>
       /// 显示名
       /// </summary>
        public string DisplayName { get; set; }
       /// <summary>
       /// 版本
       /// </summary>
        public string FeatureDependency { get; set; }
      
        /// <summary>
        /// 唯一名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 上级名称
        /// </summary>
        public virtual string ParentName { get; set; }
        /// <summary>
        /// 父级id
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// level
        /// </summary>
        public string LevelCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
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