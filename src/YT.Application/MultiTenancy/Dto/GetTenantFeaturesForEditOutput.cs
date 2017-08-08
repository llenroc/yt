using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YT.Editions.Dto;

namespace YT.MultiTenancy.Dto
{ /// <summary>
  /// 
  /// </summary>
    public class GetTenantFeaturesForEditOutput
    { /// <summary>
      /// 
      /// </summary>
        public List<NameValueDto> FeatureValues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FlatFeatureDto> Features { get; set; }
    }
}