using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using YT.Managers.Users;

namespace YT.Authorization.Users.Dto
{/// <summary>
 /// 
 /// </summary>
    [AutoMapFrom(typeof(User))]
    public class UserListDto : EntityDto<long>, IPassivable, IHasCreationTime
    {/// <summary>
     /// 
     /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid? ProfilePictureId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsEmailConfirmed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<UserListRoleDto> Roles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [AutoMapFrom(typeof(UserRole))]
        public class UserListRoleDto
        {/// <summary>
         /// 
         /// </summary>
            public int RoleId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string RoleName { get; set; }
        }
    }
}