using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YT.Editions.Dto;

namespace YT.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}