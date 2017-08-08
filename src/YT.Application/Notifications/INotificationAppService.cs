using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YT.Notifications.Dto;

namespace YT.Notifications
{ /// <summary>
  /// 
  /// </summary>
    public interface INotificationAppService : IApplicationService
    { /// <summary>
      /// 
      /// </summary>
        Task<GetNotificationsOutput> GetUserNotifications(GetUserNotificationsInput input);
        /// <summary>
        /// 
        /// </summary>
        Task SetAllNotificationsAsRead();
        /// <summary>
        /// 
        /// </summary>
        Task SetNotificationAsRead(EntityDto<Guid> input);
        /// <summary>
        /// 
        /// </summary>
        Task<GetNotificationSettingsOutput> GetNotificationSettings();
        /// <summary>
        /// 
        /// </summary>
        Task UpdateNotificationSettings(UpdateNotificationSettingsInput input);
    }
}