using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using YT.Authorization.Users;
using YT.Managers.MultiTenancy;
using YT.MultiTenancy;

namespace YT.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
