using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using YT.Authorization.Users;
using YT.Managers.Users;

namespace YT.Configuration.Host.Dto
{/// <summary>
 /// 
 /// </summary>
    public class SendTestEmailInput
    {/// <summary>
     /// 
     /// </summary>
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}