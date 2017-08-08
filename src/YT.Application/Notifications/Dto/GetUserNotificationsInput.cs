using Abp.Notifications;
using YT.Dto;

namespace YT.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}