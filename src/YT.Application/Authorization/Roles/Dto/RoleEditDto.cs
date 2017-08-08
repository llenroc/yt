using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using YT.Managers.Roles;

namespace YT.Authorization.Roles.Dto
{
    [AutoMap(typeof(Role))]
    public class RoleEditDto
    {
        public int? Id { get; set; }

        [Required]
        public string DisplayName { get; set; }
        
        public bool IsDefault { get; set; }
    }
}