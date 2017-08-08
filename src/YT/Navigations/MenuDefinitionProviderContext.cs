using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
