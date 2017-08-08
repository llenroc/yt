using System.ComponentModel.DataAnnotations;

namespace YT.Configuration.Host.Dto
{/// <summary>
/// 
/// </summary>
    public class HostSettingsEditDto
    {/// <summary>
    /// 
    /// </summary>
        [Required]
        public GeneralSettingsEditDto General { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public HostUserManagementSettingsEditDto UserManagement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public EmailSettingsEditDto Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public TenantManagementSettingsEditDto TenantManagement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public SecuritySettingsEditDto Security { get; set; }
        
    }
}