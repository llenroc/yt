using Abp.AutoMapper;
using YT.Authorizations;

namespace YT.Authorization.Permissions.Dto
{
    /// <summary>
    /// Ȩ��dto
    /// </summary>
    [AutoMapFrom(typeof(YtPermission))]
    public class FlatPermissionDto
    { 
        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }
       /// <summary>
       /// ��ʾ��
       /// </summary>
        public string DisplayName { get; set; }
       /// <summary>
       /// �汾
       /// </summary>
        public string FeatureDependency { get; set; }
      
        /// <summary>
        /// Ψһ��
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �ϼ�����
        /// </summary>
        public virtual string ParentName { get; set; }
        /// <summary>
        /// ����id
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
        /// �Ƿ�ϵͳ
        /// </summary>
        public bool IsStatic { get; set; }
        /// <summary>
        /// �Ƿ񼤻�
        /// </summary>
        public bool IsActive { get; set; }
    }
}