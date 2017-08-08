using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using YT.Managers.Roles;

namespace YT.Authorization.Roles.Dto
{/// <summary>
 /// 
 /// </summary>
    [AutoMapFrom(typeof(Role))]
    public class RoleListDto : EntityDto, IHasCreationTime
    {/// <summary>
     /// 
     /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsStatic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDefault { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}