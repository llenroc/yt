using System.Collections.Generic;
using System.Configuration;
using Abp.Configuration;
using Abp.Json;

namespace YT.Configuration
{
    /// <summary>
    /// Defines settings for the application.
    /// See <see cref="YtSettings"/> for setting names.
    /// </summary>
    public class YtSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
        

            return new[]
                   {
                       //Host settings
                        new SettingDefinition(YtSettings.General.MenuDefaultActive,
                        ConfigurationManager.AppSettings[YtSettings.General.MenuDefaultActive] ?? "true"),
                          new SettingDefinition(YtSettings.General.PermissionDefaultActive,
                        ConfigurationManager.AppSettings[YtSettings.General.PermissionDefaultActive] ?? "true"),

                             new SettingDefinition(YtSettings.General.RoleDefaultActive,
                        ConfigurationManager.AppSettings[YtSettings.General.RoleDefaultActive] ?? "true"),

                                new SettingDefinition(YtSettings.General.UserDefaultActive,
                        ConfigurationManager.AppSettings[YtSettings.General.UserDefaultActive] ?? "true"),
                  };
        }
    }
}
