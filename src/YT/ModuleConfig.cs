using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Configuration.Startup;
using Abp.Notifications;
using YT.Navigations.Startup;

namespace YT
{
  public  class ModuleConfig: IModuleConfig
    {
        public ModuleConfig(
          ISettingsConfiguration settingsConfiguration,
        //  IDictionaryConfiguration dictionaryConfiguration,
          IMenuConfiguration menuConfiguration,
        //  IRoleConfiguration roleConfiguration,
       //   IUserConfiguration userConfiguration,
          INotificationConfiguration notificationConfiguration
         // IPostConfiguration postConfiguration
            )
        {
            Settings = settingsConfiguration;
         //   Dictionaries = dictionaryConfiguration;
            Menus = menuConfiguration;

         //   Roles = roleConfiguration;
         //   Users = userConfiguration;
            Notifications = notificationConfiguration;
         //   Posts = postConfiguration;
        }

        public ISettingsConfiguration Settings { get; }

        public IMenuConfiguration Menus { get; }

     //   public IUserConfiguration Users { get; }

     //   public IDictionaryConfiguration Dictionaries { get; }

     //   public IRoleConfiguration Roles { get; }

        public INotificationConfiguration Notifications { get; }

     //   public IPostConfiguration Posts { get; }
    }
}
