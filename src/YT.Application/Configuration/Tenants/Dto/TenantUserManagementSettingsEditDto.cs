namespace YT.Configuration.Tenants.Dto
{/// <summary>
/// 
/// </summary>
    public class TenantUserManagementSettingsEditDto
    {/// <summary>
    /// 
    /// </summary>
        public bool AllowSelfRegistration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsNewRegisteredUserActiveByDefault { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsEmailConfirmationRequiredForLogin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool UseCaptchaOnRegistration { get; set; }
    }
}