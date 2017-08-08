using System.Reflection;
using Abp;
using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Runtime.Caching.Redis;
using Castle.MicroKernel.Registration;
using YT.Authorizations;
using YT.Authorizations.PermissionDefault;
using YT.Authorizations.Startup;
using YT.Configuration;
using YT.Handlers;
using YT.Navigations;
using YT.Navigations.MenuDefault;
using YT.Navigations.Startup;

namespace YT
{
    [DependsOn(typeof(AbpKernelModule), typeof(AbpAutoMapperModule), typeof(AbpRedisCacheModule))]
    public class YtModel:AbpModule
    {
        public override void PreInitialize()
        {
           // IocManager.Register<ISettingsConfiguration, SettingsConfiguration>();
          //  IocManager.Register<IDictionaryConfiguration, DictionarysConfiguration>();
            IocManager.Register<IMenuConfiguration, MenuConfiguration>();
          //  IocManager.Register<IRoleConfiguration, RoleConfiguration>();
          //  IocManager.Register<IUserConfiguration, UserConfiguration>();
            IocManager.Register<IPermissionConfiguration, PermissionConfiguration>();
            IocManager.Register<IModuleConfig, ModuleConfig>();
          //  IocManager.Register<IPostConfiguration, PostConfiguration>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //添加设置项 默认属性
            Configuration.Settings.Providers.Add<YtSettingProvider>();
          //  Configuration.Modules.MyModule().Settings.Providers.Add(typeof(YtSettingProvider));
            Configuration.Modules.MyModule().Menus.Providers.Add(typeof(AdminMenuProvider));
            Configuration.Modules.MyModule().Permissions.Providers.Add(typeof(AdminPermissionProvider));
            //   Configuration.Modules.MyModule().Roles.Providers.Add(typeof(YTRoleProvider));
            //  Configuration.Modules.MyModule().Users.Providers.Add(typeof(YTUserProvider));

            IocManager.IocContainer.Register(Component.For(typeof(ILevelEntityHandler<>))
                .ImplementedBy(typeof(LevelEntityHandler<>)));
         //   IocManager.IocContainer.Register(Component.For(typeof(IPermissionManager<>)).ImplementedBy(typeof(PermissionManagerBase<>)));

        }

        public override void PostInitialize()
        {
           IocManager.Resolve<IMenuDefinitionManager>().Initialize();
           IocManager.Resolve<IPermissionDefinitionManager>().Initialize();
        }

    }
}
