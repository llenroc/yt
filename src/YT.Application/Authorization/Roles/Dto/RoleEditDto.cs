using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using YT.Managers.Roles;

namespace YT.Authorization.Roles.Dto
{/// <summary>
 /// 
 /// </summary>
    [AutoMap(typeof(Role))]
    public class RoleEditDto
    {/// <summary>
     /// 
     /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDefault { get; set; }
    }
}