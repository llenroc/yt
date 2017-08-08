using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using YT.Web.Areas.Mpa.Models.Common.Modals;
using YT.Web.Controllers;

namespace YT.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : AbpZeroTemplateControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}