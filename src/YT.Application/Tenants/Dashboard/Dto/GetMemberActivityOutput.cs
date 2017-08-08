using System.Collections.Generic;

namespace YT.Tenants.Dashboard.Dto
{ /// <summary>
  /// 
  /// </summary>
    public class GetMemberActivityOutput
    { /// <summary>
      /// 
      /// </summary>
        public List<int> TotalMembers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<int> NewMembers { get; set; }
    }
}