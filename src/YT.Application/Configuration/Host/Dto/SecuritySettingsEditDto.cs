using YT.Security;

namespace YT.Configuration.Host.Dto
{/// <summary>
/// 
/// </summary>
    public class SecuritySettingsEditDto
    {/// <summary>
    /// 
    /// </summary>
        public bool UseDefaultPasswordComplexitySettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PasswordComplexitySetting PasswordComplexity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PasswordComplexitySetting DefaultPasswordComplexity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UserLockOutSettingsEditDto UserLockOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TwoFactorLoginSettingsEditDto TwoFactorLogin { get; set; }
    }
}