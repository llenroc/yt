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
            //context.Manager.GetSettingDefinition(AbpZeroSettingNames.UserManagement.TwoFactorLogin.IsEnabled).DefaultValue = false.ToString().ToLowerInvariant();

            //var defaultPasswordComplexitySetting = new PasswordComplexitySetting
            //{
            //    MinLength = 6,
            //    MaxLength = 10,
            //    UseNumbers = true,
            //    UseUpperCaseLetters = false,
            //    UseLowerCaseLetters = true,
            //    UsePunctuations = false,
            //};

            return new[]
                   {
                       //Host settings
                        new SettingDefinition(YtSettings.General.MenuDefaultActive,ConfigurationManager.AppSettings[YtSettings.General.MenuDefaultActive] ?? "true"),
                  };
        }
    }
}
