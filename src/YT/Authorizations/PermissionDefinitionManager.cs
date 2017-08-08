using System;
using System.Collections.Generic;
using System.Linq;
using Abp;
using Abp.Configuration;
using Abp.Dependency;
using Abp.Domain.Repositories;
using YT.Authorizations.Startup;
using YT.Configuration;
using YT.Handlers;
using YT.Navigations;

namespace YT.Authorizations
{
  public  class PermissionDefinitionManager : IPermissionDefinitionManager, ISingletonDependency
    {
        private readonly IPermissionConfiguration _permissionConfiguration;
        private readonly IRepository<YtPermission> _permissionRepository;
        private readonly ILevelEntityHandler<YtPermission> _levelEntityHandler;
        private readonly ISettingManager _settingManager;

        public PermissionDefinitionManager(IPermissionConfiguration permissionConfiguration, IRepository<YtPermission> permissionRepository, ILevelEntityHandler<YtPermission> levelEntityHandler, ISettingManager settingManager)
        {
            _permissionConfiguration = permissionConfiguration;
            _permissionRepository = permissionRepository;
            _levelEntityHandler = levelEntityHandler;
            _settingManager = settingManager;
        }
        public void Initialize()
        {
            var context = new PermissionDefinitionProviderContext(this);
            foreach (var providerType in _permissionConfiguration.Providers)
            {
                using (var provider = CreateProvider<PermissionProvider>(providerType))
                {
                    var  permissions = provider.Object.GetPermissionDefinitions(context).ToList();
                    var newList = new List<PermissionDefinition>();
                    foreach (var definition in permissions)
                    {
                        if (newList.Any(t => t.Name == definition.Name))
                        {
                            throw new AbpException(definition.Name);
                        }
                        newList.Add(definition);
                    }
                    AddOrUpdate(newList);
                }
            }
        }

        private void AddOrUpdate(IEnumerable<PermissionDefinition> definitions)
        {
            foreach (var definition in definitions)
            {
                var menu = _permissionRepository.FirstOrDefault(t => t.Name == definition.Name);
                menu = menu ?? new YtPermission();
                menu.DisplayName = definition.DisplayName;
                menu.Name = definition.Name;
                menu.ParentId = definition.ParentId;
                menu.Name = definition.Name;
                menu.IsStatic = true;

                if (menu.Id == default(int))
                {
                    var defaultactive = _settingManager.GetSettingValueForApplication<bool>(YtSettings.General.PermissionDefaultActive);
                    menu.IsActive = defaultactive;
                    _levelEntityHandler.Create(menu);
                }
                else
                {
                    if (menu.ParentId == definition.ParentId)
                        _levelEntityHandler.Update(menu);
                    else
                        _levelEntityHandler.UpdateParent(menu);
                }
                //插入子集
                if (!definition.Children.Any()) continue;
                foreach (var t in definition.Children)
                    t.ParentId = menu.Id;
                AddOrUpdate(definition.Children);
            }
        }

        private IDisposableDependencyObjectWrapper<T> CreateProvider<T>(Type providerType)
        {
            IocManager.Instance.RegisterIfNot(providerType, DependencyLifeStyle.Transient);
            return IocManager.Instance.ResolveAsDisposable<T>(providerType);
        }
    }
}
