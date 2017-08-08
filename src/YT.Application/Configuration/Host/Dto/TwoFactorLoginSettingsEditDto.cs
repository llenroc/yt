namespace YT.Configuration.Host.Dto
{/// <summary>
/// 
/// </summary>
    public class TwoFactorLoginSettingsEditDto
    {/// <summary>
    /// 
    /// </summary>
        public bool IsEnabledForApplication { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsEmailProviderEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsSmsProviderEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsRememberBrowserEnabled { get; set; }
    }
}