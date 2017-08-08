using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Authorizations;

namespace YT.Navigations
{
  public  class MenuDefinitionProviderContext
    {
        public IMenuDefinitionManager Manager { get; private set; }

        internal MenuDefinitionProviderContext(IMenuDefinitionManager manager)
        {
            Manager = manager;
        }
    }
    public class PermissionDefinitionProviderContext
    {
        public IPermissionDefinitionManager Manager { get; private set; }

        internal PermissionDefinitionProviderContext(IPermissionDefinitionManager manager)
        {
            Manager = manager;
        }
    }
    public class RoleDefinitionProviderContext
    {
        public IPermissionDefinitionManager Manager { get; private set; }

        internal RoleDefinitionProviderContext(IPermissionDefinitionManager manager)
        {
            Manager = manager;
        }
    }
    public class UserDefinitionProviderContext
    {
        public IPermissionDefinitionManager Manager { get; private set; }

        internal UserDefinitionProviderContext(IPermissionDefinitionManager manager)
        {
            Manager = manager;
        }
    }
}
