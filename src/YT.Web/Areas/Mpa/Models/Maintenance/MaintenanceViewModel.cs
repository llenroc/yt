using System.Collections.Generic;
using YT.Caching.Dto;

namespace YT.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}