using System.Reflection;
using Abp.AutoMapper;
using Abp.Localization;
using Abp.Modules;
using YT.Authorization;

namespace YT
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(typeof(YtCoreModule))]
    public class YtApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper mappings
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
