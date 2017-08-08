namespace YT.Configuration.Host.Dto
{/// <summary>
/// 
/// </summary>
    public class UserLockOutSettingsEditDto
    {/// <summary>
    /// 
    /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MaxFailedAccessAttemptsBeforeLockout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int DefaultAccountLockoutSeconds { get; set; }
    }
}