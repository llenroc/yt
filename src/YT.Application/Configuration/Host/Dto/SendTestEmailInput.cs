using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using YT.Authorization.Users;

namespace YT.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}