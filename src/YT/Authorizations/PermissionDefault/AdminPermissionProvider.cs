using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;
using YT.Navigations;

namespace YT.Authorizations.PermissionDefault
{
    public abstract class BasePermissionProvider : PermissionProvider
    {

    }
    public class AdminPermissionProvider : BasePermissionProvider
    {
        public override IEnumerable<PermissionDefinition> GetPermissionDefinitions(PermissionDefinitionProviderContext context)
        {
            return new List<PermissionDefinition>()
           {

               new PermissionDefinition("pages","页面","鼻祖权限")
               {
                   Children = new EditableList<PermissionDefinition>()
                   {
           #region 用户权限设置
             new PermissionDefinition("pages.user","用户","用户权限")
                       {
            Children = new EditableList<PermissionDefinition>()
            {
                new PermissionDefinition("pages.user.add","添加用户","用户权限"),
                new PermissionDefinition("pages.user.edit","编辑用户","用户权限"),
                new PermissionDefinition("pages.user.delete","删除用户","用户权限"),
            }
                       },
        	#endregion
           #region 角色权限设置
   new PermissionDefinition("pages.role","角色","角色权限")
                       {
            Children = new EditableList<PermissionDefinition>()
            {
                new PermissionDefinition("pages.role.add","添加角色","角色权限"),
                new PermissionDefinition("pages.role.edit","编辑角色","角色权限"),
                new PermissionDefinition("pages.role.delete","删除角色","角色权限"),
                new PermissionDefinition("pages.role.allow","分配角色","角色权限"),
            }
           }
	#endregion    
                   }
               }
           };
        }
    }
}
