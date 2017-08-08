using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YT.Configuration.Tenants.Dto;

namespace YT.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}