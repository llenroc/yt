using System.ComponentModel.DataAnnotations;
using Abp.Organizations;

namespace YT.Organizations.Dto
{ /// <summary>
  /// 
  /// </summary>
    public class CreateOrganizationUnitInput
    { /// <summary>
      /// 
      /// </summary>
        public long? ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(OrganizationUnit.MaxDisplayNameLength)]
        public string DisplayName { get; set; } 
    }
}