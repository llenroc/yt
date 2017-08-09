using System.ComponentModel.DataAnnotations.Schema;
using Abp.Authorization.Roles;
using Abp.Domain.Entities;
using YT.Managers.Users;

namespace YT.Managers.Roles
{
  [Table("yt_roles")]
    public class Role : AbpRole<User>,IPassivable
    {
        //Can add application specific role properties here

        public Role()
        {
            
        }

        public Role(int? tenantId, string displayName)
            : base(tenantId, displayName)
        {

        }

        public Role(int? tenantId, string name, string displayName)
            : base(tenantId, name, displayName)
        {

        }

        public bool IsActive { get; set; }
    }
}
