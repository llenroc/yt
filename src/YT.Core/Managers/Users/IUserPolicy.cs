using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace YT.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
