using System.Drawing.Imaging;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Extensions;
using Abp.IO.Extensions;
using Abp.Runtime.Session;
using Abp.UI;
using Abp.Web.Models;
using Abp.Web.Mvc.Authorization;
using YT.MultiTenancy;
using YT.Net.MimeTypes;
using YT.Storage;
using YT.Web.Helpers;
using YT.Web.MultiTenancy;

namespace YT.Web.Controllers
{
    [AbpMvcAuthorize]
    public class TenantCustomizationController : AbpZeroTemplateControllerBase
    {
        private readonly TenantManager _tenantManager;
        private readonly IBinaryObjectManager _binaryObjectManager;
        private readonly ITenancyNameFinder _tenancyNameFinder;

        public TenantCustomizationController(
            IAppFolders appFolders,
            TenantManager tenantManager,
            IBinaryObjectManager binaryObjectManager,
            ITenancyNameFinder tenancyNameFinder)
        {
            _tenantManager = tenantManager;
            _binaryObjectManager = binaryObjectManager;
            _tenancyNameFinder = tenancyNameFinder;
        }

        [HttpPost]
        public async Task<JsonResult> UploadLogo()
        {
            try
            {
                if (Request.Files.Count <= 0 || Request.Files[0] == null)
                {
                    throw new UserFriendlyException(L("File_Empty_Error"));
                }

                var file = Request.Files[0];

                if (file.ContentLength > 30720) //30KB
                {
                    throw new UserFriendlyException(L("File_SizeLimit_Error"));
                }

                var fileBytes = file.InputStream.GetAllBytes();

                if (!ImageFormatHelper.GetRawImageFormat(fileBytes).IsIn(ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Gif))
                {
                    throw new UserFriendlyException("File_Invalid_Type_Error");
                }
               
                var logoObject = new BinaryObject( "");
                await _binaryObjectManager.SaveAsync(logoObject);

                var tenant = await _tenantManager.GetByIdAsync(AbpSession.GetTenantId());
                tenant.LogoId = logoObject.Id;
                tenant.LogoFileType = file.ContentType;

                return Json(new AjaxResponse(new { id = logoObject.Id, fileType = tenant.LogoFileType }));
            }
            catch (UserFriendlyException ex)
            {
                return Json(new AjaxResponse(new ErrorInfo(ex.Message)));
            }
        }

        [HttpPost]
        public async Task<JsonResult> UploadCustomCss()
        {
            try
            {
                if (Request.Files.Count <= 0 || Request.Files[0] == null)
                {
                    throw new UserFriendlyException(L("File_Empty_Error"));
                }

                var file = Request.Files[0];

                if (file.ContentLength > 1048576) //1MB
                {
                    throw new UserFriendlyException(L("File_SizeLimit_Error"));
                }

                var fileBytes = file.InputStream.GetAllBytes();

                var cssFileObject = new BinaryObject("");
                await _binaryObjectManager.SaveAsync(cssFileObject);

                var tenant = await _tenantManager.GetByIdAsync(AbpSession.GetTenantId());
                tenant.CustomCssId = cssFileObject.Id;

                return Json(new AjaxResponse(new { id = cssFileObject.Id }));
            }
            catch (UserFriendlyException ex)
            {
                return Json(new AjaxResponse(new ErrorInfo(ex.Message)));
            }
        }
    }
}