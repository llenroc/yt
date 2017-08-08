using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using YT.Web.Controllers;

namespace YT.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}