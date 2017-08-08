namespace YT.Configuration.Host.Dto
{/// <summary>
/// 
/// </summary>
    public class TenantManagementSettingsEditDto
    {/// <summary>
    /// 
    /// </summary>
        public bool AllowSelfRegistration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsNewRegisteredTenantActiveByDefault { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool UseCaptchaOnRegistration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? DefaultEditionId { get; set; }
        
    }
}