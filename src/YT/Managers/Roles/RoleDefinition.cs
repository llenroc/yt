using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Managers.Roles
{
  public  class RoleDefinition
    {
        /// <summary>
        /// 角色唯一名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 角色显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 菜单默认权限数据源类型
        /// </summary>
        public Type MenuProvider { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        public bool IsAdministrator { get; set; }
    }
}
