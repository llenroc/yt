namespace YT.Configuration.Host.Dto
{/// <summary>
/// 
/// </summary>
    public class EmailSettingsEditDto
    {
        //No validation is done, since we may don't want to use email system.
        /// <summary>
        /// 
        /// </summary>
        public string DefaultFromAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DefaultFromDisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SmtpHost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SmtpPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SmtpUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SmtpPassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SmtpDomain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool SmtpEnableSsl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool SmtpUseDefaultCredentials { get; set; }
    }
}