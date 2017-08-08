namespace YT.Configuration.Tenants.Dto
{/// <summary>
/// 
/// </summary>
    public class LdapSettingsEditDto
    {/// <summary>
    /// 
    /// </summary>
        public bool IsModuleEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
    }
}