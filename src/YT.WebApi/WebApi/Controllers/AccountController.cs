using System;
using System.Threading.Tasks;
using System.Web.Http;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Web.Models;
using Microsoft.Owin.Infrastructure;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using YT.Authorization;
using YT.Managers.MultiTenancy;
using YT.Managers.Users;
using YT.WebApi.Models;

namespace YT.WebApi.Controllers
{
    /// <summary>
    /// token ������
    /// </summary>
    public class AccountController : YtApiControllerBase
    {
        /// <summary>
        /// ��֤��׼
        /// </summary>
        public static OAuthBearerAuthenticationOptions OAuthBearerOptions { get; private set; }

        private readonly LogInManager _logInManager;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        /// <summary>
        /// static ctor
        /// </summary>
        static AccountController()
        {
            OAuthBearerOptions = new OAuthBearerAuthenticationOptions();
        }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="abpLoginResultTypeHelper"></param>
        /// <param name="logInManager"></param>
        public AccountController(
            AbpLoginResultTypeHelper abpLoginResultTypeHelper,
            LogInManager logInManager)
        {
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
            _logInManager = logInManager;
        }
        /// <summary>
        /// ��ȡ��֤
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<AjaxResponse> Authenticate(LoginModel loginModel)
        {
            var loginResult = await GetLoginResultAsync(
                loginModel.UsernameOrEmailAddress,
                loginModel.Password,
               string.Empty
                );

            var ticket = new AuthenticationTicket(loginResult.Identity, new AuthenticationProperties());
            var currentUtc = new SystemClock().UtcNow;
            ticket.Properties.IssuedUtc = currentUtc;
            //��Ч��1��
            ticket.Properties.ExpiresUtc = currentUtc.Add(TimeSpan.FromDays(1));
            return new AjaxResponse(OAuthBearerOptions.AccessTokenFormat.Protect(ticket));
        }
        /// <summary>
        /// ��ȡ��¼���
        /// </summary>
        /// <param name="usernameOrEmailAddress"></param>
        /// <param name="password"></param>
        /// <param name="tenancyName"></param>
        /// <returns></returns>
        private async Task<AbpLoginResult<Tenant, User>> GetLoginResultAsync(string usernameOrEmailAddress, string password, string tenancyName)
        {
            var loginResult = await _logInManager.LoginAsync(usernameOrEmailAddress, password, tenancyName);

            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    return loginResult;
                default:
                    throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(loginResult.Result, usernameOrEmailAddress, tenancyName);
            }
        }
    }
}
