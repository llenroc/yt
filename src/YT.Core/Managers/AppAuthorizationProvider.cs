using System.Linq;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Localization;
using Abp.MultiTenancy;
using YT.Managers;
using YT.Authorizations;

namespace YT.Managers
{
    /// <summary>
    /// Application's authorization provider.
    /// Defines permissions for the application.
    /// </summary>
    public class AppAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public AppAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public AppAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, YtConsts.LocalizationSourceName);
        }
    }
}
