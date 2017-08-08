using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using YT.Authorization;
using YT.Web.Controllers;

namespace YT.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}