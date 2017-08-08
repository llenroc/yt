using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;

namespace YT.Navigations.MenuDefault
{
   public abstract class BaseMenuProvider:MenuProvider
    {
      
    }

    public class AdminMenuProvider : BaseMenuProvider
    {
        public override IEnumerable<MenuDefinition> GetSettingDefinitions(MenuDefinitionProviderContext context)
        {
            return new List<MenuDefinition>()
           {
               new MenuDefinition("admin.user","用户管理","admin/user")
               {
                   Childs = new EditableList<MenuDefinition>()
               }
               ,  new MenuDefinition("admin.role","角色管理","admin/role")
               {
                   Childs = new EditableList<MenuDefinition>()
               }
                 ,  new MenuDefinition("admin.permission","权限管理","admin/permission")
               {
                   Childs = new EditableList<MenuDefinition>()
               }
           };
        }
    }
}
