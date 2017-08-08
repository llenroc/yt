using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.Domain.Entities;
using YT.Managers.Users;

namespace YT.Authorization.Users.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class UserEditDto : IPassivable
    {
        /// <summary>
        /// Set null to create a new user. Set user's Id to update a user
        /// </summary>
        public long? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(User.MaxNameLength)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(User.MaxSurnameLength)]
        public string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [StringLength(User.MaxPhoneNumberLength)]
        public string PhoneNumber { get; set; }
        /// <summary>
        ///  Not used "Required" attribute since empty value is used to 'not change password'
        /// </summary>
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ShouldChangePasswordOnNextLogin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual bool IsTwoFactorEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual bool IsLockoutEnabled { get; set; }
    }
}