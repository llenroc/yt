namespace YT.Sessions.Dto
{ /// <summary>
  /// 
  /// </summary>
    public class GetCurrentLoginInformationsOutput
    { /// <summary>
      /// 
      /// </summary>
        public UserLoginInfoDto User { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TenantLoginInfoDto Tenant { get; set; }
    }
}